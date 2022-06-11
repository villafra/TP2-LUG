using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracción;

namespace BE
{
    public class BE_Mesa:IEntidable
    {
        public int Codigo { get; set; }
        public string ID_Mesa { get; set; }
        public int Capacidad { get; set; }
        public int CantidadComensales { get; set; }
        public Estado Status { get; set; }

        public override string ToString()
        {
            return ID_Mesa.ToString();
        }

        public enum Estado
        {
            Libre,
            Reservada,
            Ocupada,
            No_Disponible
        }
    }
}
