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
    public partial class Form7 : Form
    {

        private OpenFileDialog openFileDialog;

        public Form7()
        {
            InitializeComponent();
            inicializarCargaAudio();

        }

        private void inicializarCargaAudio()
        {
            openFileDialog = new OpenFileDialog();
        }

        private void cargarAudioCancion_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }
    }
}
