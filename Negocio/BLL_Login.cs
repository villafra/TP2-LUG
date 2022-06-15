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

        public string EncriptarPass(string pass)
        {
            return Encriptacion.EncriptarPass(pass);
        }
        public string DesencriptarPass(string pass)
        {
            return Encriptacion.DesencriptarPass(pass);
        }

        public string GenerarUsuario(BE_Empleado empleado)
        {
            string nombre, apellido;
            nombre = empleado.Nombre.Substring(1, 5);
            apellido = empleado.Apellido.Substring(1, 3);
            return nombre.PadRight(5, '1') + apellido.PadRight(3, '1');
        }
        public string AutoGenerarPass()
        {
            Random rand = new Random(12);
            return EncriptarPass(rand.Next().ToString());
        }
    }
}
