namespace TaskManager
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
			dataGridView1 = new DataGridView();
			refreshListButton = new Button();
			comboBox1 = new ComboBox();
			label1 = new Label();
			openProcessButton = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(-1, 67);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(1053, 626);
			dataGridView1.TabIndex = 0;
			// 
			// refreshListButton
			// 
			refreshListButton.Location = new Point(12, 12);
			refreshListButton.Name = "refreshListButton";
			refreshListButton.Size = new Size(105, 38);
			refreshListButton.TabIndex = 1;
			refreshListButton.Text = "Refresh";
			refreshListButton.UseVisualStyleBackColor = true;
			refreshListButton.Click += refreshListButton_Click;
			// 
			// comboBox1
			// 
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "1", "2", "5" });
			comboBox1.Location = new Point(340, 14);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(121, 33);
			comboBox1.TabIndex = 2;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(255, 16);
			label1.Name = "label1";
			label1.Size = new Size(79, 25);
			label1.TabIndex = 3;
			label1.Text = "Interval:";
			// 
			// openProcessButton
			// 
			openProcessButton.Location = new Point(134, 13);
			openProcessButton.Name = "openProcessButton";
			openProcessButton.Size = new Size(105, 38);
			openProcessButton.TabIndex = 4;
			openProcessButton.Text = "Open";
			openProcessButton.UseVisualStyleBackColor = true;
			openProcessButton.Click += openProcessButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1049, 690);
			Controls.Add(openProcessButton);
			Controls.Add(label1);
			Controls.Add(comboBox1);
			Controls.Add(refreshListButton);
			Controls.Add(dataGridView1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Button refreshListButton;
		private ComboBox comboBox1;
		private Label label1;
		private Button openProcessButton;
	}
}