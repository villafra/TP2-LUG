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
    public class BLL_Reserva : IGestionable<BE_Reserva>
    {
        MPP_Reserva oMPP_Reserva;

        public BLL_Reserva()
        {
            oMPP_Reserva = new MPP_Reserva();
        }
        public bool Baja(BE_Reserva oBE_Reserva)
        {
            return oMPP_Reserva.Baja(oBE_Reserva);
        }

        public bool Guardar(BE_Reserva oBE_Reserva)
        {
            return oMPP_Reserva.Guardar(oBE_Reserva);
        }
        public bool Guardar(BE_Reserva oBE_Reserva, BE_Mesa oBE_Mesa)
        {
            return oMPP_Reserva.Guardar(oBE_Reserva, oBE_Mesa);
        }
        public bool Modificar(BE_Reserva oBE_Reserva, BE_Mesa oBE_Mesa)
        {
            return oMPP_Reserva.Modificar(oBE_Reserva, oBE_Mesa);
        }

        public List<BE_Reserva> Listar()
        {
            return oMPP_Reserva.Listar();
        }

        public BE_Reserva ListarObjeto(BE_Reserva oBE_Reserva)
        {
            throw new NotImplementedException();
        }
    }
}
