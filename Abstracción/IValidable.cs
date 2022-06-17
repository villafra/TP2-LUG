using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracción
{
    public interface IValidable<T> where T : IEntidable
    {
        bool Existe(T Objeto);
        bool ExisteActivo(T Objeto);
    }
}
