using BibliotecaUteis.Classes.Uteis;
using PingPongClient.View;

namespace PingPongClient
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
			 new DadosUteis();
			ApplicationConfiguration.Initialize();
			Application.Run(new FrmChat());
		}
	}
}