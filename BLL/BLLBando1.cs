using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLBando1 : IABM<Bando>
    {
        MPPBando mPPBando = new MPPBando();
        public bool Agregar(Bando objeto)
        {
            return mPPBando.Agregar(objeto);
        }

        public bool Bajar(int id)
        {
            return mPPBando.Bajar(id);
        }

        public bool Modificar(Bando objeto)
        {
            return mPPBando.Modificar(objeto);
        }

        public List<Bando> ObtenerBandos()
        {
            return mPPBando.ObtenerBandos();
        }
    }
}
