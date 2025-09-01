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
    public class BandoDAL : IDAL<Bando>
    {
        public bool Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(StringConnection.stringConnection))
            {
                string query = "DELETE FROM Bando where Id_Bando = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Insertar(Bando objeto)
        {
            using (SqlConnection con = new SqlConnection(StringConnection.stringConnection))
            {
                string query = "Insert from Bando (Nombre) VALUES (Nombre = @nombre)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@nombre", objeto.Nombre);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable ObtenerTodos()
        {
            using (SqlConnection con = new SqlConnection(StringConnection.stringConnection))
            {
                string query = "SELECT * FROM Bando";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Update(Bando objeto)
        {
            using (SqlConnection con = new SqlConnection(StringConnection.stringConnection))
            {
                string query = "UPDATE Bando SET Nombre = @Nombre WHERE Id_Jugador = @Id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@Id", objeto.IdBando);

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
