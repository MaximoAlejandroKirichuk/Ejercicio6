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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void juegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJuego formjuego = new FormJuego();
            formjuego.ShowDialog();
        }

        private void jugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJugador formjugador = new FormJugador();
            formjugador.ShowDialog();
        }

        private void bandoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBando formBando = new FormBando();
            formBando.ShowDialog();
        }

        private void bandoJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBandoJuego formBandoJuego = new FormBandoJuego();
            formBandoJuego.ShowDialog();
        }
    }
}
