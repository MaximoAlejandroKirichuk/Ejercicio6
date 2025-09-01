using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP.NUM3
{
    public partial class FormJugador : Form
    {
        public FormJugador()
        {
            InitializeComponent();
        }
        private BLLJugador bLLJugador = new BLLJugador();
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            try
            {
                var nuevo = new Jugador(nombre,apellido);
                var respuesta = bLLJugador.Agregar(nuevo);
                if (!respuesta) throw new Exception("Ocurrio un error al agregar");
                MessageBox.Show("Se agrego correctamente");
                ActualizarData();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            string nombre = row["Nombre"].ToString();
            string apellido = row["Apellido"].ToString();
            int idJugador = Convert.ToInt32(row["Id_Jugador"]);
            try
            {
                var nuevo = new Jugador(nombre, apellido, idJugador);
                var respuesta = bLLJugador.Bajar(nuevo.IdJugador);
                if (!respuesta) throw new Exception("Ocurrio un error al borrar");
                MessageBox.Show("Se borro correctamente");
                ActualizarData();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            string nombre = row["Nombre"].ToString();
            string apellido = row["Apellido"].ToString();
            int idJugador = Convert.ToInt32(row["Id_Jugador"]);
            try
            {
                var nuevo = new Jugador(nombre, apellido, idJugador);
                var respuesta = bLLJugador.Modificar(nuevo);
                if (!respuesta) throw new Exception("Ocurrio un error al modificar");
                MessageBox.Show("Se modifico correctamente");
                ActualizarData();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ActualizarData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bLLJugador.MostrarJugadores();
        }

        private void FormJugador_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bLLJugador.MostrarJugadores();
            ActualizarData();
        }
    }
}
