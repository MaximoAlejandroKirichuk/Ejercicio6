using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class JuegoDAL : IDAL<Juego>
    {
        public bool Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(StringConnection.stringConnection))
            {
                string query = "DELETE FROM Juego where Id_Juego = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Insertar(Juego objeto)
        {
            using (SqlConnection con = new SqlConnection(StringConnection.stringConnection))
            {
                string query = "Insert into Juego (Nombre, Genero) VALUES (@nombre,@genero)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@genero", objeto.Genero);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable ObtenerTodos()
        {
            using (SqlConnection con = new SqlConnection(StringConnection.stringConnection))
            {
                string query = "SELECT * FROM Juego";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        public bool Update(Juego objeto)
        {
            using (SqlConnection con = new SqlConnection(StringConnection.stringConnection))
            {
                string query = "UPDATE Juego SET Nombre = @Nombre, Genero = @genero WHERE Id_Juego = @Id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@genero", objeto.Genero);
                    cmd.Parameters.AddWithValue("@Id", objeto.IdJuego);

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (SqlException ex)
                    {
                        //"Error al modificar el producto
                        return false;
                    }
                }
            }
        }
    }
}
