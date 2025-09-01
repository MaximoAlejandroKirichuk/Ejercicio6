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
    public class JuegoBandoMPP
    {
        JuegoBandoDAL juegoBando = new JuegoBandoDAL();
        public bool AgregarJuegoBando(JuegoBando obj)
        {
            return juegoBando.InsertJuegoBando(obj);
        }

        public List<JuegoBando> ObtenerTodos()
        {
            DataTable dt = juegoBando.ObtenerJuegoBando();
            List<JuegoBando> lista = new List<JuegoBando>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new JuegoBando
                {
                    IdJuego = Convert.ToInt32(row["Id_Juego"]),
                    IdBando = Convert.ToInt32(row["Id_Bando"])
                });
            }
            return lista;
        }
    }
}
