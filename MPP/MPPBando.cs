using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPBando
    {
        BandoDAL dAL = new BandoDAL();
        public bool Agregar(Bando objeto)
        {
            return dAL.Insertar(objeto);
        }

        public bool Bajar(int id)
        {
            return dAL.Delete(id);
        }

        public bool Modificar(Bando objeto)
        {
            return dAL.Update(objeto);
        }

        public List<Bando> ObtenerBandos()
        {
            DataTable dt = dAL.ObtenerTodos();
            List<Bando> lista = new List<Bando>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Bando
                {
                    IdBando = Convert.ToInt32(row["Id_Bando"]),
                    Nombre = row["Nombre"].ToString()
                });
            }
            return lista;
        }
    }
}
