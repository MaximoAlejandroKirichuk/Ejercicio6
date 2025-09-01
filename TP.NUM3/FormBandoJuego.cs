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
    public partial class FormBandoJuego : Form
    {
        public FormBandoJuego()
        {
            InitializeComponent();
        }
        BLLJuegoBando BLLJuegoBando = new BLLJuegoBando();
        BLLBando1 BLLBADNO = new BLLBando1();
        BLLJuego BLLJUEGO = new BLLJuego();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
                int IdJuego = Convert.ToInt32(row["Id_Juego"]);
                int IdBando = Convert.ToInt32(row["Id_Bando"]);
                var JuegoBando = new JuegoBando(IdJuego, IdBando);
                var respuesta = BLLJuegoBando.agregraJuegoBando(JuegoBando);
                if (!respuesta) throw new Exception("Ocurrio un error");
                MessageBox.Show("Se agrego correctamente");
                ActualizarData();
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public void ActualizarData()
        {
            dataGridView3.DataSource = BLLJuegoBando.ObtenterTodos();
            dataGridView3.DataSource = BLLJuegoBando.ObtenterTodos();
        }

        private void FormBandoJuego_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLBADNO.ObtenerBandos();
            dataGridView2.DataSource = BLLJUEGO.ObtenerTodos();
            dataGridView3.DataSource = BLLJuegoBando.ObtenterTodos();
            ActualizarData();
        }
    }
}
