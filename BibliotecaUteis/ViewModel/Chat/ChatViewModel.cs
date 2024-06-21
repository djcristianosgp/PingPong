namespace BibliotecaUteis.ViewModel.Chat
{
	public class ChatViewModel
	{
		public Origem origem { get; set; }
		public Mensagem mensagem { get; set; }

		public class Origem
		{
			public string colaborador { get; set; }
			public string imagem { get; set; }
			public int porta { get; set; }
		}
		public class Destino
		{
			public string colaborador { get; set; }
			public string imagem { get; set; }
			public int porta { get; set; }
		}
		public class Mensagem
		{
			public Destino destino { get; set; }
			public string mensagem { get; set; }
			public string anexo { get; set; }
		}
	}
}
