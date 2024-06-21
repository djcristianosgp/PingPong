using BibliotecaUteis.ViewModel;
using BibliotecaUteis.ViewModel.Chat;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace BibliotecaUteis.Classes.Envio
{
	public class EnvioMensagens
	{
		private UdpClient udpClient;
		public EnvioMensagens()
		{
			udpClient = new UdpClient();
		}

		public async Task<InfoEnvioViewModel> SendMensagem(ChatViewModel chatViewModel)
		{
			var retorno = new InfoEnvioViewModel();
			try
			{
				var mensagem = JsonSerializer.Serialize(chatViewModel.mensagem);
				// Enviar um broadcast na porta 12345
				byte[] data = Encoding.ASCII.GetBytes(mensagem);
				udpClient.EnableBroadcast = true;
				IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, chatViewModel.mensagem.destino.porta);
				udpClient.Send(data, data.Length, endPoint);

				// Configurar tempo de espera para receber resposta
				udpClient.Client.ReceiveTimeout = 1000;

				// Receber resposta
				IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
				byte[] receivedData = udpClient.Receive(ref remoteEndPoint);
				string receivedString = Encoding.ASCII.GetString(receivedData);

				// Atualizar Edit1 (TextBox) com o endereço IP do remetente
				retorno.remoteEndPoint = remoteEndPoint.Address.ToString();
				retorno.retorno = "Mensagem Enviada";
				retorno.statusMensagem = InfoEnvioViewModel.statusMenasgem.Success;
				return retorno;
			}
			catch (SocketException ex)
			{
				retorno.statusMensagem = InfoEnvioViewModel.statusMenasgem.Error;
				retorno.dados = "Erro ao receber dados: " + ex.Message;
				return retorno;
			}
		}
	}
}
