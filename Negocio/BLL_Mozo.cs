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
    public class BLL_Mozo : BLL_Empleado,IGestionable<BE_Mozo>, IValidable<BE_Mozo>
    {
        MPP_Mozo oMPP_Mozo;

        public BLL_Mozo()
        {
            oMPP_Mozo = new MPP_Mozo();
        }

        public bool Baja(BE_Mozo oBE_Mozo)
        {
            return oMPP_Mozo.Baja(oBE_Mozo);
        }

        public override int DevolverPuntuacion(BE_Empleado Mozo)
        {
            return oMPP_Mozo.DevolverPuntuacion(Mozo);
        }

        public bool Existe(BE_Mozo oBE_Mozo)
        {
            return oMPP_Mozo.Existe(oBE_Mozo);
        }

        public bool ExisteActivo(BE_Mozo oBE_Mozo)
        {
            return oMPP_Mozo.ExisteActivo(oBE_Mozo);
        }

        public bool Guardar(BE_Mozo oBE_Mozo)
        {
            return oMPP_Mozo.Guardar(oBE_Mozo);
        }

        public List<BE_Mozo> Listar()
        {
            return oMPP_Mozo.Listar();
        }
        public List<BE_Mozo>ListarMozosXTurno (BE_Turno oBE_Turno)
        {
            return oMPP_Mozo.ListarMozosXTurno(oBE_Turno);
        }
        public BE_Mozo ListarObjeto(BE_Mozo oBEE_Mozo)
        {
            throw new NotImplementedException();
        }

        public List<BE_Empleado> Listartodo()
        {
            return oMPP_Mozo.ListarTodo();
        }

    }
}
