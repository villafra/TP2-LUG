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
    public class BLL_Mozo : BLL_Empleado,IGestionable<BE_Mozo>
    {
        MPP_Mozo oMPP_Mozo;

        public BLL_Mozo()
        {
            oMPP_Mozo = new MPP_Mozo();
        }

        public bool Baja(BE_Mozo oBEE_Mozo)
        {
            throw new NotImplementedException();
        }

        public override int DevolverPuntuacion()
        {
            return oMPP_Mozo.DevolverPuntuacion();
        }

        public bool Guardar(BE_Mozo oBEE_Mozo)
        {
            throw new NotImplementedException();
        }

        public List<BE_Mozo> Listar()
        {
            return oMPP_Mozo.Listar();
        }

        public BE_Mozo ListarObjeto(BE_Mozo oBEE_Mozo)
        {
            throw new NotImplementedException();
        }

        public List<BE_Mozo> Listartodo()
        {
            return oMPP_Mozo.Listar();
        }

    }
}
