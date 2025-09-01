using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class JuegoBando
    {
        public int IdJuego { get; set; }

        public int IdBando { get; set; }

        public JuegoBando()
        {
            
        }
        public JuegoBando(int idjuego, int idbando)
        {
            IdJuego = idjuego;
            IdBando = idbando;
        }
    }
}
