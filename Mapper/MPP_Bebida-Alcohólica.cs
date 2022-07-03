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
    public class MPP_Bebida_Alcohólica : MPP_Bebida, IGestionable<BE_Bebida_Alcohólica>, IValidable<BE_Bebida_Alcohólica>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Bebida_Alcohólica oBE_Bebida)
        {
            if (!ExisteActivo(oBE_Bebida))
            {
                Hashtable hashtable = new Hashtable();
                string query = "08 - Baja_Bebida";
                hashtable.Add("@Codigo", oBE_Bebida.Codigo);
                return Acceso.Escribir(query, hashtable);
            }
            else
            {
                return false;
            }
        }

        public bool Guardar(BE_Bebida_Alcohólica Bebida)
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
            hashtable.Add("@ABV", Bebida.GraduaciónAlcoholica);
            Acceso = new ClsDataBase();
            return Acceso.Escribir(query, hashtable);
        }

        public BE_Bebida_Alcohólica ListarObjeto(BE_Bebida_Alcohólica Objeto)
        {
            throw new NotImplementedException();
        }

        public new List<BE_Bebida_Alcohólica> Listar()
        {
            throw new NotImplementedException();
        }

        public bool Existe(BE_Bebida_Alcohólica Objeto)
        {
            throw new NotImplementedException();
        }

        public bool ExisteActivo(BE_Bebida_Alcohólica oBE_Bebida)
        {
            Hashtable hash = new Hashtable();
            hash.Add("@Codigo_Bebida", oBE_Bebida.Codigo);
            Acceso = new ClsDataBase();
            return Acceso.Scalar("64 - Existe_Bebida_Activo", hash);
        }
    }
}
