using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracción;
using BE;
using Mapper;

namespace BLL
{
    public class BLL_Bebida : IGestionable<BE_Bebida>, IValidable<BE_Bebida>
    {
        MPP_Bebida oMPP_Bebida;

        public BLL_Bebida()
        {
            oMPP_Bebida = new MPP_Bebida();
        }
        public bool Baja(BE_Bebida oBE_Bebida)
        {
            return oMPP_Bebida.Baja(oBE_Bebida);
        }

        public bool Guardar(BE_Bebida oBE_Bebida)
        {
            return oMPP_Bebida.Guardar(oBE_Bebida);
        }

        public List<BE_Bebida> Listar()
        {
            return oMPP_Bebida.Listar();
        }
        public List<BE_Bebida> ListarBebidasEnPedido(BE_Pedido oBE_Pedido)
        {
            return oMPP_Bebida.ListarBebidasEnPedido(oBE_Pedido);
        }
        public BE_Bebida ListarObjeto(BE_Bebida oBE_Bebida)
        {
            return oMPP_Bebida.ListarObjeto(oBE_Bebida);
        }
        public bool ExisteActivo(BE_Bebida oBE_Bebida)
        {
            return oMPP_Bebida.ExisteActivo(oBE_Bebida);
        }

        public bool Existe(BE_Bebida Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
