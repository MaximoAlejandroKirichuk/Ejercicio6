using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLJuegoBando
    {
        JuegoBandoMPP juegoBandoMPP = new JuegoBandoMPP();
        public bool agregraJuegoBando(JuegoBando juegoBando)
        {
            return juegoBandoMPP.AgregarJuegoBando(juegoBando);
        }

        public List<JuegoBando> ObtenterTodos()
        {
            return juegoBandoMPP.ObtenerTodos();
        }
    }
}
