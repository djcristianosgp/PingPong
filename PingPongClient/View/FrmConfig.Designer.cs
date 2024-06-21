namespace PingPongClient.View
{
	partial class FrmConfig
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			btnSalvar = new Button();
			nmPortaRemota = new NumericUpDown();
			txtNickName = new TextBox();
			nmPortaLocal = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)nmPortaRemota).BeginInit();
			((System.ComponentModel.ISupportInitialize)nmPortaLocal).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Dock = DockStyle.Top;
			label1.Location = new Point(0, 46);
			label1.Name = "label1";
			label1.Size = new Size(240, 23);
			label1.TabIndex = 0;
			label1.Text = "Porta Remota:";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.Dock = DockStyle.Top;
			label2.Location = new Point(0, 0);
			label2.Name = "label2";
			label2.Size = new Size(240, 23);
			label2.TabIndex = 2;
			label2.Text = "Porta Local:";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.Dock = DockStyle.Top;
			label3.Location = new Point(0, 92);
			label3.Name = "label3";
			label3.Size = new Size(240, 23);
			label3.TabIndex = 4;
			label3.Text = "Nick Name:";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnSalvar
			// 
			btnSalvar.BackColor = Color.FromArgb(114, 114, 114);
			btnSalvar.Dock = DockStyle.Bottom;
			btnSalvar.FlatAppearance.BorderSize = 0;
			btnSalvar.FlatStyle = FlatStyle.Flat;
			btnSalvar.ForeColor = Color.White;
			btnSalvar.Location = new Point(0, 160);
			btnSalvar.Name = "btnSalvar";
			btnSalvar.Size = new Size(240, 38);
			btnSalvar.TabIndex = 6;
			btnSalvar.Text = "Salvar";
			btnSalvar.UseVisualStyleBackColor = false;
			btnSalvar.Click += btnSalvar_Click;
			// 
			// nmPortaRemota
			// 
			nmPortaRemota.Dock = DockStyle.Top;
			nmPortaRemota.Location = new Point(0, 69);
			nmPortaRemota.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
			nmPortaRemota.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
			nmPortaRemota.Name = "nmPortaRemota";
			nmPortaRemota.Size = new Size(240, 23);
			nmPortaRemota.TabIndex = 7;
			nmPortaRemota.TextAlign = HorizontalAlignment.Center;
			nmPortaRemota.Value = new decimal(new int[] { 1000, 0, 0, 0 });
			// 
			// txtNickName
			// 
			txtNickName.Dock = DockStyle.Top;
			txtNickName.Location = new Point(0, 115);
			txtNickName.Name = "txtNickName";
			txtNickName.Size = new Size(240, 23);
			txtNickName.TabIndex = 5;
			txtNickName.TextAlign = HorizontalAlignment.Center;
			// 
			// nmPortaLocal
			// 
			nmPortaLocal.Dock = DockStyle.Top;
			nmPortaLocal.Location = new Point(0, 23);
			nmPortaLocal.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
			nmPortaLocal.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
			nmPortaLocal.Name = "nmPortaLocal";
			nmPortaLocal.Size = new Size(240, 23);
			nmPortaLocal.TabIndex = 8;
			nmPortaLocal.TextAlign = HorizontalAlignment.Center;
			nmPortaLocal.Value = new decimal(new int[] { 1000, 0, 0, 0 });
			// 
			// FrmConfig
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(64, 64, 64);
			ClientSize = new Size(240, 198);
			Controls.Add(btnSalvar);
			Controls.Add(txtNickName);
			Controls.Add(label3);
			Controls.Add(nmPortaRemota);
			Controls.Add(label1);
			Controls.Add(nmPortaLocal);
			Controls.Add(label2);
			ForeColor = SystemColors.ControlLightLight;
			MaximizeBox = false;
			Name = "FrmConfig";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Config";
			Load += FrmConfig_Load;
			((System.ComponentModel.ISupportInitialize)nmPortaRemota).EndInit();
			((System.ComponentModel.ISupportInitialize)nmPortaLocal).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private MaskedTextBox txtPortaServidor;
		private MaskedTextBox txtPortaLocal;
		private Label label2;
		private Label label3;
		private Button btnSalvar;
		private NumericUpDown nmPortaRemota;
		private TextBox txtNickName;
		private NumericUpDown nmPortaLocal;
	}
}