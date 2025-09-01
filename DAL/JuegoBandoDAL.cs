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
    public class JuegoBandoDAL
    {
        public bool InsertJuegoBando(JuegoBando obj)
        {
            using (SqlConnection con = new SqlConnection(StringConnection.stringConnection))
            {
                string query = @"Insert into Juego_Bando (Id_Juego, Id_Bando) VALUES (@idJuego,  @idBando);";
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@idJuego", obj.IdJuego);
                    cmd.Parameters.AddWithValue("@idBando", obj.IdBando);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public DataTable ObtenerJuegoBando()
        {
            using (SqlConnection con = new SqlConnection(StringConnection.stringConnection))
            {
                string query = "SELECT * FROM Juego_Bando";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
