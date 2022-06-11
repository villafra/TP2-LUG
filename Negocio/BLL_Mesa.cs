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
    public class BLL_Mesa : IGestionable<BE_Mesa>
    {
        MPP_Mesa oMPP_Mesa;

        public BLL_Mesa()
        {
            oMPP_Mesa= new MPP_Mesa();
        }
        public bool Baja(BE_Mesa oBE_Mesa)
        {
            return oMPP_Mesa.Baja(oBE_Mesa);
        }

        public bool Guardar(BE_Mesa oBE_Mesa)
        {
            return oMPP_Mesa.Guardar(oBE_Mesa);
        }

        public List<BE_Mesa> Listar()
        {
            return oMPP_Mesa.Listar();
        }
        public List<BE_Mesa> ListarDisponibles()
        {
            return oMPP_Mesa.ListarDisponibles();
        }
        public BE_Mesa ListarObjeto(BE_Mesa Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
