namespace MusicShopExam
{
	partial class RegisterForm
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
			registerButton = new Button();
			passwordTextBox = new MaskedTextBox();
			label3 = new Label();
			label2 = new Label();
			loginTextBox = new TextBox();
			checkBox1 = new CheckBox();
			cancelButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(131, 43);
			label1.Name = "label1";
			label1.Size = new Size(203, 54);
			label1.TabIndex = 1;
			label1.Text = "REGISTER";
			// 
			// registerButton
			// 
			registerButton.BackColor = Color.FromArgb(46, 213, 115);
			registerButton.Enabled = false;
			registerButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			registerButton.ForeColor = Color.White;
			registerButton.Location = new Point(127, 387);
			registerButton.Name = "registerButton";
			registerButton.Size = new Size(227, 73);
			registerButton.TabIndex = 10;
			registerButton.Text = "REGISTER";
			registerButton.UseVisualStyleBackColor = false;
			registerButton.Click += registerButton_Click;
			// 
			// passwordTextBox
			// 
			passwordTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			passwordTextBox.Location = new Point(43, 278);
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.Size = new Size(391, 34);
			passwordTextBox.TabIndex = 9;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.White;
			label3.Location = new Point(42, 248);
			label3.Name = "label3";
			label3.Size = new Size(82, 21);
			label3.TabIndex = 8;
			label3.Text = "Password";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.White;
			label2.Location = new Point(43, 130);
			label2.Name = "label2";
			label2.Size = new Size(53, 21);
			label2.TabIndex = 7;
			label2.Text = "Login";
			// 
			// loginTextBox
			// 
			loginTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			loginTextBox.Location = new Point(43, 158);
			loginTextBox.Name = "loginTextBox";
			loginTextBox.Size = new Size(391, 34);
			loginTextBox.TabIndex = 6;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			checkBox1.ForeColor = Color.White;
			checkBox1.Location = new Point(42, 335);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(124, 19);
			checkBox1.TabIndex = 11;
			checkBox1.Text = "I accept all terms.";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// cancelButton
			// 
			cancelButton.BackColor = Color.FromArgb(46, 213, 115);
			cancelButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			cancelButton.ForeColor = Color.White;
			cancelButton.Location = new Point(127, 482);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(227, 73);
			cancelButton.TabIndex = 13;
			cancelButton.Text = "CANCEL";
			cancelButton.UseVisualStyleBackColor = false;
			cancelButton.Click += cancelButton_Click;
			// 
			// RegisterForm
			// 
			AcceptButton = registerButton;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(38, 38, 38);
			CancelButton = cancelButton;
			ClientSize = new Size(477, 591);
			Controls.Add(cancelButton);
			Controls.Add(checkBox1);
			Controls.Add(registerButton);
			Controls.Add(passwordTextBox);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(loginTextBox);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "RegisterForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "RegisterForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button registerButton;
		private MaskedTextBox passwordTextBox;
		private Label label3;
		private Label label2;
		private TextBox loginTextBox;
		private CheckBox checkBox1;
		private Button cancelButton;
	}
}