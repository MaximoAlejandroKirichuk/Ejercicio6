using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLJuego : IABM<Juego>
    {
        JuegoMPP MPPJuego = new JuegoMPP();
        public bool Agregar(Juego objeto)
        {
            return MPPJuego.Agregar(objeto);
        }

        public bool Bajar(int id)
        { return MPPJuego.Bajar(id);
        }

        public bool Modificar(Juego objeto)
        {
            return MPPJuego.Modificar(objeto);
        }

        public List<Juego> ObtenerTodos()
        {
            return MPPJuego.ObtenerTodos();
        }
    }
}
