using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Conexión;
using Abstracción;

namespace Mapper
{
    public abstract class MPP_Empleado : IGestionable<BE_Empleado>
    {
        public abstract bool Baja(BE_Empleado Objeto);
        public abstract decimal DevolverPuntuacion();
        public abstract bool Guardar(BE_Empleado Objeto);
        public abstract List<BE_Empleado> Listar();
        public abstract BE_Empleado ListarObjeto(BE_Empleado Objeto);
    }
}
