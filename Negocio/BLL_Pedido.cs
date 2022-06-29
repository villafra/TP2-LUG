using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Mapper;
using Abstracción;

namespace BLL
{
    public class BLL_Pedido : IGestionable<BE_Pedido>
    {
        MPP_Pedido oMPP_Pedido;

        public BLL_Pedido()
        {
            oMPP_Pedido = new MPP_Pedido();
        }


        public bool Baja(BE_Pedido Pedido)
        {
            return oMPP_Pedido.Baja(Pedido);
        }

        public bool Guardar(BE_Pedido Pedido)
        {
            return oMPP_Pedido.Guardar(Pedido);
        }

        public List<BE_Pedido> Listar()
        {
            return oMPP_Pedido.Listar();
        }
        public List<BE_Pedido> PlatoEnPedidos(BE_Plato oBE_Plato)
        {
            return oMPP_Pedido.PlatoEnPedidos(oBE_Plato);
        }
        public List<BE_Pedido> BebidaEnPedidos(BE_Bebida oBE_Bebida)
        {
            return oMPP_Pedido.BebidaEnPedidos(oBE_Bebida);
        }
        public BE_Pedido ListarObjeto(BE_Pedido Pedido)
        {
            throw new NotImplementedException();
        }
        private bool ActualizarMonto(BE_Pedido Pedido)
        {
            return oMPP_Pedido.ActualizarMonto(Pedido);
        }
        public bool CalcularMonto(BE_Pedido Pedido)
        {
            decimal aux = Pedido.Monto;
            Pedido.Monto = 0;
            foreach (var plato in Pedido.Platos)
            {
                Pedido.Monto += plato.CostoUnitario;
            }
            foreach (var bebida in Pedido.Bebidas)
            {
                Pedido.Monto += bebida.CostoUnitario;
            }
            if (ActualizarMonto(Pedido))
            {
                return true;
            }
            else
            {
                Pedido.Monto = aux;
                return false;
            }
        }

    }
}
