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
        public string eMail { get; set; }
        public int CantidadIntentos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime HoraIngreso { get; set; }

        public BE_Login(int codigo, BE_Empleado empleado, string usuario, string password, string eMail, int cantidadIntentos, DateTime fechaIngreso, DateTime horaIngreso) : this(codigo, empleado, usuario, password, eMail, cantidadIntentos)
        {
            FechaIngreso = fechaIngreso;
            HoraIngreso = horaIngreso;
        }

        public BE_Login(int codigo, BE_Empleado empleado, string usuario, string password, string email, int cantidadIntentos)
        {
            Codigo = codigo;
            Empleado = empleado;
            Usuario = usuario;
            Password = password;
            eMail = email;
            CantidadIntentos = cantidadIntentos;
        }

        public BE_Login(BE_Empleado empleado, string usuario, string password,string email)
        {
            Empleado = empleado;
            Usuario = usuario;
            Password = password;
            eMail = email;
        }

        public BE_Login()
        {
        }
    }

}
