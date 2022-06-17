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
    public class MPP_Bebida : IGestionable<BE_Bebida>, IValidable<BE_Bebida>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Bebida oBE_Bebida)
        {
            string query = @"Delete from Bebida where [Codigo_Bebida]=" + oBE_Bebida.Codigo;
            Acceso = new ClsDataBase();
            throw new NotImplementedException();
        }

        public bool Existe(BE_Bebida Objeto)
        {
            throw new NotImplementedException();
        }

        public bool ExisteActivo(BE_Bebida Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Bebida Bebida)
        {
            string query;

            if (Bebida.Codigo != 0)
            {
                query = @"Update Bebida set Nombre= '" + Bebida.Nombre + "', Tipo= '" + Bebida.Tipo_Bebida.ToString() + "', Presentación= '" + Bebida.Presentación + "', Precio= " + Bebida.CostoUnitario + ", Stock= " + Bebida.Stock + "where Codigo_Bebida= " + Bebida.Codigo;
            }
            else
            {
                query = @"Insert into Bebida (Nombre, Tipo, Presentación, Precio,Stock) values('" + Bebida.Nombre + "','" + Bebida.Tipo_Bebida + "','" + Bebida.Presentación + "'," + Bebida.CostoUnitario + ", 0)";
            }
            Acceso = new ClsDataBase();
            throw new NotImplementedException();
        }

        public List<BE_Bebida> Listar()
        {
            Acceso = new ClsDataBase();
            DataSet Ds;
            string query = @"Select * from Bebida";
            throw new NotImplementedException();
            List<BE_Bebida> ListadeBebidas = new List<BE_Bebida>();

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    BE_Bebida Bebida = new BE_Bebida();
                    BE_Bebida_Alcohólica Bebida_Alcohólica = new BE_Bebida_Alcohólica();
                    if (row[6].ToString() == "")
                    {
                        Bebida.Codigo = Convert.ToInt32(row[0].ToString());
                        Bebida.Nombre = row[1].ToString();
                        Bebida.Tipo_Bebida = (BE_Bebida.Tipo)Enum.Parse(typeof(BE_Bebida.Tipo), row[2].ToString());
                        Bebida.Presentación = row[3].ToString();
                        Bebida.CostoUnitario = Convert.ToDecimal(row[4].ToString());
                        Bebida.Stock = Convert.ToInt32(row[5].ToString());
                        ListadeBebidas.Add(Bebida);
                    }
                    else
                    {
                        Bebida_Alcohólica.Codigo = Convert.ToInt32(row[0].ToString());
                        Bebida_Alcohólica.Nombre = row[1].ToString();
                        Bebida_Alcohólica.Tipo_Bebida = (BE_Bebida.Tipo)Enum.Parse(typeof(BE_Bebida.Tipo), row[2].ToString());
                        Bebida_Alcohólica.Presentación = row[3].ToString();
                        Bebida_Alcohólica.CostoUnitario = Convert.ToDecimal(row[4].ToString());
                        Bebida_Alcohólica.Stock = Convert.ToInt32(row[5].ToString());
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
            DataSet Ds;
            string query = @"Select * from Pedido_Bebida,Bebida where Bebida.Codigo_Bebida=Pedido_Bebida.Codigo_Bebida and Codigo_Pedido = " + oBE_Pedido.Codigo;
            throw new NotImplementedException();
            List<BE_Bebida> ListadeBebidas = new List<BE_Bebida>();

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    BE_Bebida Bebida = new BE_Bebida();
                    BE_Bebida_Alcohólica Bebida_Alcohólica = new BE_Bebida_Alcohólica();
                    if (row[6].ToString() == "")
                    {
                        Bebida.Codigo = Convert.ToInt32(row[0].ToString());
                        Bebida.Nombre = row[1].ToString();
                        Bebida.Tipo_Bebida = (BE_Bebida.Tipo)Enum.Parse(typeof(BE_Bebida.Tipo), row[2].ToString());
                        Bebida.Presentación = row[3].ToString();
                        Bebida.CostoUnitario = Convert.ToDecimal(row[4].ToString());
                        Bebida.Stock = Convert.ToInt32(row[5].ToString());
                        ListadeBebidas.Add(Bebida);
                    }
                    else
                    {
                        Bebida_Alcohólica.Codigo = Convert.ToInt32(row[0].ToString());
                        Bebida_Alcohólica.Nombre = row[1].ToString();
                        Bebida_Alcohólica.Tipo_Bebida = (BE_Bebida.Tipo)Enum.Parse(typeof(BE_Bebida.Tipo), row[2].ToString());
                        Bebida_Alcohólica.Presentación = row[3].ToString();
                        Bebida_Alcohólica.CostoUnitario = Convert.ToDecimal(row[4].ToString());
                        Bebida_Alcohólica.Stock = Convert.ToInt32(row[5].ToString());
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
