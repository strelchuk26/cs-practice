namespace MusicShopExam
{
	partial class AddPlateForm
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
			nameTextBox = new TextBox();
			label2 = new Label();
			label3 = new Label();
			yearNum = new NumericUpDown();
			priceNum = new NumericUpDown();
			label4 = new Label();
			treacksCountNum = new NumericUpDown();
			label5 = new Label();
			genreComboBox = new ComboBox();
			label6 = new Label();
			label7 = new Label();
			publisherTextBox = new TextBox();
			addPlateButton = new Button();
			cancelButton = new Button();
			((System.ComponentModel.ISupportInitialize)yearNum).BeginInit();
			((System.ComponentModel.ISupportInitialize)priceNum).BeginInit();
			((System.ComponentModel.ISupportInitialize)treacksCountNum).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(127, 18);
			label1.Name = "label1";
			label1.Size = new Size(222, 54);
			label1.TabIndex = 0;
			label1.Text = "ADD PLATE";
			// 
			// nameTextBox
			// 
			nameTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			nameTextBox.Location = new Point(40, 109);
			nameTextBox.Name = "nameTextBox";
			nameTextBox.Size = new Size(387, 34);
			nameTextBox.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(40, 85);
			label2.Name = "label2";
			label2.Size = new Size(52, 21);
			label2.TabIndex = 2;
			label2.Text = "Name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(36, 155);
			label3.Name = "label3";
			label3.Size = new Size(40, 21);
			label3.TabIndex = 4;
			label3.Text = "Year";
			// 
			// yearNum
			// 
			yearNum.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			yearNum.Location = new Point(40, 179);
			yearNum.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
			yearNum.Minimum = new decimal(new int[] { 1500, 0, 0, 0 });
			yearNum.Name = "yearNum";
			yearNum.Size = new Size(387, 34);
			yearNum.TabIndex = 5;
			yearNum.Value = new decimal(new int[] { 2023, 0, 0, 0 });
			// 
			// priceNum
			// 
			priceNum.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			priceNum.Location = new Point(40, 255);
			priceNum.Maximum = new decimal(new int[] { 1999999999, 0, 0, 0 });
			priceNum.Name = "priceNum";
			priceNum.Size = new Size(387, 34);
			priceNum.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(36, 231);
			label4.Name = "label4";
			label4.Size = new Size(44, 21);
			label4.TabIndex = 6;
			label4.Text = "Price";
			// 
			// treacksCountNum
			// 
			treacksCountNum.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			treacksCountNum.Location = new Point(40, 329);
			treacksCountNum.Maximum = new decimal(new int[] { 1999999999, 0, 0, 0 });
			treacksCountNum.Name = "treacksCountNum";
			treacksCountNum.Size = new Size(387, 34);
			treacksCountNum.TabIndex = 9;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(36, 305);
			label5.Name = "label5";
			label5.Size = new Size(96, 21);
			label5.TabIndex = 8;
			label5.Text = "Tracks count";
			// 
			// genreComboBox
			// 
			genreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			genreComboBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			genreComboBox.FormattingEnabled = true;
			genreComboBox.Location = new Point(40, 403);
			genreComboBox.Name = "genreComboBox";
			genreComboBox.Size = new Size(387, 36);
			genreComboBox.TabIndex = 10;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(40, 379);
			label6.Name = "label6";
			label6.Size = new Size(52, 21);
			label6.TabIndex = 11;
			label6.Text = "Genre";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(40, 456);
			label7.Name = "label7";
			label7.Size = new Size(75, 21);
			label7.TabIndex = 13;
			label7.Text = "Publisher";
			// 
			// publisherTextBox
			// 
			publisherTextBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			publisherTextBox.Location = new Point(40, 480);
			publisherTextBox.Name = "publisherTextBox";
			publisherTextBox.Size = new Size(387, 34);
			publisherTextBox.TabIndex = 12;
			// 
			// addPlateButton
			// 
			addPlateButton.DialogResult = DialogResult.OK;
			addPlateButton.Location = new Point(40, 534);
			addPlateButton.Name = "addPlateButton";
			addPlateButton.Size = new Size(178, 54);
			addPlateButton.TabIndex = 14;
			addPlateButton.Text = "ADD";
			addPlateButton.UseVisualStyleBackColor = true;
			addPlateButton.Click += addPlateButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.DialogResult = DialogResult.Cancel;
			cancelButton.Location = new Point(249, 534);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(178, 54);
			cancelButton.TabIndex = 15;
			cancelButton.Text = "CANCEL";
			cancelButton.UseVisualStyleBackColor = true;
			cancelButton.Click += cancelButton_Click;
			// 
			// AddPlateForm
			// 
			AcceptButton = addPlateButton;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = cancelButton;
			ClientSize = new Size(477, 611);
			Controls.Add(cancelButton);
			Controls.Add(addPlateButton);
			Controls.Add(label7);
			Controls.Add(publisherTextBox);
			Controls.Add(label6);
			Controls.Add(genreComboBox);
			Controls.Add(treacksCountNum);
			Controls.Add(label5);
			Controls.Add(priceNum);
			Controls.Add(label4);
			Controls.Add(yearNum);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(nameTextBox);
			Controls.Add(label1);
			Name = "AddPlateForm";
			Text = "AddPlateForm";
			((System.ComponentModel.ISupportInitialize)yearNum).EndInit();
			((System.ComponentModel.ISupportInitialize)priceNum).EndInit();
			((System.ComponentModel.ISupportInitialize)treacksCountNum).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox nameTextBox;
		private Label label2;
		private Label label3;
		private NumericUpDown yearNum;
		private NumericUpDown priceNum;
		private Label label4;
		private NumericUpDown treacksCountNum;
		private Label label5;
		private ComboBox genreComboBox;
		private Label label6;
		private Label label7;
		private TextBox publisherTextBox;
		private Button addPlateButton;
		private Button cancelButton;
	}
}