using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracción;

namespace BE
{
    public class BE_Empleado:IEntidable
    {
        public int Codigo { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Antiguedad { get; set; }
        public BE_Turno Turno { get; set; }

        public int CalcularAños(DateTime fecha)
        {
            int Año = DateTime.Now.Year - fecha.Year;
            if (DateTime.Now.Month < fecha.Month)
            {
                Año -= 1;
            }
            if (fecha.Month == DateTime.Now.Month && DateTime.Now.Day < fecha.Day)
            {
                Año -= 1;
            }
            return Año;
        }

        public enum Puesto_Cocina
        {
            Chef,
            Ayudante_Cocina,
            Bachero
        }
        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }
    }
}
