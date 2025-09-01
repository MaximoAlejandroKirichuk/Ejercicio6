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
    public class JuegoMPP
    {
        private JuegoDAL juegoDAL = new JuegoDAL();
        public bool Agregar(Juego objeto)
        {
            return juegoDAL.Insertar(objeto);
        }

        public bool Bajar(int id)
        {
            return juegoDAL.Delete(id);
        }
        public bool Modificar(Juego objeto)
        {
            return juegoDAL.Update(objeto);
        }

        public List<Juego> ObtenerTodos()
        {
            DataTable dt = juegoDAL.ObtenerTodos();
            List<Juego> lista = new List<Juego>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Juego
                {
                    IdJuego = Convert.ToInt32(row["Id_Juego"]),
                    Nombre = row["Nombre"].ToString(),
                    Genero = row["Genero"].ToString(),

                });
            }
            return lista;

        }
    }
}
