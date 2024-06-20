using System.Net.Sockets;
using System.Net;
using System.Text;

namespace PingPong
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			StartUdpServer();
		}
		private UdpClient udpServer;
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void StartUdpServer()
		{
			udpServer = new UdpClient(12345); // Porta 12345 como exemplo
			udpServer.BeginReceive(new AsyncCallback(OnUdpDataReceived), null);
		}

		private void OnUdpDataReceived(IAsyncResult ar)
		{
			IPEndPoint clientEndpoint = new IPEndPoint(IPAddress.Any, 0);
			byte[] receivedData = udpServer.EndReceive(ar, ref clientEndpoint);

			// Responder com "PONG"
			byte[] responseData = Encoding.ASCII.GetBytes("PONG");
			udpServer.Send(responseData, responseData.Length, clientEndpoint);

			// Continuar recebendo dados
			udpServer.BeginReceive(new AsyncCallback(OnUdpDataReceived), null);

			// Atualizar o Memo1 (TextBox) na thread da UI
			string receivedMessage = Encoding.ASCII.GetString(receivedData);
			this.Invoke((MethodInvoker)delegate
			{
				memo1.AppendText($"{Environment.NewLine}Received: {receivedMessage} from {clientEndpoint.Address}:{clientEndpoint.Port}\n");
				memo1.AppendText($"{Environment.NewLine}___________________________________________________________________________________");
			});
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			udpServer.Close();
			base.OnFormClosing(e);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			udpServer.Close();
			base.OnFormClosing(e);
		}
	}


}
