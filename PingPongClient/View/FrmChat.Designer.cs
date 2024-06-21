namespace PingPongClient.View
{
	partial class FrmChat
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
			groupBox1 = new GroupBox();
			ltContatos = new ListView();
			groupBox2 = new GroupBox();
			panel1 = new Panel();
			panel2 = new Panel();
			txtMensagem = new RichTextBox();
			btnSend = new Button();
			txtChat = new RichTextBox();
			panel3 = new Panel();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(ltContatos);
			groupBox1.Dock = DockStyle.Left;
			groupBox1.Location = new Point(0, 29);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(179, 421);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Contatos";
			// 
			// ltContatos
			// 
			ltContatos.Dock = DockStyle.Fill;
			ltContatos.Location = new Point(3, 19);
			ltContatos.Name = "ltContatos";
			ltContatos.Size = new Size(173, 399);
			ltContatos.TabIndex = 0;
			ltContatos.UseCompatibleStateImageBehavior = false;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(txtChat);
			groupBox2.Controls.Add(panel1);
			groupBox2.Dock = DockStyle.Fill;
			groupBox2.Location = new Point(179, 29);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(621, 421);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Chat";
			// 
			// panel1
			// 
			panel1.Controls.Add(txtMensagem);
			panel1.Controls.Add(panel2);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(3, 380);
			panel1.Name = "panel1";
			panel1.Size = new Size(615, 38);
			panel1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.Controls.Add(btnSend);
			panel2.Dock = DockStyle.Right;
			panel2.Location = new Point(508, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(107, 38);
			panel2.TabIndex = 0;
			// 
			// txtMensagem
			// 
			txtMensagem.Dock = DockStyle.Fill;
			txtMensagem.Location = new Point(0, 0);
			txtMensagem.Name = "txtMensagem";
			txtMensagem.Size = new Size(508, 38);
			txtMensagem.TabIndex = 1;
			txtMensagem.Text = "";
			// 
			// btnSend
			// 
			btnSend.BackColor = Color.FromArgb(114, 114, 114);
			btnSend.Dock = DockStyle.Right;
			btnSend.FlatAppearance.BorderSize = 0;
			btnSend.FlatStyle = FlatStyle.Flat;
			btnSend.Location = new Point(55, 0);
			btnSend.Name = "btnSend";
			btnSend.Size = new Size(52, 38);
			btnSend.TabIndex = 0;
			btnSend.Text = "Enviar";
			btnSend.UseVisualStyleBackColor = false;
			// 
			// txtChat
			// 
			txtChat.Dock = DockStyle.Fill;
			txtChat.Location = new Point(3, 19);
			txtChat.Name = "txtChat";
			txtChat.Size = new Size(615, 361);
			txtChat.TabIndex = 2;
			txtChat.Text = "";
			// 
			// panel3
			// 
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(800, 29);
			panel3.TabIndex = 2;
			// 
			// FrmChat
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(64, 64, 64);
			ClientSize = new Size(800, 450);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(panel3);
			ForeColor = Color.White;
			Name = "FrmChat";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FrmChat";
			Load += FrmChat_Load;
			groupBox1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private ListView ltContatos;
		private GroupBox groupBox2;
		private Panel panel1;
		private RichTextBox txtMensagem;
		private Panel panel2;
		private Button btnSend;
		private RichTextBox txtChat;
		private Panel panel3;
	}
}