namespace PingPongClient
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			edit1 = new TextBox();
			button1 = new Button();
			richTextBox1 = new RichTextBox();
			SuspendLayout();
			// 
			// edit1
			// 
			edit1.Location = new Point(78, 84);
			edit1.Name = "edit1";
			edit1.Size = new Size(200, 23);
			edit1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(140, 415);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(12, 123);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(374, 286);
			richTextBox1.TabIndex = 2;
			richTextBox1.Text = resources.GetString("richTextBox1.Text");
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(398, 450);
			Controls.Add(richTextBox1);
			Controls.Add(button1);
			Controls.Add(edit1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox edit1;
		private Button button1;
		private RichTextBox richTextBox1;
	}
}
