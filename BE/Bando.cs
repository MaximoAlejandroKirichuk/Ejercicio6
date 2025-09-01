using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Bando
    {
        public int IdBando { get; set; }

        public string Nombre { get; set; }

        public Bando()
        {
            
        }
        public Bando(string nombre, int idBando)
        {
            IdBando = idBando;
            Nombre = nombre;
        }
        public Bando(string nombre)
        {
            Nombre = nombre;
        }
    }
}
