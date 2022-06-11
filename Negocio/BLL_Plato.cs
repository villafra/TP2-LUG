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
    public class BLL_Plato : IGestionable<BE_Plato>
    {
        MPP_Plato oMPP_Plato;

        public BLL_Plato()
        {
            oMPP_Plato = new MPP_Plato();
        }

        public bool Baja(BE_Plato oBE_Plato)
        {
            return oMPP_Plato.Baja(oBE_Plato);
        }

        public bool Guardar(BE_Plato oBE_Plato)
        {
            return oMPP_Plato.Guardar(oBE_Plato);
        }

        public List<BE_Plato> Listar()
        {
            return oMPP_Plato.Listar();
        }
        public List<BE_Plato> ListarPlatosenPedido(BE_Pedido oBE_Pedido)
        {
            return oMPP_Plato.ListarPlatosenPedido(oBE_Pedido);
        }
        public double PromedioPlatoEnPedido(BE_Plato oBE_Plato)
        {
            return oMPP_Plato.PromedioPlatoEnPedido(oBE_Plato);
        }
        public BE_Plato ListarObjeto(BE_Plato oBE_Plato)
        {
            throw new NotImplementedException();
        }
    }
}
