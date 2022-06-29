using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Reporte
    {
        public BE_Pedido Pedido { get; set; }
        public int Codigo_Mozo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }


    }
}
