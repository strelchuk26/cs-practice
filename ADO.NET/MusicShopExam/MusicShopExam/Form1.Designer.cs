namespace MusicShopExam
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
			loginButton = new Button();
			registerButton = new Button();
			SuspendLayout();
			// 
			// loginButton
			// 
			loginButton.BackColor = Color.FromArgb(46, 213, 115);
			loginButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			loginButton.ForeColor = Color.White;
			loginButton.Location = new Point(81, 216);
			loginButton.Name = "loginButton";
			loginButton.Size = new Size(317, 64);
			loginButton.TabIndex = 0;
			loginButton.Text = "LOGIN";
			loginButton.UseVisualStyleBackColor = false;
			loginButton.Click += loginButton_Click;
			// 
			// registerButton
			// 
			registerButton.BackColor = Color.FromArgb(46, 213, 115);
			registerButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			registerButton.ForeColor = Color.White;
			registerButton.Location = new Point(81, 303);
			registerButton.Name = "registerButton";
			registerButton.Size = new Size(317, 64);
			registerButton.TabIndex = 1;
			registerButton.Text = "REGISTER";
			registerButton.UseVisualStyleBackColor = false;
			registerButton.Click += registerButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(38, 38, 38);
			ClientSize = new Size(477, 591);
			Controls.Add(registerButton);
			Controls.Add(loginButton);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Shop";
			ResumeLayout(false);
		}

		#endregion

		private Button loginButton;
		private Button registerButton;
	}
}