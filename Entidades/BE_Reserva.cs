using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracción;

namespace BE
{
    public class BE_Reserva : IEntidable
    {
        public int Codigo { get; set; }
        public BE_Mesa MesaReservada { get; set; }
        public BE_Pedido PedidoReservado { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime HoraReserva { get; set; }
        public int CantidadDeComensales { get; set; }
        public bool Estado { get; set; }

        public override string ToString()
        {
            return this.Codigo.ToString() + "-" + this.FechaReserva.ToString();
        }
    }
}
