﻿namespace car_list
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.carsListBox = new System.Windows.Forms.ListBox();
			this.addCarButton = new System.Windows.Forms.Button();
			this.deleteCarButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.brandComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.modelComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.colorComboBox = new System.Windows.Forms.ComboBox();
			this.yearNumeric = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.numberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.vinNumTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.showCarInfoButton = new System.Windows.Forms.Button();
			this.selectCarComboBox = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).BeginInit();
			this.SuspendLayout();
			// 
			// carsListBox
			// 
			this.carsListBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.carsListBox.FormattingEnabled = true;
			this.carsListBox.ItemHeight = 14;
			this.carsListBox.Location = new System.Drawing.Point(315, 26);
			this.carsListBox.Name = "carsListBox";
			this.carsListBox.Size = new System.Drawing.Size(285, 242);
			this.carsListBox.TabIndex = 0;
			this.carsListBox.SelectedIndexChanged += new System.EventHandler(this.carsListBox_SelectedIndexChanged);
			// 
			// addCarButton
			// 
			this.addCarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(42)))), ((int)(((byte)(243)))));
			this.addCarButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addCarButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.addCarButton.ForeColor = System.Drawing.Color.White;
			this.addCarButton.Location = new System.Drawing.Point(61, 345);
			this.addCarButton.Name = "addCarButton";
			this.addCarButton.Size = new System.Drawing.Size(177, 48);
			this.addCarButton.TabIndex = 1;
			this.addCarButton.Text = "ADD";
			this.addCarButton.UseVisualStyleBackColor = false;
			this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
			// 
			// deleteCarButton
			// 
			this.deleteCarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(42)))), ((int)(((byte)(243)))));
			this.deleteCarButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.deleteCarButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.deleteCarButton.ForeColor = System.Drawing.Color.White;
			this.deleteCarButton.Location = new System.Drawing.Point(472, 345);
			this.deleteCarButton.Name = "deleteCarButton";
			this.deleteCarButton.Size = new System.Drawing.Size(128, 48);
			this.deleteCarButton.TabIndex = 2;
			this.deleteCarButton.Text = "DELETE";
			this.deleteCarButton.UseVisualStyleBackColor = false;
			this.deleteCarButton.Click += new System.EventHandler(this.deleteCarButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(97, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "CAR INFO";
			// 
			// brandComboBox
			// 
			this.brandComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.brandComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.brandComboBox.FormattingEnabled = true;
			this.brandComboBox.Location = new System.Drawing.Point(87, 84);
			this.brandComboBox.Name = "brandComboBox";
			this.brandComboBox.Size = new System.Drawing.Size(178, 22);
			this.brandComboBox.TabIndex = 4;
			this.brandComboBox.SelectedIndexChanged += new System.EventHandler(this.brandComboBox_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Brand:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Model:";
			// 
			// modelComboBox
			// 
			this.modelComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.modelComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.modelComboBox.FormattingEnabled = true;
			this.modelComboBox.Location = new System.Drawing.Point(87, 122);
			this.modelComboBox.Name = "modelComboBox";
			this.modelComboBox.Size = new System.Drawing.Size(178, 22);
			this.modelComboBox.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "Color:";
			// 
			// colorComboBox
			// 
			this.colorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.colorComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.colorComboBox.FormattingEnabled = true;
			this.colorComboBox.Location = new System.Drawing.Point(87, 165);
			this.colorComboBox.Name = "colorComboBox";
			this.colorComboBox.Size = new System.Drawing.Size(178, 22);
			this.colorComboBox.TabIndex = 8;
			// 
			// yearNumeric
			// 
			this.yearNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.yearNumeric.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.yearNumeric.Location = new System.Drawing.Point(87, 207);
			this.yearNumeric.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
			this.yearNumeric.Minimum = new decimal(new int[] {
            1886,
            0,
            0,
            0});
			this.yearNumeric.Name = "yearNumeric";
			this.yearNumeric.Size = new System.Drawing.Size(120, 22);
			this.yearNumeric.TabIndex = 10;
			this.yearNumeric.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 209);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 15);
			this.label5.TabIndex = 11;
			this.label5.Text = "Year:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(24, 253);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 15);
			this.label6.TabIndex = 12;
			this.label6.Text = "Number:";
			// 
			// numberMaskedTextBox
			// 
			this.numberMaskedTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.numberMaskedTextBox.Location = new System.Drawing.Point(87, 250);
			this.numberMaskedTextBox.Mask = "LL0000LL";
			this.numberMaskedTextBox.Name = "numberMaskedTextBox";
			this.numberMaskedTextBox.Size = new System.Drawing.Size(178, 22);
			this.numberMaskedTextBox.TabIndex = 13;
			// 
			// vinNumTextBox
			// 
			this.vinNumTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.vinNumTextBox.Location = new System.Drawing.Point(88, 294);
			this.vinNumTextBox.MaxLength = 17;
			this.vinNumTextBox.Name = "vinNumTextBox";
			this.vinNumTextBox.Size = new System.Drawing.Size(177, 22);
			this.vinNumTextBox.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(24, 297);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 15);
			this.label7.TabIndex = 15;
			this.label7.Text = "VIN:";
			// 
			// showCarInfoButton
			// 
			this.showCarInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(42)))), ((int)(((byte)(243)))));
			this.showCarInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.showCarInfoButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.showCarInfoButton.ForeColor = System.Drawing.Color.White;
			this.showCarInfoButton.Location = new System.Drawing.Point(315, 345);
			this.showCarInfoButton.Name = "showCarInfoButton";
			this.showCarInfoButton.Size = new System.Drawing.Size(128, 48);
			this.showCarInfoButton.TabIndex = 16;
			this.showCarInfoButton.Text = "SHOW";
			this.showCarInfoButton.UseVisualStyleBackColor = false;
			this.showCarInfoButton.Click += new System.EventHandler(this.showCarInfoButton_Click);
			// 
			// selectCarComboBox
			// 
			this.selectCarComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.selectCarComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.selectCarComboBox.FormattingEnabled = true;
			this.selectCarComboBox.Location = new System.Drawing.Point(385, 297);
			this.selectCarComboBox.Name = "selectCarComboBox";
			this.selectCarComboBox.Size = new System.Drawing.Size(215, 22);
			this.selectCarComboBox.TabIndex = 17;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(315, 300);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 15);
			this.label8.TabIndex = 18;
			this.label8.Text = "Search car:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 415);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.selectCarComboBox);
			this.Controls.Add(this.showCarInfoButton);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.vinNumTextBox);
			this.Controls.Add(this.numberMaskedTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.yearNumeric);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.colorComboBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.modelComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.brandComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.deleteCarButton);
			this.Controls.Add(this.addCarButton);
			this.Controls.Add(this.carsListBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Car info";
			((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox carsListBox;
		private System.Windows.Forms.Button addCarButton;
		private System.Windows.Forms.Button deleteCarButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox brandComboBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox modelComboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox colorComboBox;
		private System.Windows.Forms.NumericUpDown yearNumeric;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox numberMaskedTextBox;
		private System.Windows.Forms.TextBox vinNumTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button showCarInfoButton;
		private System.Windows.Forms.ComboBox selectCarComboBox;
		private System.Windows.Forms.Label label8;
	}
}
