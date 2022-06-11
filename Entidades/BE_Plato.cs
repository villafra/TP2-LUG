using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracción;

namespace BE
{
    public  class BE_Plato:IEntidable,IStockeable
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public Tipo Tipo_Plato  { get; set; }
        public Clasificación Clasificacion { get; set; }
        public int Stock { get; set; }
        public decimal CostoUnitario { get; set; }

        public void AgregarStock(int Cantidad)
        {
            Stock += Cantidad;
        }

        public override string ToString()
        {
            return this.Nombre;
        }
        public enum Tipo
        {
            Entrada,
            Plato_Principal,
            Postre
        }
        public enum Clasificación
        {
            Regular, 
            Vegetariano,
            Vegano,
            Sin_TACC
        }
    }
}
