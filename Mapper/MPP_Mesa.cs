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
using System.Data.SqlClient;

namespace Mapper
{
    public class MPP_Mesa : IGestionable<BE_Mesa>
    {
        ClsDataBase Acceso;
        Hashtable hashtable;

        public bool Baja(BE_Mesa oBE_Mesa)
        { 
            if (!ExisteMesaActiva(oBE_Mesa))
            {
                hashtable = new Hashtable();
                string query = "20 - Baja_Mesa";
                hashtable.Add("@Codigo", oBE_Mesa.Codigo);
                Acceso = new ClsDataBase();
                return Acceso.Escribir(query, hashtable);
            }
            else
            {
                return false;
            }
        }

        public bool Guardar(BE_Mesa Mesa)
        {
            hashtable = new Hashtable();
            string query = "18 - Alta_Mesa";

            if (Mesa.Codigo != 0)
            {
                query = "19 - Modificar_Mesa";
                hashtable.Add("@Codigo", Mesa.Codigo);
            }
            hashtable.Add("@ID_Mesa",Mesa.ID_Mesa);
            hashtable.Add("@Capacidad", Mesa.Capacidad);
            hashtable.Add("@Ocupacion", Mesa.CantidadComensales);
            hashtable.Add("@Status",Mesa.Status.ToString());

            if (!ExisteMesa(Mesa))
            {
                Acceso = new ClsDataBase();
                return Acceso.Escribir(query,hashtable);
            }
            else { return false; }
        }

        public bool ExisteMesa(BE_Mesa Mesa)
        {
            Hashtable hash = new Hashtable();
            SqlParameter sqlParameter = new SqlParameter();

            if (Mesa.Codigo == 0)
            {
                hash.Add("@ID_Mesa", Mesa.ID_Mesa);
                return Acceso.Scalar("40 - Existe_Mesa", hash);
            }
            else
            {
                return false;
            }
        }
        public List<BE_Mesa> Listar()
        {
            Acceso = new ClsDataBase();
            List<BE_Mesa> ListadeMesas = new List<BE_Mesa>();
            DataTable Dt = Acceso.DevolverListado("17 - Listar_Mesa",null);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    BE_Mesa Mesa = new BE_Mesa();
                    Mesa.Codigo = Convert.ToInt32(row[0].ToString());
                    Mesa.ID_Mesa = row[1].ToString();
                    Mesa.Capacidad = Convert.ToInt32(row[2].ToString());
                    if (!(row[3] is DBNull)) { Mesa.CantidadComensales = Convert.ToInt32(row[3].ToString()); }
                    else { Mesa.CantidadComensales = 0; }
                    Mesa.Status = (BE_Mesa.Estado)Enum.Parse(typeof(BE_Mesa.Estado), row[4].ToString()); 
                    ListadeMesas.Add(Mesa);
                }
            }
            else
            {
                ListadeMesas = null;
            }
            return ListadeMesas;
        }
        public List<BE_Mesa> ListarDisponibles()
        {
            Acceso = new ClsDataBase();
            List<BE_Mesa> ListadeMesas = new List<BE_Mesa>();
            Hashtable hash = new Hashtable();
            hash.Add("@Status", BE_Mesa.Estado.Libre.ToString());
            DataTable Dt = Acceso.DevolverListado("17 - Listar_Mesa", hash);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    BE_Mesa Mesa = new BE_Mesa();
                    Mesa.Codigo = Convert.ToInt32(row[0].ToString());
                    Mesa.ID_Mesa = row[1].ToString();
                    Mesa.Capacidad = Convert.ToInt32(row[2].ToString());
                    Mesa.CantidadComensales = Convert.ToInt32(row[3].ToString());
                    Mesa.Status = (BE_Mesa.Estado)Enum.Parse(typeof(BE_Mesa.Estado), row[4].ToString());
                    ListadeMesas.Add(Mesa);
                }
            }
            else
            {
                ListadeMesas = null;
            }
            return ListadeMesas;
        }

        public BE_Mesa ListarObjeto(BE_Mesa Objeto)
        {
            throw new NotImplementedException();
        }
        public bool ExisteMesaActiva(BE_Mesa oBE_Mesa)
        {
            Hashtable hash = new Hashtable();
            SqlParameter sqlParameter = new SqlParameter();

            string query = "41 - Mesa_Activa";
            hash.Add("@Codigo", oBE_Mesa.Codigo);
            return Acceso.Scalar(query, hash);
        }
    }
}
