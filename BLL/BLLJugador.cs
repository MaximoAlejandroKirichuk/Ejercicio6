using BE;
using MPP;
using System;

namespace BLL
{
    public class BLLJugador : IABM<Jugador>
    {
        JugadorMPP mppJugador = new JugadorMPP();
        public bool Agregar(Jugador objeto)
        {
            return mppJugador.Agregar(objeto);
        }

        public bool Bajar(int id)
        {
            return mppJugador.Bajar(id);
        }

        public bool Modificar(Jugador objeto)
        {
            return mppJugador.Modificar(objeto);
        }
        public Jugador EncontrarJugador(Jugador objeto)
        {
            return mppJugador.En
        }
    }
}
