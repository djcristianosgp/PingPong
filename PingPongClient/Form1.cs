using System.Net;
using System.Net.Sockets;
using System.Text;

namespace PingPongClient
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			udpClient = new UdpClient();
		}
		private UdpClient udpClient;

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				// Enviar um broadcast na porta 12345
				byte[] data = Encoding.ASCII.GetBytes(richTextBox1.Text);
				udpClient.EnableBroadcast = true;
				IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 12345);
				udpClient.Send(data, data.Length, endPoint);

				// Configurar tempo de espera para receber resposta
				udpClient.Client.ReceiveTimeout = 1000;

				// Receber resposta
				IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
				byte[] receivedData = udpClient.Receive(ref remoteEndPoint);
				string receivedString = Encoding.ASCII.GetString(receivedData);

				// Atualizar Edit1 (TextBox) com o endereço IP do remetente
				edit1.Text = remoteEndPoint.Address.ToString();
			}
			catch (SocketException ex)
			{
				MessageBox.Show("Erro ao receber dados: " + ex.Message);
			}
		}
	}
}
