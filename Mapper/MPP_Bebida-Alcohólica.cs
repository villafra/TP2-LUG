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
    public class MPP_Bebida_Alcohólica : MPP_Bebida, IGestionable<BE_Bebida_Alcohólica>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Bebida_Alcohólica Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Bebida_Alcohólica Bebida)
        {
            throw new NotImplementedException();
        }

        public BE_Bebida_Alcohólica ListarObjeto(BE_Bebida_Alcohólica Objeto)
        {
            throw new NotImplementedException();
        }

        public new List<BE_Bebida_Alcohólica> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
