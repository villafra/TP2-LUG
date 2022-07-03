using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Conexión;
using Abstracción;
using System.Collections;
using System.Data;

namespace Mapper
{
    public class MPP_Cocina : IGestionable<BE_Cocina>, IValidable<BE_Cocina>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Cocina oBE_Cocina)
        {
            Hashtable hashtable = new Hashtable();
            string query = "16 - Baja_Cocina";
            hashtable.Add("@Codigo", oBE_Cocina.Codigo);
            Acceso = new ClsDataBase();
            return Acceso.Escribir(query, hashtable);
        }

        public bool Existe(BE_Cocina Cocina)
        {
            Acceso = new ClsDataBase();
            Hashtable hash = new Hashtable();
            if (Cocina.Codigo == 0)
            {
                hash.Add("@DNI", Cocina.DNI);
                return Acceso.Scalar("43 - Existe_Mozo", hash);
            }
            else
            {
                hash.Add("@Codigo", Cocina.Codigo);
                hash.Add("@DNI", Cocina.DNI);
                return Acceso.Scalar("65 - Existe_DNI", hash);
            }
        }

        public bool ExisteActivo(BE_Cocina Cocina)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Cocina Cocina)
        {
            Hashtable hashtable = new Hashtable();
            string query = "14 - Alta_Cocina";

            if (Cocina.Codigo != 0)
            {
                query = "15 - Modificar_Cocina";
                hashtable.Add("@Codigo", Cocina.Codigo);
            }
            hashtable.Add("@DNI", Cocina.DNI);
            hashtable.Add("@Nombre", Cocina.Nombre);
            hashtable.Add("@Apellido", Cocina.Apellido);
            hashtable.Add("@FNac", Cocina.FechaNacimiento);
            hashtable.Add("@Fing", Cocina.FechaIngreso);
            hashtable.Add("@Codigo_Turno", Cocina.Turno.Codigo);
            hashtable.Add("@Puesto", Cocina.Puesto.ToString());

            if (!Existe(Cocina))
            {
                return Acceso.Escribir(query, hashtable);
            }
            else { return false; }
        }

        public List<BE_Cocina> Listar()
        {
            Acceso = new ClsDataBase();
            List<BE_Cocina> ListadeCocinas = new List<BE_Cocina>();
            DataTable Dt = Acceso.DevolverListado("60 - Listar_Cocina", null);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
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
                    Cocina.Puesto = (BE_Empleado.Puesto_Cocina)Enum.Parse(typeof(BE_Empleado.Puesto_Cocina), row[7].ToString());
                    ListadeCocinas.Add(Cocina);
                }
            }
            else
            {
                ListadeCocinas = null;
            }
            return ListadeCocinas;
        }

        public BE_Cocina ListarObjeto(BE_Cocina Objeto)
        {
            throw new NotImplementedException();
        }

        public int DevolverPuntuacion(BE_Empleado Cocina)
        {
            int puntuacion = 0;
            decimal promedio=0;
            string query = "62 - Buscar_Cocina_Puntuacion";
            Acceso = new ClsDataBase();
            DataTable Dt = Acceso.DevolverListado(query, null);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    if (!(row["Promedio"] is DBNull))
                    {
                        promedio = (Convert.ToDecimal(row["Promedio"].ToString()));
                    }
                    
                }
            }
            puntuacion = Convert.ToInt32(Math.Round(promedio,0));
            return puntuacion;
        }
    }
}
