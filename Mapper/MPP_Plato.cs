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
    public class MPP_Plato : IGestionable<BE_Plato>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Plato oBE_Plato)
        {
            if (ExistePlatoenPedido(oBE_Plato) == false)
            {
                string query = @"Delete from Plato where [Codigo_Plato]=" + oBE_Plato.Codigo;
                Acceso = new ClsDataBase();
                throw new NotImplementedException();
            }
            else
            {
                return false;
            }
        }

        public bool Guardar(BE_Plato Plato)
        {
            string query;

            if (Plato.Codigo != 0)
            {
                query = @"Update Plato set Nombre= '" + Plato.Nombre + "', Tipo= '" + Plato.Tipo_Plato.ToString() + "', Clase= '" + Plato.Clasificacion.ToString() + "' where Codigo_Plato= " + Plato.Codigo;
            }
            else
            {
                query = @"Insert into Plato (Nombre, Tipo, Clase, Costo) values ( '" + Plato.Nombre + "','" + Plato.Tipo_Plato.ToString() + "','" + Plato.Clasificacion.ToString() + "'," + Plato.CostoUnitario + ")";
            }
            Acceso = new ClsDataBase();
            throw new NotImplementedException();
        }

        public List<BE_Plato> Listar()
        {
            Acceso = new ClsDataBase();
            DataSet Ds;
            string query = @"Select * from Plato";
            throw new NotImplementedException();
            List<BE_Plato> ListadePlatos = new List<BE_Plato>();

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    BE_Plato Plato = new BE_Plato();
                    Plato.Codigo = Convert.ToInt32(row[0].ToString());
                    Plato.Nombre = row[1].ToString();
                    Plato.Tipo_Plato = (BE_Plato.Tipo)Enum.Parse(typeof(BE_Plato.Tipo), row[2].ToString());
                    Plato.Clasificacion = (BE_Plato.Clasificación)Enum.Parse(typeof(BE_Plato.Clasificación), row[3].ToString());
                    if (!(row[4] is DBNull))
                    { Plato.Stock = Convert.ToInt32(row[4].ToString()); }
                    else { Plato.Stock = 0; }
                    Plato.CostoUnitario = Convert.ToDecimal(row[5].ToString());
                    ListadePlatos.Add(Plato);
                }
            }
            else
            {
                ListadePlatos = null;
            }
            return ListadePlatos;
        }
        public List<BE_Plato> ListarPlatosenPedido(BE_Pedido oBE_Pedido)
        {
            Acceso = new ClsDataBase();
            DataSet Ds;
            string query = @"Select * from Pedido_Plato,Plato where Plato.Codigo_Plato=Pedido_Plato.Codigo_Plato and  Codigo_Pedido = " + oBE_Pedido.Codigo;
            throw new NotImplementedException();
            List<BE_Plato> ListadePlatos = new List<BE_Plato>();

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    BE_Plato Plato = new BE_Plato();
                    Plato.Codigo = Convert.ToInt32(row[3].ToString());
                    Plato.Nombre = row[4].ToString();
                    Plato.Tipo_Plato =  (BE_Plato.Tipo)Enum.Parse(typeof(BE_Plato.Tipo), row[5].ToString());
                    Plato.Clasificacion = (BE_Plato.Clasificación)Enum.Parse(typeof(BE_Plato.Clasificación), row[6].ToString());
                    if (!(row[7] is DBNull))
                    { Plato.Stock = Convert.ToInt32(row[7].ToString()); }
                    else { Plato.Stock = 0; }
                    Plato.CostoUnitario = Convert.ToDecimal(row[8].ToString());
                    ListadePlatos.Add(Plato);
                }
            }
            else
            {
                ListadePlatos = null;
            }
            return ListadePlatos;
        }
        public BE_Plato ListarObjeto(BE_Plato Objeto)
        {
            throw new NotImplementedException();
        }
        public bool ExistePlatoenPedido(BE_Plato oBE_Plato)
        {
            Acceso = new ClsDataBase();
            string query = @"Select count (Codigo_Plato) from Pedido_Plato,Pedido where Codigo_Plato= " + oBE_Plato.Codigo + " and Pedido_Plato.Codigo_Pedido=Pedido.Codigo_Pedido and Pedido.Activo=1" ;
            throw new NotImplementedException();
        }
        public double PromedioPlatoEnPedido(BE_Plato oBE_Plato)
        {
            string[] query = new string[10];

            query[0] = @"select count (Pedido_Plato.Codigo_Plato) as Promedio from Pedido_Plato where Codigo_Plato= " + oBE_Plato.Codigo;
            query[1] = @"select count (Pedido.Codigo_Pedido) as Total from Pedido";
            Acceso = new ClsDataBase();
            throw new NotImplementedException();
            throw new NotImplementedException();
            throw new NotImplementedException();
        }
    }
}
