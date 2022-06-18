using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracción;

namespace BE
{
    public class BE_Login :IEntidable
    {
        public int Codigo { get; set; }
        public BE_Empleado Empleado { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int CantidadIntentos { get; set; }

        public BE_Login(int codigo, BE_Empleado empleado, string usuario, string password, int cantidadIntentos)
        {
            Codigo = codigo;
            Empleado = empleado;
            Usuario = usuario;
            Password = password;
            CantidadIntentos = cantidadIntentos;
        }

        public BE_Login(BE_Empleado empleado, string usuario, string password)
        {
            Empleado = empleado;
            Usuario = usuario;
            Password = password;
        }

        public BE_Login()
        {
        }
    }

}
