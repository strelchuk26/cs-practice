namespace Threads
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
			startButton = new Button();
			startNum = new NumericUpDown();
			endNum = new NumericUpDown();
			threadsCount = new NumericUpDown();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			listBox1 = new ListBox();
			((System.ComponentModel.ISupportInitialize)startNum).BeginInit();
			((System.ComponentModel.ISupportInitialize)endNum).BeginInit();
			((System.ComponentModel.ISupportInitialize)threadsCount).BeginInit();
			SuspendLayout();
			// 
			// startButton
			// 
			startButton.Location = new Point(29, 85);
			startButton.Name = "startButton";
			startButton.Size = new Size(219, 56);
			startButton.TabIndex = 0;
			startButton.Text = "START";
			startButton.UseVisualStyleBackColor = true;
			startButton.Click += StartButtonClick;
			// 
			// startNum
			// 
			startNum.Location = new Point(29, 42);
			startNum.Maximum = new decimal(new int[] { -1593835520, 466537709, 54210, 0 });
			startNum.Name = "startNum";
			startNum.Size = new Size(57, 23);
			startNum.TabIndex = 1;
			// 
			// endNum
			// 
			endNum.Location = new Point(110, 42);
			endNum.Maximum = new decimal(new int[] { -159383552, 46653770, 5421, 0 });
			endNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			endNum.Name = "endNum";
			endNum.Size = new Size(57, 23);
			endNum.TabIndex = 2;
			endNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// threadsCount
			// 
			threadsCount.Location = new Point(191, 42);
			threadsCount.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
			threadsCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			threadsCount.Name = "threadsCount";
			threadsCount.Size = new Size(57, 23);
			threadsCount.TabIndex = 3;
			threadsCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(29, 24);
			label1.Name = "label1";
			label1.Size = new Size(31, 15);
			label1.TabIndex = 4;
			label1.Text = "Start";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(110, 24);
			label2.Name = "label2";
			label2.Size = new Size(27, 15);
			label2.TabIndex = 5;
			label2.Text = "End";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(191, 24);
			label3.Name = "label3";
			label3.Size = new Size(40, 15);
			label3.TabIndex = 6;
			label3.Text = "Count";
			// 
			// listBox1
			// 
			listBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 30;
			listBox1.Location = new Point(270, 24);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(242, 394);
			listBox1.TabIndex = 7;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(524, 450);
			Controls.Add(listBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(threadsCount);
			Controls.Add(endNum);
			Controls.Add(startNum);
			Controls.Add(startButton);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)startNum).EndInit();
			((System.ComponentModel.ISupportInitialize)endNum).EndInit();
			((System.ComponentModel.ISupportInitialize)threadsCount).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button startButton;
		private NumericUpDown startNum;
		private NumericUpDown endNum;
		private NumericUpDown threadsCount;
		private Label label1;
		private Label label2;
		private Label label3;
		private ListBox listBox1;
	}
}