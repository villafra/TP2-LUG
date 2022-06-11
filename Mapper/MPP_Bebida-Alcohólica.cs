using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Conexión;
using Abstracción;
using System.Data;

namespace Mapper
{
    public class MPP_Bebida_Alcohólica : MPP_Bebida, IGestionable<BE_Bebida_Alcohólica>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Bebida_Alcohólica Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Bebida_Alcohólica Bebida)
        {
            string query;

            if (Bebida.Codigo != 0)
            {
                query = @"Update Bebida set Nombre= '" + Bebida.Nombre + "', Tipo= '" + Bebida.Tipo + "', Presentación= '" + Bebida.Presentación + "', Precio= " + Bebida.CostoUnitario + ", Stock= " + Bebida.Stock + ", [Graduacion Alcoholica]= " + Bebida.GraduaciónAlcoholica + " where Codigo_Bebida= " + Bebida.Codigo;
            }
            else
            {
                query = @"Insert into Bebida (Nombre, Tipo, Presentación, Precio, Stock, [Graduacion Alcoholica]) values('" + Bebida.Nombre + "','" + Bebida.Tipo + "','" + Bebida.Presentación + "'," + Bebida.CostoUnitario + ",0," + Bebida.GraduaciónAlcoholica + ")";
            }
            Acceso = new ClsDataBase();
            return Acceso.EscribirTransaction(query);
        }

        public BE_Bebida_Alcohólica ListarObjeto(BE_Bebida_Alcohólica Objeto)
        {
            throw new NotImplementedException();
        }

        public new List<BE_Bebida_Alcohólica> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
