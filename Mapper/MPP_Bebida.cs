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
    public class MPP_Bebida : IGestionable<BE_Bebida>, IValidable<BE_Bebida>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Bebida oBE_Bebida)
        {
            if (!ExisteActivo(oBE_Bebida))
            {
                Hashtable hashtable = new Hashtable();
                string query = "08 - Baja_Bebida";
                hashtable.Add("@Codigo", oBE_Bebida.Codigo);
                Acceso = new ClsDataBase();
                return Acceso.Escribir(query, hashtable);
            }
            else
            {
                return false;
            }
        }

        public bool Existe(BE_Bebida Objeto)
        {
            throw new NotImplementedException();
        }

        public bool ExisteActivo(BE_Bebida oBE_Bebida)
        {
            Hashtable hash = new Hashtable();
            hash.Add("@Codigo_Turno", oBE_Bebida.Codigo);
            Acceso = new ClsDataBase();
            return Acceso.Scalar("53 - Existe_Bebida_Activo", hash);
        }

        public bool Guardar(BE_Bebida Bebida)
        {
            Hashtable hashtable = new Hashtable();
            string query = "06 - Alta_Bebida";

            if (Bebida.Codigo != 0)
            {
                query = "07 - Modificar_Bebida";
                hashtable.Add("@Codigo", Bebida.Codigo);
            }
            hashtable.Add("@Nombre", Bebida.Nombre);
            hashtable.Add("@Tipo", Bebida.Tipo_Bebida.ToString());
            hashtable.Add("@Present", Bebida.Presentación);
            hashtable.Add("@Stock", Bebida.Stock);
            hashtable.Add("@Costo", Bebida.CostoUnitario);
            Acceso = new ClsDataBase();
            return Acceso.Escribir(query, hashtable);
        }

        public List<BE_Bebida> Listar()
        {
            Acceso = new ClsDataBase();
            List<BE_Bebida> ListadeBebidas = new List<BE_Bebida>();
            DataTable Dt = Acceso.DevolverListado("05 - Listar_Bebida", null);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    BE_Bebida Bebida = new BE_Bebida();
                    BE_Bebida_Alcohólica Bebida_Alcohólica = new BE_Bebida_Alcohólica();
                    if (row[6] is DBNull)
                    {
                        Bebida.Codigo = Convert.ToInt32(row[0].ToString());
                        Bebida.Nombre = row[1].ToString();
                        Bebida.Tipo_Bebida = (BE_Bebida.Tipo)Enum.Parse(typeof(BE_Bebida.Tipo), row[2].ToString());
                        Bebida.Presentación = row[3].ToString();
                        if (!(row[4] is DBNull))
                        {
                            Bebida.Stock = Convert.ToInt32(row[4].ToString());
                        }
                        else { Bebida.Stock = 0; }
                        
                        Bebida.CostoUnitario = Convert.ToDecimal(row[5].ToString());
                        ListadeBebidas.Add(Bebida);
                    }
                    else
                    {
                        Bebida_Alcohólica.Codigo = Convert.ToInt32(row[0].ToString());
                        Bebida_Alcohólica.Nombre = row[1].ToString();
                        Bebida_Alcohólica.Tipo_Bebida = (BE_Bebida.Tipo)Enum.Parse(typeof(BE_Bebida.Tipo), row[2].ToString());
                        Bebida_Alcohólica.Presentación = row[3].ToString();
                        if (!(row[4] is DBNull))
                        {
                            Bebida_Alcohólica.Stock = Convert.ToInt32(row[4].ToString());
                        }
                        else { Bebida_Alcohólica.Stock = 0; }
                        Bebida_Alcohólica.CostoUnitario = Convert.ToDecimal(row[5].ToString());
                        Bebida_Alcohólica.GraduaciónAlcoholica = Convert.ToDecimal(row[6].ToString());
                        ListadeBebidas.Add(Bebida_Alcohólica);
                    }
                }
            }
            else
            {
                ListadeBebidas = null;
            }
            return ListadeBebidas;
        }

        public List<BE_Bebida> ListarBebidasEnPedido(BE_Pedido oBE_Pedido)
        {
            Acceso = new ClsDataBase();
            Hashtable hash = new Hashtable();
            hash.Add("@Codigo", oBE_Pedido.Bebidas.Find(x => x.Codigo == oBE_Pedido.Codigo));
            List<BE_Bebida> ListadeBebidas = new List<BE_Bebida>();
            DataTable Dt = Acceso.DevolverListado("27 - Listar_Bebida_Pedido", hash);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow row in Dt.Rows)
                {
                    BE_Bebida Bebida = new BE_Bebida();
                    BE_Bebida_Alcohólica Bebida_Alcohólica = new BE_Bebida_Alcohólica();
                    if (row[6].ToString() == "")
                    {
                        Bebida.Codigo = Convert.ToInt32(row[0].ToString());
                        Bebida.Nombre = row[1].ToString();
                        Bebida.Tipo_Bebida = (BE_Bebida.Tipo)Enum.Parse(typeof(BE_Bebida.Tipo), row[2].ToString());
                        Bebida.Presentación = row[3].ToString();
                        Bebida.Stock = Convert.ToInt32(row[4].ToString());
                        Bebida.CostoUnitario = Convert.ToDecimal(row[5].ToString());
                        ListadeBebidas.Add(Bebida);
                    }
                    else
                    {
                        Bebida_Alcohólica.Codigo = Convert.ToInt32(row[0].ToString());
                        Bebida_Alcohólica.Nombre = row[1].ToString();
                        Bebida_Alcohólica.Tipo_Bebida = (BE_Bebida.Tipo)Enum.Parse(typeof(BE_Bebida.Tipo), row[2].ToString());
                        Bebida_Alcohólica.Presentación = row[3].ToString();
                        Bebida_Alcohólica.Stock = Convert.ToInt32(row[4].ToString());
                        Bebida_Alcohólica.CostoUnitario = Convert.ToDecimal(row[5].ToString());
                        Bebida_Alcohólica.GraduaciónAlcoholica = Convert.ToDecimal(row[6].ToString());
                        ListadeBebidas.Add(Bebida_Alcohólica);
                    }
                }
            }
            else
            {
                ListadeBebidas = null;
            }
            return ListadeBebidas;
        }
        public BE_Bebida ListarObjeto(BE_Bebida Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
