using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text;

namespace UI
{
    public partial class Form1 : Form
    {

        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void iniciarSesion_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

            clientSocket.Connect("192.168.1.213", 5566);

            NetworkStream serverStream = clientSocket.GetStream();
            serverStream.Write(System.Text.Encoding.ASCII.GetBytes("Hola, esta es una prueba"), 0, System.Text.Encoding.ASCII.GetBytes("Hola, esta es una prueba").Length);
            //serverStream.Flush();

            //this.Close();
        }
    }
}