using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace UI
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint connect = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3333);

            listen.Connect(connect);
            Console.WriteLine("Cliente conectado al servidor");


            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}