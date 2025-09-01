using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal interface IABM<T>
    {
        bool Agregar(T objeto);
        bool Bajar(int id);
        bool Modificar(T objeto);
    }
}
