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
    public partial class FormBando : Form
    {
        public FormBando()
        {
            InitializeComponent();
        }
        BLLBando1 bLLBando = new BLLBando1();
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public void ActualizarData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bLLBando.ObtenerBandos();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            try
            {
                var bando = new Bando(nombre);
                var respuesta = bLLBando.Agregar(bando);
                if (!respuesta) throw new Exception("Ocurrio un error");
                MessageBox.Show("Se agrego");
                ActualizarData();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FormBando_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bLLBando.ObtenerBandos();
            ActualizarData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
                int idBando = Convert.ToInt32(row["Id_Bando"]);
                string nombre = row["Nombre"].ToString();
                
                try
                {
                    var nuevo = new Bando(nombre,idBando);
                    var respuesta = bLLBando.Bajar(idBando);
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

        private void button4_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            int idBando = Convert.ToInt32(row["Id_Bando"]);
            string nombre = row["Nombre"].ToString();

            try
            {
                var nuevo = new Bando(nombre, idBando);
                var respuesta = bLLBando.Modificar(nuevo);
                if (!respuesta) throw new Exception("Ocurrio un error al modificar");
                MessageBox.Show("Se modifico correctamente");
                ActualizarData();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
