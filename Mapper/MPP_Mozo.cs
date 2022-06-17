﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Conexión;
using Abstracción;
using System.Data;
using System.Collections;

namespace Mapper
{
    public class MPP_Mozo : IGestionable<BE_Mozo>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Mozo oBE_Mozo)
        {
            if (!ExisteMozoActivo(oBE_Mozo))
            {
                Hashtable hashtable = new Hashtable();
                string query = "13 - Baja_Mozo";
                hashtable.Add("@Codigo", oBE_Mozo.Codigo);
                Acceso = new ClsDataBase();
                return Acceso.Escribir(query, hashtable);
            }
            else
            {
                return false;
            }
        }

        public int DevolverPuntuacion()
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Mozo Mozo)
        {
            Hashtable hashtable = new Hashtable();
            string query = "11 - Alta_Mozo";

            if (Mozo.Codigo != 0)
            {
                query = "12 - Modificar_Mozo";
                hashtable.Add("@Codigo", Mozo.Codigo);
            }
            hashtable.Add("@DNI", Mozo.DNI);
            hashtable.Add("@Nombre", Mozo.Nombre);
            hashtable.Add("@Apellido", Mozo.Apellido);
            hashtable.Add("@FNac", Mozo.FechaNacimiento);
            hashtable.Add("@Fing", Mozo.FechaIngreso);
            hashtable.Add("@Codigo_Turno", Mozo.Turno);

            if (!ExisteMozo(Mozo))
            {
                Acceso = new ClsDataBase();
                return Acceso.Escribir(query, hashtable);
            }
            else { return false; }
        }

        public List<BE_Mozo> Listar()
        {
            Acceso = new ClsDataBase();
            List<BE_Mozo> ListadeMozos = new List<BE_Mozo>();
            DataTable Dt = Acceso.DevolverListado("44 - Listar_Mozo", null);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
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

                    Hashtable hashtable = new Hashtable();
                    hashtable.Add("@Codigo", Convert.ToInt32(row[6].ToString()));
                    DataTable table = Acceso.DevolverListado("36 - Listar_Turno", hashtable);
                    foreach (DataRow dataRow in table.Rows)
                    {
                    BE_Turno oBE_Turno = new BE_Turno();
                    oBE_Turno.Codigo = Convert.ToInt32(dataRow[0].ToString());
                    oBE_Turno.NombreTurno = dataRow[1].ToString();
                    oBE_Turno.HoraInicio = Convert.ToDateTime(dataRow[2].ToString());
                    oBE_Turno.HoraFin = Convert.ToDateTime(dataRow[3].ToString());
                    Mozo.Turno = oBE_Turno;
                    }

                    ListadeMozos.Add(Mozo);
                }
            }
            else
            {
                ListadeMozos = null;
            }
            return ListadeMozos;
        }

        public List<BE_Empleado> ListarTodo()
        {
            Acceso = new ClsDataBase();
            List<BE_Empleado> ListadeEmpleados = new List<BE_Empleado>();
            DataTable Dt = Acceso.DevolverListado("10 - Listar_Empleado", null);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    BE_Empleado Empleado = new BE_Empleado();
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
                        Hashtable hashtable = new Hashtable();
                        hashtable.Add("@Codigo", Convert.ToInt32(row[6].ToString()));
                        DataTable table = Acceso.DevolverListado("36 - Listar_Turno", hashtable);
                        foreach (DataRow dataRow in table.Rows)
                        {
                            BE_Turno oBE_Turno = new BE_Turno();
                            oBE_Turno.Codigo = Convert.ToInt32(dataRow[0].ToString());
                            oBE_Turno.NombreTurno = dataRow[1].ToString();
                            oBE_Turno.HoraInicio = Convert.ToDateTime(dataRow[2].ToString());
                            oBE_Turno.HoraFin = Convert.ToDateTime(dataRow[3].ToString());
                            Cocina.Turno = oBE_Turno;
                        }
                        Cocina.Puesto = (BE_Empleado.Puesto_Cocina)Enum.Parse(typeof(BE_Empleado.Puesto_Cocina),row[7].ToString());
                        ListadeEmpleados.Add(Cocina);
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

                        Hashtable hashtable = new Hashtable();
                        hashtable.Add("@Codigo", Convert.ToInt32(row[6].ToString()));
                        DataTable table = Acceso.DevolverListado("36 - Listar_Turno", hashtable);
                        foreach (DataRow dataRow in table.Rows)
                        {
                            BE_Turno oBE_Turno = new BE_Turno();
                            oBE_Turno.Codigo = Convert.ToInt32(dataRow[0].ToString());
                            oBE_Turno.NombreTurno = dataRow[1].ToString();
                            oBE_Turno.HoraInicio = Convert.ToDateTime(dataRow[2].ToString());
                            oBE_Turno.HoraFin = Convert.ToDateTime(dataRow[3].ToString());
                            Mozo.Turno = oBE_Turno;
                        }

                        ListadeEmpleados.Add(Mozo);
                    }

                }
            }
            else
            {
                ListadeEmpleados = null;
            }
            return ListadeEmpleados;
        }

        public BE_Mozo ListarObjeto(BE_Mozo Objeto)
        {
            throw new NotImplementedException();
        }
        public bool ExisteMozo(BE_Mozo Mozo)
        {
            Hashtable hash = new Hashtable();
            if (Mozo.Codigo == 0)
            {
                hash.Add("@DNI", Mozo.DNI);
                return Acceso.Scalar("43 - Existe_Mozo", hash);
            }
            else
            {
                return false;
            }
        }
        public bool ExisteMozoActivo(BE_Mozo Mozo)
        {
            Hashtable hash = new Hashtable();
            hash.Add("@Codigo_Mozo", Mozo.Codigo);
            return Acceso.Scalar("45 - Existe_Mozo_Activo", hash);
        }
    }
}
