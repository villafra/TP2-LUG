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
    public class MPP_Plato : IGestionable<BE_Plato>, IValidable<BE_Plato>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Plato oBE_Plato)
        {
            if (!ExisteActivo(oBE_Plato))
            {
                Hashtable hashtable = new Hashtable();
                string query = "31 - Baja_Plato";
                hashtable.Add("@Codigo", oBE_Plato.Codigo);
                return Acceso.Escribir(query, hashtable);
            }
            else
            {
                return false;
            }
        }

        public bool Guardar(BE_Plato Plato)
        {
            Hashtable hashtable = new Hashtable();
            string query = "29 - Alta_Plato";

            if (Plato.Codigo != 0)
            {
                query = "30 - Modificar_Plato";
                hashtable.Add("@Codigo", Plato.Codigo);
            }
            hashtable.Add("@Nombre", Plato.Nombre);
            hashtable.Add("@Tipo", Plato.Tipo_Plato.ToString());
            hashtable.Add("@Clasi", Plato.Clasificacion.ToString());
            hashtable.Add("@Stock", Plato.Stock);
            hashtable.Add("@Costo", Plato.CostoUnitario);

            if (!Existe(Plato))
            {
                return Acceso.Escribir(query, hashtable);
            }
            else { return false; }
        }

        public List<BE_Plato> Listar()
        {
            Acceso = new ClsDataBase();
            List<BE_Plato> ListadePlatos = new List<BE_Plato>();
            DataTable Dt = Acceso.DevolverListado("28 - Listar_Plato", null);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
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
            Hashtable hash = new Hashtable();
            hash.Add("@Codigo", oBE_Pedido.Platos.Find(x=> x.Codigo == oBE_Pedido.Codigo));
            List<BE_Plato> ListadePlatos = new List<BE_Plato>();
            DataTable Dt = Acceso.DevolverListado("26 - Listar_Plato_Pedido", hash);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    BE_Plato Plato = new BE_Plato();
                    Plato.Codigo = Convert.ToInt32(row[0].ToString());
                    Plato.Nombre = row[1].ToString();
                    Plato.Tipo_Plato =  (BE_Plato.Tipo)Enum.Parse(typeof(BE_Plato.Tipo), row[2].ToString());
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
        public BE_Plato ListarObjeto(BE_Plato Objeto)
        {
            throw new NotImplementedException();
        }
       
        public double PromedioPlatoEnPedido(BE_Plato oBE_Plato)
        {
            Acceso = new ClsDataBase();
            double platos=0, pedidos = 0;
            Hashtable hash = new Hashtable();
            hash.Add("@Codigo", oBE_Plato.Codigo);
            DataTable Dt = Acceso.DevolverListado("51 - Cant_Plato_Pedido", hash);
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    platos = Convert.ToDouble(row[0].ToString());
                }
            }
            Dt = Acceso.DevolverListado("52 - Cant_Pedido", null);
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    pedidos = Convert.ToDouble(row[0].ToString());
                }
            }
            if (pedidos > 0) { return (platos/pedidos) * 100;}
            else { return 0; }
            
        }


        public bool Existe(BE_Plato Plato)
        {
            Acceso = new ClsDataBase();
            Hashtable hash = new Hashtable();
            if (Plato.Codigo == 0)
            {
                hash.Add("@Nombre", Plato.Nombre);
                return Acceso.Scalar("50 - Existe_Plato", hash);
            }
            else
            {
                hash.Add("@Nombre", Plato.Nombre);
                DataTable Dt = Acceso.DevolverListado("50 - Existe_Plato", hash);

                if (Dt.Rows.Count > 0)
                {
                    int codigo = 0;
                    foreach (DataRow row in Dt.Rows)
                    {
                        codigo = Convert.ToInt32(row[0].ToString());
                    }
                    return !(codigo == Plato.Codigo);
                }
                else
                {
                    return false;
                }

            }

        }

            public bool ExisteActivo(BE_Plato Plato)
        {
            Hashtable hash = new Hashtable();
            hash.Add("@Codigo_Plato", Plato.Codigo);
            Acceso = new ClsDataBase();
            return Acceso.Scalar("49 - Existe_Plato_Activo", hash);
        }
    }
}
