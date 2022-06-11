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
    public class MPP_Cocina : MPP_Empleado
    {

        public override bool Baja(BE_Empleado Cocina)
        {
            throw new NotImplementedException();
        }

        public override decimal DevolverPuntuacion()
        {
            throw new NotImplementedException();
        }



        public override bool Guardar(BE_Empleado Cocina)
        {
            throw new NotImplementedException();
        }

        public List<BE_Cocina> ListarCocinas()
        {
            throw new NotImplementedException();
        }

        public override List<BE_Empleado> Listar()
        {
            throw new NotImplementedException();
        }

        public override BE_Empleado ListarObjeto(BE_Empleado Cocina)
        {
            throw new NotImplementedException();
        }
    }

}
