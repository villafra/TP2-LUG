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
    public class BLL_Cocina : BLL_Empleado
    {
        MPP_Cocina oMPP_Cocina;

        public BLL_Cocina()
        {
            oMPP_Cocina = new MPP_Cocina();
        }
        public override bool Baja(BE_Empleado Cocina)
        {
            return oMPP_Cocina.Baja(Cocina);
        }

        public override decimal DevolverPuntuación()
        {
            return oMPP_Cocina.DevolverPuntuacion();
        }

        public override bool Guardar(BE_Empleado Cocina)
        {
            return oMPP_Cocina.Guardar(Cocina);
        }

        public override List<BE_Empleado> Listar()
        {
            return oMPP_Cocina.Listar();
        }
        public List<BE_Cocina> ListarCocinas()
        {
            return oMPP_Cocina.ListarCocinas();
        }

        public override BE_Empleado ListarObjeto(BE_Empleado Cocina)
        {
            throw new NotImplementedException();
        }
        
    }
}
