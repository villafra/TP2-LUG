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
    public class BLL_Cocina : BLL_Empleado, IGestionable<BE_Cocina>
    {
        MPP_Cocina oMPP_Cocina;

        public BLL_Cocina()
        {
            oMPP_Cocina = new MPP_Cocina();
        }

        public bool Baja(BE_Cocina oBEE_Cocina)
        {
            throw new NotImplementedException();
        }

        public override int DevolverPuntuacion()
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Cocina oBEE_Cocina)
        {
            throw new NotImplementedException();
        }

        public List<BE_Cocina> Listar()
        {
            throw new NotImplementedException();
        }

        public BE_Cocina ListarObjeto(BE_Cocina oBEE_Cocina)
        {
            throw new NotImplementedException();
        }
    }
}
