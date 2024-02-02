namespace Threads
{
	partial class Form2
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
			listBox1 = new ListBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			maxLabel = new Label();
			minLabel = new Label();
			avgLabel = new Label();
			startButton = new Button();
			SuspendLayout();
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(239, 12);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(334, 409);
			listBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(26, 52);
			label1.Name = "label1";
			label1.Size = new Size(53, 28);
			label1.TabIndex = 1;
			label1.Text = "Max:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(26, 89);
			label2.Name = "label2";
			label2.Size = new Size(50, 28);
			label2.TabIndex = 2;
			label2.Text = "Min:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(25, 128);
			label3.Name = "label3";
			label3.Size = new Size(51, 28);
			label3.TabIndex = 3;
			label3.Text = "Avg:";
			// 
			// maxLabel
			// 
			maxLabel.AutoSize = true;
			maxLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			maxLabel.Location = new Point(76, 52);
			maxLabel.Name = "maxLabel";
			maxLabel.Size = new Size(23, 28);
			maxLabel.TabIndex = 4;
			maxLabel.Text = "0";
			// 
			// minLabel
			// 
			minLabel.AutoSize = true;
			minLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			minLabel.Location = new Point(76, 89);
			minLabel.Name = "minLabel";
			minLabel.Size = new Size(23, 28);
			minLabel.TabIndex = 5;
			minLabel.Text = "0";
			// 
			// avgLabel
			// 
			avgLabel.AutoSize = true;
			avgLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			avgLabel.Location = new Point(76, 128);
			avgLabel.Name = "avgLabel";
			avgLabel.Size = new Size(23, 28);
			avgLabel.TabIndex = 6;
			avgLabel.Text = "0";
			// 
			// startButton
			// 
			startButton.Location = new Point(47, 215);
			startButton.Name = "startButton";
			startButton.Size = new Size(146, 64);
			startButton.TabIndex = 7;
			startButton.Text = "START";
			startButton.UseVisualStyleBackColor = true;
			startButton.Click += startButton_Click;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(596, 440);
			Controls.Add(startButton);
			Controls.Add(avgLabel);
			Controls.Add(minLabel);
			Controls.Add(maxLabel);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(listBox1);
			Name = "Form2";
			Text = "Form2";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox listBox1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label maxLabel;
		private Label minLabel;
		private Label avgLabel;
		private Button startButton;
	}
}