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

        public bool Baja(BE_Cocina oBE_Cocina)
        {
            return oMPP_Cocina.Baja(oBE_Cocina);
        }

        public override int DevolverPuntuacion(BE_Empleado Cocina)
        {
            int puntuacion = oMPP_Cocina.DevolverPuntuacion(Cocina);
            if ((Cocina as BE_Cocina).Puesto == BE_Empleado.Puesto_Cocina.Chef)
            {
                puntuacion += 10/2;
            }
           else if ((Cocina as BE_Cocina).Puesto == BE_Empleado.Puesto_Cocina.Ayudante_Cocina)
            {
                puntuacion += 6/2;
            }
            else
            {
                puntuacion += 4/2;
            }
            if (puntuacion <= 10) { return puntuacion;}
            else { return 10; }
        }

        public bool Guardar(BE_Cocina oBE_Cocina)
        {
            return oMPP_Cocina.Guardar(oBE_Cocina);
        }

        public List<BE_Cocina> Listar()
        {
            return oMPP_Cocina.Listar();
        }

        public BE_Cocina ListarObjeto(BE_Cocina oBE_Cocina)
        {
            throw new NotImplementedException();
        }
    }
}
