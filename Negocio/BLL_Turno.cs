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
    public class BLL_Turno : IGestionable<BE_Turno>, IValidable<BE_Turno>
    {
        MPP_Turno oMPP_Turno;

        public BLL_Turno()
        {
            oMPP_Turno = new MPP_Turno();
        }

        public bool Baja(BE_Turno oBE_Turno)
        {
           return oMPP_Turno.Baja(oBE_Turno);
        }

        public bool Guardar(BE_Turno oBE_Turno)
        {
            return oMPP_Turno.Guardar(oBE_Turno);
        }

        public List<BE_Turno> Listar()
        {
            return oMPP_Turno.Listar();
        }

        public int CantidadEmpleadosEnTurno(BE_Turno oBE_Turno)
        {
            return oMPP_Turno.CantidadEmpleadosEnTurno(oBE_Turno);
        }

        public BE_Turno ListarObjeto(BE_Turno oBE_Turno)
        {
            return oMPP_Turno.ListarObjeto(oBE_Turno);  
        }

        public bool Existe(BE_Turno oBE_Turno)
        {
            return oMPP_Turno.Existe(oBE_Turno);
        }

        public bool ExisteActivo(BE_Turno oBE_Turno)
        {
            return oMPP_Turno.ExisteActivo(oBE_Turno);
        }
    }
}
