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
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            try
            {
                var nuevo = new Jugador(nombre, apellido);
                var respuesta = bLLJugador.Bajar(nuevo);
                if (!respuesta) throw new Exception("Ocurrio un error al agregar");
                MessageBox.Show("Se agrego correctamente");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
