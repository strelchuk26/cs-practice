namespace TaskManager
{
	partial class OpenProcessForm
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
			textBox1 = new TextBox();
			label2 = new Label();
			okButton = new Button();
			cancelButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(102, 41);
			label1.Name = "label1";
			label1.Size = new Size(226, 46);
			label1.TabIndex = 0;
			label1.Text = "Open process";
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.Location = new Point(26, 153);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(369, 34);
			textBox1.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(26, 126);
			label2.Name = "label2";
			label2.Size = new Size(200, 21);
			label2.TabIndex = 2;
			label2.Text = "Enter process name or path";
			// 
			// okButton
			// 
			okButton.Location = new Point(26, 249);
			okButton.Name = "okButton";
			okButton.Size = new Size(154, 53);
			okButton.TabIndex = 3;
			okButton.Text = "OK";
			okButton.UseVisualStyleBackColor = true;
			okButton.Click += okButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Location = new Point(241, 249);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(154, 53);
			cancelButton.TabIndex = 4;
			cancelButton.Text = "CANCEL";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// OpenProcessForm
			// 
			AcceptButton = okButton;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = cancelButton;
			ClientSize = new Size(422, 379);
			Controls.Add(cancelButton);
			Controls.Add(okButton);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "OpenProcessForm";
			Text = "OpenProcessForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private Button okButton;
		private Button cancelButton;
	}
}