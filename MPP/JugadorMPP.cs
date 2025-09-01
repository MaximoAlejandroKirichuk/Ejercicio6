using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Data;
namespace MPP
{
    
    public class JugadorMPP
    {
        JugarorDAL jugarorDAL = new JugarorDAL();
        public bool Agregar(Jugador objeto)
        {
            return jugarorDAL.Insertar(objeto);
        }

        public bool Bajar(int id)
        {
            return jugarorDAL.Delete(id);
        }

        public bool Modificar(Jugador objeto)
        {
            return jugarorDAL.Update(objeto);
        }

        public List<Jugador> ObtenerDatos()
        {
            DataTable dt = jugarorDAL.ObtenerTodos();
            List<Jugador> lista = new List<Jugador>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Jugador
                {
                    IdJugador = Convert.ToInt32(row["Id_Jugador"]),
                    Nombre = row["Nombre"].ToString(),
                    Apellido = row["Apellido"].ToString(),
                  
                });
            }
            return lista;

        }
        
    }
}
