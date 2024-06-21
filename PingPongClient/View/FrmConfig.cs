using BibliotecaUteis.Classes.Uteis;

namespace PingPongClient.View
{
	public partial class FrmConfig : Form
	{
		public FrmConfig()
		{
			InitializeComponent();
		}

		private void FrmConfig_Load(object sender, EventArgs e)
		{
			txtNickName.Text = DadosUteis.configClientViewModel.nickName;
			nmPortaLocal.Value = DadosUteis.configClientViewModel.portaLocal;
			nmPortaRemota.Value = DadosUteis.configClientViewModel.portaRemota;
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			if (Valida().Result)
			{
				DadosUteis.configClientViewModel.portaLocal = Convert.ToInt32(nmPortaLocal.Value);
				DadosUteis.configClientViewModel.portaRemota = Convert.ToInt32(nmPortaRemota.Value);
				DadosUteis.configClientViewModel.nickName = txtNickName.Text;
				DadosUteis.SalvaConfigClient();
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		public async Task<bool> Valida()
		{
			if (txtNickName.Text.Length < 5 || string.IsNullOrEmpty(txtNickName.Text) || string.IsNullOrWhiteSpace(txtNickName.Text))
				return false;

			return true;
		}

		private void txtPortaLocal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
		}
	}
}
