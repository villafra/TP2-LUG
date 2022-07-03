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
    public class BLL_Login : IGestionable<BE_Login>, IValidable<BE_Login>
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
            if (empleado.Nombre.Length < 3)
            {
                nombre = empleado.Nombre.Substring(0, empleado.Nombre.Length).ToLower();
            }
            else
            {
                nombre = empleado.Nombre.Substring(0, 3).ToLower();
            }
            if (empleado.Apellido.Length < 5)
            {
                apellido = empleado.Apellido.Substring(0, empleado.Apellido.Length).ToLower();
            }
            else
            {
                apellido = empleado.Apellido.Substring(0, 5).ToLower();
            }
            return apellido.PadRight(5, '1') + nombre.PadRight(3, '1');
        }
        public string AutoGenerarPass()
        {
            Random rand = new Random();
            string pass = null;
            for (int i = 0; i < 13; i++)
            {
                pass = pass + rand.Next(0, 9).ToString();
            }
            return EncriptarPass(pass);
        }

        public bool ResetCounter(BE_Login oBE_Login)
        {
            if (oBE_Login != null)
            {
                int aux = oBE_Login.CantidadIntentos;
                oBE_Login.CantidadIntentos = 0;
                if (Guardar(oBE_Login))
                {
                    return true;
                }
                else
                {
                    oBE_Login.CantidadIntentos = aux;
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Intentos(BE_Login oBE_Login)
        {
            if (oBE_Login.CantidadIntentos >= 5)
            {
                return false;
            }
            else { return true; }
        }
        private void IntentoFallido(BE_Login oBE_Login)
        {
            oBE_Login.CantidadIntentos += 1;
            if (!Guardar(oBE_Login))
            {
                oBE_Login.CantidadIntentos -= 1;
            }
        }
        public BE_Login Login(string user)
        {
            return oMPP_Login.Login(user);
        }
        public bool CheckPass(BE_Login oBE_Login, string pass)
        {
            string password = DesencriptarPass(oBE_Login.Password);
            if (password == pass)
            {
                return true;
            }
            else
            {
                if (oBE_Login.CantidadIntentos < 5) { IntentoFallido(oBE_Login); }
                return false;
            }

        }

        public bool EscribirXML(BE_Login login)
        {
            return oMPP_Login.EscribirXML(login);
        }
        public List<BE_Login> DevolverListado()
        {
            return oMPP_Login.DevolverListado();
        }
        public List<BE_Login> DevolverListado(BE_Empleado empleado)
        {
            return oMPP_Login.DevolverListado(empleado);
        }
        public List<BE_Login> DevolverListado(BE_Turno turno)
        {
            return oMPP_Login.DevolverListado(turno);
        }
        public List<BE_Login> DevolverListado(DateTime fecha)
        {
            return oMPP_Login.DevolverListado(fecha);
        }
        public List<BE_Login> DevolverListado(DateTime fechainicio, DateTime fechafin)
        {
            return oMPP_Login.DevolverListado(fechainicio, fechafin);
        }

        public bool Existe(BE_Login login)
        {
            return oMPP_Login.Existe(login);
        }

        public bool ExisteActivo(BE_Login login)
        {
            return oMPP_Login.ExisteActivo(login);
        }
    }
}
