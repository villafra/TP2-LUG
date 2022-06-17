using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Conexión;
using Abstracción;

namespace Mapper
{
    public class MPP_Cocina : IGestionable<BE_Cocina>, IValidable<BE_Cocina>
    {
        public bool Baja(BE_Cocina Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(BE_Cocina Objeto)
        {
            throw new NotImplementedException();
        }

        public bool ExisteActivo(BE_Cocina Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Cocina Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BE_Cocina> Listar()
        {
            throw new NotImplementedException();
        }

        public BE_Cocina ListarObjeto(BE_Cocina Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
