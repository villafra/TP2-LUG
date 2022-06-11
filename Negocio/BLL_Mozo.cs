using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstracción;
using BE;
using Mapper;


namespace BLL
{
    public class BLL_Mozo : BLL_Empleado
    {
        MPP_Mozo oMPP_Mozo;

        public BLL_Mozo()
        {
            oMPP_Mozo = new MPP_Mozo();
        }
        public override bool Baja(BE_Empleado Mozo)
        {
            return oMPP_Mozo.Baja(Mozo);
        }

        public override decimal DevolverPuntuación()
        {
            return oMPP_Mozo.DevolverPuntuacion();
        }

        public override bool Guardar(BE_Empleado Mozo)
        {
            return oMPP_Mozo.Guardar(Mozo);
        }

        public override List<BE_Empleado> Listar()
        {
            return oMPP_Mozo.Listar();
        }
        public List<BE_Mozo> ListarMozos()
        {
            return oMPP_Mozo.ListarMozos();
        }
        public override BE_Empleado ListarObjeto(BE_Empleado Mozo)
        {
            throw new NotImplementedException();
        }

    }
}
