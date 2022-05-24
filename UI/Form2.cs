using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            cargarListaCanciones();
        }

        private void cargarListaCanciones()
        {
            listaCanciones.BeginUpdate();

            for (int x = 1; x <= 50; x++)
            {
                listaCanciones.Items.Add("Item " + x.ToString());
            }
            listaCanciones.EndUpdate();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buscarPorNombre_Click(object sender, EventArgs e)
        {

        }

        private void buscarPorArtista_Click(object sender, EventArgs e)
        {

        }

        private void buscarPorLetra_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void modificarCancion_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void calificarCancion_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void agregarCancion_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void amigos_Click(object sender, EventArgs e)
        {
            Form f8 = new Form8();
            f8.ShowDialog();
        }
    }
}
