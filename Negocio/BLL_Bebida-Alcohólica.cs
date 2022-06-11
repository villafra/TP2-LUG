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
    public class BLL_Bebida_Alcohólica : BLL_Bebida, IGestionable<BE_Bebida>
    {
        MPP_Bebida oMPP_Bebida;
        MPP_Bebida_Alcohólica oMPP_Bebida_Alcohólica;

        public BLL_Bebida_Alcohólica()
        {
            oMPP_Bebida = new MPP_Bebida();
            oMPP_Bebida_Alcohólica = new MPP_Bebida_Alcohólica();
        }
        public new bool Baja(BE_Bebida oBE_Bebida)
        {
            return oMPP_Bebida.Baja(oBE_Bebida);
        }

        public bool Guardar(BE_Bebida_Alcohólica oBE_Bebida)
        {
            return oMPP_Bebida_Alcohólica.Guardar(oBE_Bebida);
        }

        public new List<BE_Bebida> Listar()
        {
            return oMPP_Bebida.Listar();
        }

    }
}
