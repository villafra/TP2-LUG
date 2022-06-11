using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracción;

namespace BE
{
    public class BE_Pedido :IEntidable
    {
        public int Codigo { get; set; }
        public DateTime FechaHoradeInicio { get; set; }
        public string Observaciones { get; set; }
        public BE_Mesa CodigoMesa { get; set; }
        public BE_Mozo CodigoMozo { get; set; }
        public List<BE_Plato> Platos { get; set; }
        public List<BE_Bebida> Bebidas { get; set; }
        public bool Activo { get; set; }
        public decimal Monto { get; set; }

        public BE_Pedido()
        {
            Platos = new List<BE_Plato>();
            Bebidas = new List<BE_Bebida>();
        }

        public void CalcularMonto()
        {
            Monto = 0;
            foreach (var plato in Platos)
            {
                Monto += plato.CostoUnitario;
            }
            foreach (var bebida in Bebidas)
            {
                Monto += bebida.CostoUnitario;
            }
        }
        public override string ToString()
        {
            return this.Codigo.ToString();
        }

    }
}
