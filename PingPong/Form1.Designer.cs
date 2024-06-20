namespace PingPong
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			memo1 = new RichTextBox();
			SuspendLayout();
			// 
			// memo1
			// 
			memo1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			memo1.Location = new Point(12, 12);
			memo1.Name = "memo1";
			memo1.Size = new Size(405, 426);
			memo1.TabIndex = 0;
			memo1.Text = "";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(429, 450);
			Controls.Add(memo1);
			Name = "Form1";
			Text = "Form1";
			FormClosing += Form1_FormClosing;
			Load += Form1_Load;
			ResumeLayout(false);
		}

		#endregion

		private RichTextBox memo1;
	}
}
