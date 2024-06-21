using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaUteis.ViewModel.InfoEnvioViewModel;

namespace BibliotecaUteis.ViewModel
{
	public class InfoEnvioViewModel
	{
		public string dados {  get; set; }
		public string remoteEndPoint {  get; set; }
		public string retorno {  get; set; }
		public statusMenasgem statusMensagem { get; set; }
		public enum statusMenasgem
		{
			Success = 0,
			Error = 99,
		}
	}
}
