using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexión;
using Abstracción;
using BE;

namespace Mapper
{
    public class MPP_Login : IGestionable<BE_Login>, IValidable<BE_Login>
    {
        public bool Baja(BE_Login Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(BE_Login Objeto)
        {
            throw new NotImplementedException();
        }

        public bool ExisteActivo(BE_Login Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Login Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BE_Login> Listar()
        {
            throw new NotImplementedException();
        }

        public BE_Login ListarObjeto(BE_Login Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
