namespace MusicShopExam
{
	partial class LoginForm
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
			loginTextBox = new TextBox();
			label2 = new Label();
			label3 = new Label();
			passwordTextBox = new MaskedTextBox();
			loginButton = new Button();
			cancelButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(165, 51);
			label1.Name = "label1";
			label1.Size = new Size(145, 54);
			label1.TabIndex = 0;
			label1.Text = "LOGIN";
			// 
			// loginTextBox
			// 
			loginTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			loginTextBox.Location = new Point(39, 166);
			loginTextBox.Name = "loginTextBox";
			loginTextBox.Size = new Size(391, 34);
			loginTextBox.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.White;
			label2.Location = new Point(39, 138);
			label2.Name = "label2";
			label2.Size = new Size(53, 21);
			label2.TabIndex = 2;
			label2.Text = "Login";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.White;
			label3.Location = new Point(38, 256);
			label3.Name = "label3";
			label3.Size = new Size(82, 21);
			label3.TabIndex = 3;
			label3.Text = "Password";
			// 
			// passwordTextBox
			// 
			passwordTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			passwordTextBox.Location = new Point(39, 286);
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.PasswordChar = '*';
			passwordTextBox.Size = new Size(391, 34);
			passwordTextBox.TabIndex = 4;
			// 
			// loginButton
			// 
			loginButton.BackColor = Color.FromArgb(46, 213, 115);
			loginButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			loginButton.ForeColor = Color.White;
			loginButton.Location = new Point(124, 363);
			loginButton.Name = "loginButton";
			loginButton.Size = new Size(227, 73);
			loginButton.TabIndex = 11;
			loginButton.Text = "LOGIN";
			loginButton.UseVisualStyleBackColor = false;
			loginButton.Click += loginButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.BackColor = Color.FromArgb(46, 213, 115);
			cancelButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			cancelButton.ForeColor = Color.White;
			cancelButton.Location = new Point(124, 459);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(227, 73);
			cancelButton.TabIndex = 12;
			cancelButton.Text = "CANCEL";
			cancelButton.UseVisualStyleBackColor = false;
			cancelButton.Click += cancelButton_Click;
			// 
			// LoginForm
			// 
			AcceptButton = loginButton;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(38, 38, 38);
			CancelButton = cancelButton;
			ClientSize = new Size(477, 591);
			Controls.Add(cancelButton);
			Controls.Add(loginButton);
			Controls.Add(passwordTextBox);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(loginTextBox);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "LoginForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "LoginForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox loginTextBox;
		private Label label2;
		private Label label3;
		private MaskedTextBox passwordTextBox;
		private Button loginButton;
		private Button cancelButton;
	}
}