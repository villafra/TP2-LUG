using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracción
{
    public interface IStockeable
    {
        int Stock { get; set; }
        decimal CostoUnitario { get; set; }

        void AgregarStock(int Cantidad);
    }
}
