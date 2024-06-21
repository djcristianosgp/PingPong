using BibliotecaUteis.ViewModel.Configuracoes;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BibliotecaUteis.Classes.Uteis
{
	public class DadosUteis
	{
		public DadosUteis()
		{
			Task.Run(async () =>
			{
				await CriaPastas();
				await CarregaConfigClient();
			}).Wait();
		}

		// pastas
		public static string PastaPadrao = @"C:\Area27\Chat\";

		// arquivos
		public static string ArquivoConfigClient = Path.Combine(PastaPadrao, "ConfigClient.dll");

		public static ConfigClientViewModel configClientViewModel { get; set; }

		public static List<string> ListaPastas = new List<string> {
			PastaPadrao
		};

		public static async Task CriaPastas()
		{
			foreach (var item in ListaPastas)
			{
				if (!Directory.Exists(item))
				{
					Directory.CreateDirectory(item);
				}
			}
		}

		public static async Task CarregaConfigClient()
		{
			if (File.Exists(ArquivoConfigClient))
			{
				var arquivoLido = await File.ReadAllTextAsync(ArquivoConfigClient);
				configClientViewModel = JsonSerializer.Deserialize<ConfigClientViewModel>(arquivoLido);
			}
			else
			{
				configClientViewModel = new ConfigClientViewModel();
			}
		}

		public static async Task SalvaConfigClient()
		{
			var dadosArquivo = JsonSerializer.Serialize(configClientViewModel);
			File.WriteAllTextAsync(ArquivoConfigClient, dadosArquivo);
		}
	}
}
