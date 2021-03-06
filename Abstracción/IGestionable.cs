using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracción
{
    public interface IGestionable<T> where T: IEntidable
    {
        bool Guardar(T Objeto);
        bool Baja(T Objeto);

        List<T> Listar();
        T ListarObjeto (T Objeto);



    }

}
