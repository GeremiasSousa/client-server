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
            this.Dispose(); // Fecha a aplicação
        }


        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (ip.Text.Length > 2 && port.Text.Length > 2 && menssage.Text.Length > 0)
            {
                if (conectionToServer(ip.Text, int.Parse(port.Text), menssage.Text)) // Verificar se a conexão foi um sucesso e envia a mensagem
                {
                    MessageBox.Show("Mensagem enviada com sucesso!", "UFAH!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    status.Text = "Status -> Mensagem enviada";
                    menssage.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool conectionToServer(string ip, int port, string message)
        {
            try
            {
                Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // Configura o Socket
                clientSocket.Connect(ip, port); // Conecta no Socket


                string messageToSend = message; 
                byte[] messageBytes = Encoding.UTF8.GetBytes(messageToSend); // Envia a mensagem para o servidor que é mostrado no cmd
                clientSocket.Send(messageBytes); // Envia a mensagem


                clientSocket.Close(); // Fecha a conexão com o host
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("O erro foi -> " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
