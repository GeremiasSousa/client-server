using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

namespace ClientServer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        public bool conectionToServer(string ip, int port)
        {
            try
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(IPAddress.Parse(ip), port);

            }
            catch (Exception ex)
            {
                MessageBox.Show("O erro foi -> " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            conectionToServer("127.0.0.1", 8089);
        }
    }
}