namespace LINQ
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.task1Button = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.task2Button = new System.Windows.Forms.Button();
			this.task3Button = new System.Windows.Forms.Button();
			this.task4Button = new System.Windows.Forms.Button();
			this.task5Button = new System.Windows.Forms.Button();
			this.task6Button = new System.Windows.Forms.Button();
			this.task7Button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(321, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(299, 559);
			this.listBox1.TabIndex = 0;
			// 
			// task1Button
			// 
			this.task1Button.Location = new System.Drawing.Point(40, 81);
			this.task1Button.Name = "task1Button";
			this.task1Button.Size = new System.Drawing.Size(98, 45);
			this.task1Button.TabIndex = 1;
			this.task1Button.Text = "TASK 1";
			this.task1Button.UseVisualStyleBackColor = true;
			this.task1Button.Click += new System.EventHandler(this.task1Button_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(74, 12);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(167, 45);
			this.resetButton.TabIndex = 2;
			this.resetButton.Text = "RESET";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// task2Button
			// 
			this.task2Button.Location = new System.Drawing.Point(40, 151);
			this.task2Button.Name = "task2Button";
			this.task2Button.Size = new System.Drawing.Size(98, 45);
			this.task2Button.TabIndex = 3;
			this.task2Button.Text = "TASK 2";
			this.task2Button.UseVisualStyleBackColor = true;
			this.task2Button.Click += new System.EventHandler(this.task2Button_Click);
			// 
			// task3Button
			// 
			this.task3Button.Location = new System.Drawing.Point(40, 222);
			this.task3Button.Name = "task3Button";
			this.task3Button.Size = new System.Drawing.Size(98, 45);
			this.task3Button.TabIndex = 4;
			this.task3Button.Text = "TASK 3";
			this.task3Button.UseVisualStyleBackColor = true;
			this.task3Button.Click += new System.EventHandler(this.task3Button_Click);
			// 
			// task4Button
			// 
			this.task4Button.Location = new System.Drawing.Point(40, 297);
			this.task4Button.Name = "task4Button";
			this.task4Button.Size = new System.Drawing.Size(98, 45);
			this.task4Button.TabIndex = 5;
			this.task4Button.Text = "TASK 4";
			this.task4Button.UseVisualStyleBackColor = true;
			this.task4Button.Click += new System.EventHandler(this.task4Button_Click);
			// 
			// task5Button
			// 
			this.task5Button.Location = new System.Drawing.Point(185, 81);
			this.task5Button.Name = "task5Button";
			this.task5Button.Size = new System.Drawing.Size(98, 45);
			this.task5Button.TabIndex = 6;
			this.task5Button.Text = "TASK 5";
			this.task5Button.UseVisualStyleBackColor = true;
			this.task5Button.Click += new System.EventHandler(this.task5Button_Click);
			// 
			// task6Button
			// 
			this.task6Button.Location = new System.Drawing.Point(185, 151);
			this.task6Button.Name = "task6Button";
			this.task6Button.Size = new System.Drawing.Size(98, 45);
			this.task6Button.TabIndex = 7;
			this.task6Button.Text = "TASK 6";
			this.task6Button.UseVisualStyleBackColor = true;
			this.task6Button.Click += new System.EventHandler(this.task6Button_Click);
			// 
			// task7Button
			// 
			this.task7Button.Location = new System.Drawing.Point(185, 222);
			this.task7Button.Name = "task7Button";
			this.task7Button.Size = new System.Drawing.Size(98, 45);
			this.task7Button.TabIndex = 8;
			this.task7Button.Text = "TASK 7";
			this.task7Button.UseVisualStyleBackColor = true;
			this.task7Button.Click += new System.EventHandler(this.task7Button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(633, 588);
			this.Controls.Add(this.task7Button);
			this.Controls.Add(this.task6Button);
			this.Controls.Add(this.task5Button);
			this.Controls.Add(this.task4Button);
			this.Controls.Add(this.task3Button);
			this.Controls.Add(this.task2Button);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.task1Button);
			this.Controls.Add(this.listBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button task1Button;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Button task2Button;
		private System.Windows.Forms.Button task3Button;
		private System.Windows.Forms.Button task4Button;
		private System.Windows.Forms.Button task5Button;
		private System.Windows.Forms.Button task6Button;
		private System.Windows.Forms.Button task7Button;
	}
}
