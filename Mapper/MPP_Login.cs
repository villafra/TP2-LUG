﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexión;
using Abstracción;
using BE;
using System.Collections;
using System.Data;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace Mapper
{
    public class MPP_Login : IGestionable<BE_Login>, IValidable<BE_Login>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Login oBE_Login)
        {
            if (!ExisteActivo(oBE_Login))
            {
                Hashtable hashtable = new Hashtable();
                string query = "03 - Eliminar_User_Login";
                hashtable.Add("@Codigo", oBE_Login.Codigo);
                Acceso = new ClsDataBase();
                return Acceso.Escribir(query, hashtable);
            }
            else
            {
                return false;
            }
        }

        public bool Existe(BE_Login oBE_Login)
        {
            Hashtable hash = new Hashtable();
            if (oBE_Login.Codigo == 0)
            {
                hash.Add("@Usuario", oBE_Login.Usuario);
                return Acceso.Scalar("54 - Existe_User_Login", hash);
            }
            else
            {
                return false;
            }
        }

        public bool ExisteActivo(BE_Login oBE_Login)
        {
            Hashtable hash = new Hashtable();
            hash.Add("@Codigo", oBE_Login.Empleado.Codigo);
            return Acceso.Scalar("53 - Existe_Empleado_Activo", hash);
        }

        public bool Guardar(BE_Login oBE_Login)
        {
            Hashtable hashtable = new Hashtable();
            string query = "01 - Alta_User_Login";

            if (oBE_Login.Codigo != 0)
            {
                query = "02 - Modificar_User_Login";
                hashtable.Add("@Codigo", oBE_Login.Codigo);
            }
            hashtable.Add("@Nombre", oBE_Login.Usuario);
            hashtable.Add("@Pass", oBE_Login.Password);
            hashtable.Add("eMail", oBE_Login.eMail);
            hashtable.Add("@CantInt", oBE_Login.CantidadIntentos);

            if (!Existe(oBE_Login))
            {
                Acceso = new ClsDataBase();
                return Acceso.Escribir(query, hashtable);
            }
            else { return false; }
        }

        public List<BE_Login> Listar()
        {
            Acceso = new ClsDataBase();
            List<BE_Login> ListadeLogins = new List<BE_Login>();
            DataTable Dt = Acceso.DevolverListado("00 - Listar_User_Login", null);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    BE_Login Login = new BE_Login();
                    Login.Codigo = Convert.ToInt32(row[0].ToString());
                    Login.Usuario = row[2].ToString();
                    Login.Password = row[3].ToString();
                    Login.eMail = row[4].ToString();
                    Login.CantidadIntentos = Convert.ToInt32(row[5].ToString());

                    Hashtable hash = new Hashtable();
                    hash.Add("@Codigo", Convert.ToInt32(row[1].ToString()));
                    Login.Empleado = TraerUserID(hash);
                    

                    ListadeLogins.Add(Login);
                }
            }
            else
            {
                ListadeLogins = null;
            }
            return ListadeLogins;
        }

        public BE_Login Login(string user)
        {
            Acceso = new ClsDataBase();
            BE_Login oBE_Login = new BE_Login();
            Hashtable hashtable = new Hashtable();
            hashtable.Add("@Usuario", user);
            DataTable Dt = Acceso.DevolverListado("55 - Loguearse", hashtable);
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    oBE_Login.Codigo = Convert.ToInt32(row[0].ToString());
                    oBE_Login.Usuario = row[2].ToString();
                    oBE_Login.Password = row[3].ToString();
                    oBE_Login.eMail = row[4].ToString();
                    oBE_Login.CantidadIntentos = Convert.ToInt32(row[5].ToString());
                    Hashtable hash = new Hashtable();
                    hash.Add("@Codigo", Convert.ToInt32(row[1].ToString()));
                    oBE_Login.Empleado = TraerUserID(hash);
                }
                return oBE_Login;
            }
            else
            {
                return null;
            }

        }

        public bool EscribirXML(BE_Login login)
        {
            try
            {
                if (!File.Exists("Histórico"))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", Encoding.UTF8.WebName, "yes"));
                    xmlDoc.AppendChild(xmlDoc.CreateComment("Registro de Logueo en Base de datos"));
                    XmlElement xmlElement = default(XmlElement);
                    xmlElement = xmlDoc.CreateElement("Logins");

                    XmlElement xmlLogin = xmlDoc.CreateElement("Login");
                    XmlAttribute id = xmlDoc.CreateAttribute("ID");
                    id.Value = login.Codigo.ToString();
                    xmlLogin.Attributes.Append(id);

                    XmlElement xmlUsuario = xmlDoc.CreateElement("Usuario");
                    XmlText usuario = xmlDoc.CreateTextNode(login.Usuario);
                    xmlUsuario.AppendChild(usuario);

                    XmlElement xmlPass = xmlDoc.CreateElement("Password");
                    XmlText pass = xmlDoc.CreateTextNode(login.Password);
                    xmlPass.AppendChild(pass);

                    XmlElement xmlMail = xmlDoc.CreateElement("e-Mail");
                    XmlText email = xmlDoc.CreateTextNode(login.eMail);
                    xmlMail.AppendChild(email);

                    XmlElement xmlIntentos = xmlDoc.CreateElement("Cant. Intentos");
                    XmlText intentos = xmlDoc.CreateTextNode(login.CantidadIntentos.ToString());
                    xmlIntentos.AppendChild(intentos);

                    XmlElement xmlFecha = xmlDoc.CreateElement("Fecha Ingreso");
                    XmlText fecha = xmlDoc.CreateTextNode(DateTime.Today.ToString("dd/MM/yyyy"));
                    xmlFecha.AppendChild(fecha);

                    XmlElement xmlHora = xmlDoc.CreateElement("Hora Ingreso");
                    XmlText hora = xmlDoc.CreateTextNode(DateTime.Now.ToString("HH:mm"));
                    xmlHora.AppendChild(hora);

                    XmlElement xmlEmpleado = xmlDoc.CreateElement("Datos Empleado");
                    XmlAttribute Codigo = xmlDoc.CreateAttribute("Codigo");
                    Codigo.Value = login.Empleado.Codigo.ToString();
                    xmlEmpleado.Attributes.Append(Codigo);

                    XmlElement xmlNombre = xmlDoc.CreateElement("Nombre");
                    XmlText nombre = xmlDoc.CreateTextNode(login.Empleado.Nombre);
                    xmlNombre.AppendChild(nombre);

                    XmlElement xmlApellido = xmlDoc.CreateElement("Apellido");
                    XmlText apellido = xmlDoc.CreateTextNode(login.Empleado.Apellido);
                    xmlApellido.AppendChild(apellido);

                    XmlElement xmlTurno = xmlDoc.CreateElement("Turno");
                    XmlText turno = xmlDoc.CreateTextNode(login.Empleado.Turno.ToString());
                    xmlTurno.AppendChild(turno);

                    xmlLogin.AppendChild(xmlEmpleado);
                    xmlDoc.AppendChild(xmlLogin);

                    xmlElement.AppendChild(xmlUsuario);
                    return true;
                }
                else
                {
                    XDocument xmlDoc = XDocument.Load("Histórico.xml");
                    xmlDoc.Element("Logins").Add(new XElement("Login",
                                                 new XAttribute("ID", login.Codigo.ToString()),
                                                 new XElement("Usuario", login.Usuario),
                                                 new XElement("e-Mail", login.Password),
                                                 new XElement("Cant. Intentos", login.CantidadIntentos.ToString()),
                                                 new XElement("Fecha Ingreso", DateTime.Today.ToString("dd/MM/yyyy")),
                                                 new XElement("Hora Ingreso", DateTime.Now.ToString("HH:mm")),
                                                 new XElement("Datos Empleado"),
                                                 new XAttribute("Codigo", login.Empleado.Codigo.ToString()),
                                                 new XElement("Nombre", login.Empleado.Nombre),
                                                 new XElement("Apellido", login.Empleado.Apellido),
                                                 new XElement("Turno", login.Empleado.Turno.ToString())));
                    return true;
                }
            }
            catch (XmlException xml)
            {
                return false;
                throw xml;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

        }

        private BE_Empleado TraerUserID(Hashtable hashtable)
        {
            BE_Empleado Empleado = new BE_Empleado();

            DataTable Dt = Acceso.DevolverListado("10 - Listar_Empleado", hashtable);
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    if (Empleado is BE_Cocina)
                    {
                        BE_Cocina Cocina = new BE_Cocina();
                        Cocina.Codigo = Convert.ToInt32(row[0].ToString());
                        Cocina.DNI = Convert.ToInt32(row[1].ToString());
                        Cocina.Nombre = row[2].ToString();
                        Cocina.Apellido = row[3].ToString();
                        Cocina.FechaNacimiento = Convert.ToDateTime(row[4].ToString());
                        Cocina.Edad = Cocina.CalcularAños(Cocina.FechaNacimiento);
                        Cocina.FechaIngreso = Convert.ToDateTime(row[5].ToString());
                        Cocina.Antiguedad = Cocina.CalcularAños(Cocina.FechaIngreso);
                        Hashtable hash = new Hashtable();
                        hashtable.Add("@Codigo", Convert.ToInt32(row[6].ToString()));
                        DataTable table = Acceso.DevolverListado("36 - Listar_Turno", hash);
                        foreach (DataRow dataRow in table.Rows)
                        {
                            BE_Turno oBE_Turno = new BE_Turno();
                            oBE_Turno.Codigo = Convert.ToInt32(dataRow[0].ToString());
                            oBE_Turno.NombreTurno = dataRow[1].ToString();
                            oBE_Turno.HoraInicio = Convert.ToDateTime(dataRow[2].ToString());
                            oBE_Turno.HoraFin = Convert.ToDateTime(dataRow[3].ToString());
                            Cocina.Turno = oBE_Turno;
                        }
                        Cocina.Puesto = (BE_Empleado.Puesto_Cocina)Enum.Parse(typeof(BE_Empleado.Puesto_Cocina), row[7].ToString());
                        Empleado = Cocina;
                    }
                    else
                    {
                        BE_Mozo Mozo = new BE_Mozo();
                        Mozo.Codigo = Convert.ToInt32(row[0].ToString());
                        Mozo.DNI = Convert.ToInt32(row[1].ToString());
                        Mozo.Nombre = row[2].ToString();
                        Mozo.Apellido = row[3].ToString();
                        Mozo.FechaNacimiento = Convert.ToDateTime(row[4].ToString());
                        Mozo.Edad = Mozo.CalcularAños(Mozo.FechaNacimiento);
                        Mozo.FechaIngreso = Convert.ToDateTime(row[5].ToString());
                        Mozo.Antiguedad = Mozo.CalcularAños(Mozo.FechaIngreso);

                        Hashtable hash = new Hashtable();
                        hash.Add("@Codigo", Convert.ToInt32(row[6].ToString()));
                        DataTable table = Acceso.DevolverListado("36 - Listar_Turno", hash);
                        foreach (DataRow dataRow in table.Rows)
                        {
                            BE_Turno oBE_Turno = new BE_Turno();
                            oBE_Turno.Codigo = Convert.ToInt32(dataRow[0].ToString());
                            oBE_Turno.NombreTurno = dataRow[1].ToString();
                            oBE_Turno.HoraInicio = Convert.ToDateTime(dataRow[2].ToString());
                            oBE_Turno.HoraFin = Convert.ToDateTime(dataRow[3].ToString());
                            Mozo.Turno = oBE_Turno;
                        }

                        Empleado = Mozo;
                    }
                }
            }

            return Empleado;
        }
        public BE_Login ListarObjeto(BE_Login Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
