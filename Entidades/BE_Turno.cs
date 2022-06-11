using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracción;

namespace BE
{
    public class BE_Turno:IEntidable
    {
        public int Codigo { get; set; }
        public string NombreTurno { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }

        public override string ToString()
        {
            return NombreTurno.ToString();
        }
    }
}
