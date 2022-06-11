using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Conexión;
using Abstracción;
using System.Data;

namespace Mapper
{
    public class MPP_Mesa : IGestionable<BE_Mesa>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Mesa oBE_Mesa)
        {
            if (ExisteMesaActiva(oBE_Mesa) == false)
            {
                string query = @"Delete from Mesa where [Id_Mesa]=" + oBE_Mesa.Codigo;
                Acceso = new ClsDataBase();
                return Acceso.EscribirTransaction(query);
            }
            else
            {
                return false;
            }
        }

        public bool Guardar(BE_Mesa Mesa)
        {
            string query;

            if (Mesa.Codigo != 0)
            {
                query = @"Update Mesa set [Nro_Mesa]= " + Mesa.NroDeMesa + ", Capacidad= " + Mesa.Capacidad + ", Estado= '" + Mesa.Estado + "' where [Id_Mesa]= " + Mesa.Codigo;
            }
            else
            {
                query = @"Insert into Mesa ([Nro_Mesa], Capacidad, Estado, CantidadComensales) values (" + Mesa.NroDeMesa + "," + Mesa.Capacidad + ",'" + Mesa.Estado + "'," + Mesa.CantidadComensales + ")";
            }
            Acceso = new ClsDataBase();
            return Acceso.EscribirTransaction(query);
        }

        public List<BE_Mesa> Listar()
        {
            Acceso = new ClsDataBase();
            DataSet Ds;
            string query = @"Select * from Mesa";
            Ds = Acceso.DevolverListado(query);
            List<BE_Mesa> ListadeMesas = new List<BE_Mesa>();

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    BE_Mesa Mesa = new BE_Mesa();
                    Mesa.Codigo = Convert.ToInt32(row[0].ToString());
                    Mesa.NroDeMesa = Convert.ToInt32(row[1].ToString());
                    Mesa.Capacidad = Convert.ToInt32(row[2].ToString());
                    Mesa.Estado = row[3].ToString();
                    Mesa.CantidadComensales = Convert.ToInt32(row[4].ToString());
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
            DataSet Ds;
            string query = @"Select * from Mesa where Estado = 'Disponible'";
            Ds = Acceso.DevolverListado(query);
            List<BE_Mesa> ListadeMesas = new List<BE_Mesa>();

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    BE_Mesa Mesa = new BE_Mesa();
                    Mesa.Codigo = Convert.ToInt32(row[0].ToString());
                    Mesa.NroDeMesa = Convert.ToInt32(row[1].ToString());
                    Mesa.Capacidad = Convert.ToInt32(row[2].ToString());
                    Mesa.Estado = row[3].ToString();
                    Mesa.CantidadComensales = Convert.ToInt32(row[4].ToString());
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
            Acceso = new ClsDataBase();
            string query = @"Select count(Mesa.Estado) from Mesa where Mesa.Estado <> 'Disponible' and Mesa.Nro_Mesa= " + oBE_Mesa.Codigo;
            return Acceso.LeerScalar(query);
        }
    }
}
