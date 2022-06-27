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
    public abstract class BLL_Empleado
    {
        public abstract int DevolverPuntuacion(BE_Empleado oBE_Empleado);
    }
}
