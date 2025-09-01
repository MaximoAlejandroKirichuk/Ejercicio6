using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Juego
    {
        public int IdJuego { get; set; }

        public string Nombre { get; set; }

        public string  Genero { get; set; }
        public Juego(string nombre , string genero)
        {
            Nombre = nombre;
            Genero = genero;
        }
        public Juego(string nombre, string genero,int idJuego)
        {
            Nombre = nombre;
            Genero = genero;
            IdJuego = idJuego;
        }
        public Juego()
        {
            
        }
    }
}
