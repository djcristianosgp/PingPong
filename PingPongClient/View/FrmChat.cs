using BibliotecaUteis.Classes.Uteis;

namespace PingPongClient.View
{
	public partial class FrmChat : Form
	{
		public DadosUteis _dadosUteis;
		public FrmChat()
		{
			InitializeComponent();
		}

		private void FrmChat_Load(object sender, EventArgs e)
		{
			if (DadosUteis.configClientViewModel.portaRemota == 1000)
			{
				FrmConfig frmConfig = new FrmConfig();
				if (frmConfig.ShowDialog() != DialogResult.OK) 
				{
					MessageBox.Show("Você precisa completar as configurações para poder continuar!!\r\nO sistema será encerrado!!");
					Application.Exit();
				}
				else 				
				MessageBox.Show($"Configurações salvas com sucesso!!{Environment.NewLine}Dados:" +
					$"Nick: {DadosUteis.configClientViewModel.nickName}{Environment.NewLine}" +
					$"Porta Remota: {DadosUteis.configClientViewModel.portaRemota}{Environment.NewLine}" +
					$"Porta Local: {DadosUteis.configClientViewModel.portaLocal}");
			}
		}
	}
}
