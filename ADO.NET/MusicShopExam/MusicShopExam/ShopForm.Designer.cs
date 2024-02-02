namespace MusicShopExam
{
	partial class ShopForm
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
			panel1 = new Panel();
			loginLabel = new Label();
			label2 = new Label();
			amountLabel = new Label();
			label1 = new Label();
			buyButton = new Button();
			itemsListBox = new ListBox();
			comboBox1 = new ComboBox();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(54, 54, 54);
			panel1.Controls.Add(loginLabel);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(amountLabel);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(buyButton);
			panel1.Location = new Point(0, 1);
			panel1.Name = "panel1";
			panel1.Size = new Size(280, 672);
			panel1.TabIndex = 0;
			// 
			// loginLabel
			// 
			loginLabel.AutoSize = true;
			loginLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			loginLabel.ForeColor = Color.White;
			loginLabel.Location = new Point(105, 25);
			loginLabel.Name = "loginLabel";
			loginLabel.Size = new Size(40, 21);
			loginLabel.TabIndex = 4;
			loginLabel.Text = "null";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.White;
			label2.Location = new Point(44, 25);
			label2.Name = "label2";
			label2.Size = new Size(57, 21);
			label2.TabIndex = 3;
			label2.Text = "Login:";
			// 
			// amountLabel
			// 
			amountLabel.AutoSize = true;
			amountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			amountLabel.ForeColor = Color.White;
			amountLabel.Location = new Point(174, 61);
			amountLabel.Name = "amountLabel";
			amountLabel.Size = new Size(19, 21);
			amountLabel.TabIndex = 2;
			amountLabel.Text = "0";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(44, 61);
			label1.Name = "label1";
			label1.Size = new Size(118, 21);
			label1.TabIndex = 1;
			label1.Text = "Total Amount:";
			// 
			// buyButton
			// 
			buyButton.BackColor = Color.FromArgb(46, 213, 115);
			buyButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			buyButton.ForeColor = Color.White;
			buyButton.Location = new Point(44, 100);
			buyButton.Name = "buyButton";
			buyButton.Size = new Size(187, 59);
			buyButton.TabIndex = 0;
			buyButton.Text = "BUY";
			buyButton.UseVisualStyleBackColor = false;
			buyButton.Click += buyButtonClick;
			// 
			// itemsListBox
			// 
			itemsListBox.BackColor = Color.FromArgb(54, 54, 54);
			itemsListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			itemsListBox.ForeColor = Color.White;
			itemsListBox.FormattingEnabled = true;
			itemsListBox.ItemHeight = 30;
			itemsListBox.Location = new Point(307, 101);
			itemsListBox.Name = "itemsListBox";
			itemsListBox.Size = new Size(763, 544);
			itemsListBox.TabIndex = 3;
			// 
			// comboBox1
			// 
			comboBox1.BackColor = Color.FromArgb(54, 54, 54);
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			comboBox1.ForeColor = Color.White;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Id", "Name", "Genre", "Publisher", "Tracks Count" });
			comboBox1.Location = new Point(307, 39);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(165, 29);
			comboBox1.TabIndex = 4;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// ShopForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(38, 38, 38);
			ClientSize = new Size(1095, 668);
			Controls.Add(comboBox1);
			Controls.Add(itemsListBox);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "ShopForm";
			Text = "ShopForm";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Button buyButton;
		private ListBox itemsListBox;
		private Label amountLabel;
		private Label label1;
		private ComboBox comboBox1;
		private Label loginLabel;
		private Label label2;
	}
}