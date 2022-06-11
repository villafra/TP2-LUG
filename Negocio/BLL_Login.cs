using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracción;
using BE;
using Mapper;
using Security;

namespace BLL
{
    public class BLL_Login : IGestionable<BE_Login>
    {
        MPP_Login oMPP_Login;
        public BLL_Login()
        {
            oMPP_Login = new MPP_Login();
        }
        public bool Baja(BE_Login login)
        {
            return oMPP_Login.Baja(login);
        }

        public bool Guardar(BE_Login login)
        {
            return oMPP_Login.Guardar(login);
        }

        public List<BE_Login> Listar()
        {
            return oMPP_Login.Listar();
        }

        public BE_Login ListarObjeto(BE_Login login)
        {
            throw new NotImplementedException();
        }
    }
}
