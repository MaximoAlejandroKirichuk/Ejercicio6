using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP.NUM3
{
    public partial class FormJuego : Form
    {
        public FormJuego()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private BLLJuego BLLJuego = new BLLJuego();
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = TxnNombre.Text;
                string genero = TxtGenero.Text;
                var juego = new Juego(nombre, genero);
                var respuesta = BLLJuego.Agregar(juego);
                if (!respuesta) throw new Exception("Ocurrio un error");
                MessageBox.Show("Se agrego");
                ActualizarData();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
                int idJuego = Convert.ToInt32(row["Id_Juego"]);
                string nombre = row["Nombre"].ToString();
                string genero = row["Genero"].ToString();

                try
                {
                    var nuevo = new Juego(nombre, genero, idJuego);
                    var respuesta = BLLJuego.Bajar(idJuego);
                    if (!respuesta) throw new Exception("Ocurrio un error al borrar");
                    MessageBox.Show("Se borro correctamente");
                    ActualizarData();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ActualizarData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BLLJuego.ObtenerTodos();
        }
        private void FormJuego_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLJuego.ObtenerTodos();
            ActualizarData();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                DataRowView row = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
                int idJuego = Convert.ToInt32(row["Id_Juego"]);
                string nombre = row["Nombre"].ToString();
                string genero = row["Genero"].ToString();

                try
                {
                    var nuevo = new Juego(nombre, genero, idJuego);
                    var respuesta = BLLJuego.Modificar(nuevo);
                    if (!respuesta) throw new Exception("Ocurrio un error al modificar");
                    MessageBox.Show("Se modifico correctamente");
                    ActualizarData();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
