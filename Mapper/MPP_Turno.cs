using System;
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
    public class MPP_Turno : IGestionable<BE_Turno>, IValidable<BE_Turno>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Turno oBE_Turno)
        {
            if (!ExisteActivo(oBE_Turno))
            {
                Hashtable hashtable = new Hashtable();
                string query = "39 - Baja_Turno";
                hashtable.Add("@Codigo", oBE_Turno.Codigo);
                return Acceso.Escribir(query, hashtable);
            }
            else
            {
                return false;
            }
        }

        public bool Guardar(BE_Turno Turno)
        {
            Hashtable hashtable = new Hashtable();
            string query = "37 - Alta_Turno";

            if (Turno.Codigo != 0)
            {
                query = "38 - Modificar_Turno";
                hashtable.Add("@Codigo", Turno.Codigo);
            }
            hashtable.Add("@Nombre", Turno.NombreTurno);
            hashtable.Add("@HoraInicio", Turno.HoraInicio);
            hashtable.Add("@HoraFin", Turno.HoraFin);

            if (!Existe(Turno))
            {
                return Acceso.Escribir(query, hashtable);
            }
            else { return false; }
        }

        public List<BE_Turno> Listar()
        {
            Acceso = new ClsDataBase();
            List<BE_Turno> ListadeTurnos = new List<BE_Turno>();
            DataTable Dt = Acceso.DevolverListado("36 - Listar_Turno", null);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    BE_Turno Turno = new BE_Turno();
                    Turno.Codigo = Convert.ToInt32(row[0].ToString());
                    Turno.NombreTurno = row[1].ToString();
                    Turno.HoraInicio = Convert.ToDateTime(row[2].ToString());
                    Turno.HoraFin = Convert.ToDateTime(row[3].ToString());
                    ListadeTurnos.Add(Turno);
                }
            }
            else
            {
                ListadeTurnos = null;
            }
            return ListadeTurnos;
        }

        public BE_Turno ListarObjeto(BE_Turno Obe_Turno)
        {
            throw new NotImplementedException();
        }
        public int CantidadEmpleadosEnTurno(BE_Turno oBE_Turno)
        {
            Acceso = new ClsDataBase();
            int Cantidad = 0;
            Hashtable hash = new Hashtable();
            hash.Add("@Codigo_turno", oBE_Turno.Codigo);
            DataTable Dt = Acceso.DevolverListado("48 - Listar_Empleado_Turno", hash);
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    Cantidad = Convert.ToInt32(row[0].ToString());
                }
            }
            else { Cantidad = 0; }
            return Cantidad;
        }
        public bool Existe(BE_Turno Turno)
        {
            Acceso = new ClsDataBase();
            Hashtable hash = new Hashtable();
            if (Turno.Codigo == 0)
            {
                hash.Add("@Nombre", Turno.NombreTurno);
                return Acceso.Scalar("47 - Existe_Turno", hash);
            }
            else
            {
                hash.Add("@Nombre", Turno.NombreTurno);
                DataTable Dt = Acceso.DevolverListado("47 - Existe_Turno", hash);
                if (Dt.Rows.Count > 0)
                {
                    int codigo=0;
                    foreach (DataRow row in Dt.Rows)
                    {
                        codigo = Convert.ToInt32(row[0].ToString());
                    }
                    return !(codigo == Turno.Codigo);
                   
                }
                else
                {
                    return false;
                }
                    
            }
        }
            public bool ExisteActivo(BE_Turno Turno)
        {
            Hashtable hash = new Hashtable();
            hash.Add("@Codigo_Turno", Turno.Codigo);
            Acceso = new ClsDataBase();
            return Acceso.Scalar("46 - Existe_Turno_Activo", hash);
        }
    }
}
