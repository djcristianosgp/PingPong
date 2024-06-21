using BibliotecaUteis.ViewModel.Chat;

namespace BibliotecaUteis.Classes.Recepcao
{
	public class RecepcaoMensagens
	{
		private ChatViewModel _chatViewModel;
		public RecepcaoMensagens(ChatViewModel chatViewModel)
		{
			_chatViewModel = chatViewModel;
		}

		public async Task RedirectMensagem(ChatViewModel mensagem)
		{

		}
	}
}
