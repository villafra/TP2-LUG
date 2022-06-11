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
    public abstract class BLL_Empleado : IGestionable<BE_Empleado>
    {
        public abstract bool Baja(BE_Empleado Objeto);
        public abstract decimal DevolverPuntuación();
        public abstract bool Guardar(BE_Empleado Objeto);
        public abstract List<BE_Empleado> Listar();
        public abstract BE_Empleado ListarObjeto(BE_Empleado Objeto);
    }
}
