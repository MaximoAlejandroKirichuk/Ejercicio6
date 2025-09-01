using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdJugador { get; set; }
        public Jugador()
        {
            
        }
        public Jugador(string nombre, string apellido, int idjugador)
        {
            Nombre = nombre;
            Apellido = apellido;
            IdJugador = idjugador;
        }
        public Jugador(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
