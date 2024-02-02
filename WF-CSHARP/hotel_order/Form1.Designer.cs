namespace hotel_order
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
			this.phoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.economRadioBtn = new System.Windows.Forms.RadioButton();
			this.standartRadioBtn = new System.Windows.Forms.RadioButton();
			this.luxRadioBtn = new System.Windows.Forms.RadioButton();
			this.clearButton = new System.Windows.Forms.Button();
			this.rentButton = new System.Windows.Forms.Button();
			this.termsCheckBox = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.specialNotesTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.peopleCount = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.saveBtn = new System.Windows.Forms.Button();
			this.loadBtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.peopleCount)).BeginInit();
			this.SuspendLayout();
			// 
			// phoneNumberTextBox
			// 
			this.phoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.phoneNumberTextBox.Location = new System.Drawing.Point(126, 196);
			this.phoneNumberTextBox.Mask = "+38(000) 000-0000";
			this.phoneNumberTextBox.Name = "phoneNumberTextBox";
			this.phoneNumberTextBox.Size = new System.Drawing.Size(297, 25);
			this.phoneNumberTextBox.TabIndex = 49;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.economRadioBtn);
			this.panel1.Controls.Add(this.standartRadioBtn);
			this.panel1.Controls.Add(this.luxRadioBtn);
			this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.panel1.ForeColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(145, 276);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(255, 58);
			this.panel1.TabIndex = 47;
			// 
			// economRadioBtn
			// 
			this.economRadioBtn.AutoSize = true;
			this.economRadioBtn.Location = new System.Drawing.Point(11, 19);
			this.economRadioBtn.Name = "economRadioBtn";
			this.economRadioBtn.Size = new System.Drawing.Size(75, 21);
			this.economRadioBtn.TabIndex = 10;
			this.economRadioBtn.TabStop = true;
			this.economRadioBtn.Text = "Econom";
			this.economRadioBtn.UseVisualStyleBackColor = true;
			// 
			// standartRadioBtn
			// 
			this.standartRadioBtn.AutoSize = true;
			this.standartRadioBtn.Location = new System.Drawing.Point(101, 19);
			this.standartRadioBtn.Name = "standartRadioBtn";
			this.standartRadioBtn.Size = new System.Drawing.Size(78, 21);
			this.standartRadioBtn.TabIndex = 11;
			this.standartRadioBtn.TabStop = true;
			this.standartRadioBtn.Text = "Standart";
			this.standartRadioBtn.UseVisualStyleBackColor = true;
			// 
			// luxRadioBtn
			// 
			this.luxRadioBtn.AutoSize = true;
			this.luxRadioBtn.Location = new System.Drawing.Point(190, 19);
			this.luxRadioBtn.Name = "luxRadioBtn";
			this.luxRadioBtn.Size = new System.Drawing.Size(47, 21);
			this.luxRadioBtn.TabIndex = 12;
			this.luxRadioBtn.TabStop = true;
			this.luxRadioBtn.Text = "Lux";
			this.luxRadioBtn.UseVisualStyleBackColor = true;
			// 
			// clearButton
			// 
			this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
			this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.clearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.clearButton.ForeColor = System.Drawing.Color.White;
			this.clearButton.Location = new System.Drawing.Point(246, 566);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(177, 50);
			this.clearButton.TabIndex = 46;
			this.clearButton.Text = "CLEAR";
			this.clearButton.UseVisualStyleBackColor = false;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// rentButton
			// 
			this.rentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
			this.rentButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rentButton.Enabled = false;
			this.rentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.rentButton.ForeColor = System.Drawing.Color.White;
			this.rentButton.Location = new System.Drawing.Point(19, 566);
			this.rentButton.Name = "rentButton";
			this.rentButton.Size = new System.Drawing.Size(177, 50);
			this.rentButton.TabIndex = 45;
			this.rentButton.Text = "RENT";
			this.rentButton.UseVisualStyleBackColor = false;
			this.rentButton.Click += new System.EventHandler(this.rentButton_Click);
			// 
			// termsCheckBox
			// 
			this.termsCheckBox.AutoSize = true;
			this.termsCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.termsCheckBox.ForeColor = System.Drawing.Color.White;
			this.termsCheckBox.Location = new System.Drawing.Point(22, 458);
			this.termsCheckBox.Name = "termsCheckBox";
			this.termsCheckBox.Size = new System.Drawing.Size(193, 21);
			this.termsCheckBox.TabIndex = 43;
			this.termsCheckBox.Text = "Accept all rights and terms";
			this.termsCheckBox.UseVisualStyleBackColor = true;
			this.termsCheckBox.CheckedChanged += new System.EventHandler(this.termsCheckBox_CheckedChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(19, 414);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 25);
			this.label8.TabIndex = 42;
			this.label8.Text = "Date:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.dateTimePicker1.Location = new System.Drawing.Point(126, 416);
			this.dateTimePicker1.MinDate = new System.DateTime(2023, 2, 9, 20, 53, 21, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dateTimePicker1.Size = new System.Drawing.Size(297, 23);
			this.dateTimePicker1.TabIndex = 41;
			this.dateTimePicker1.Value = new System.DateTime(2023, 2, 9, 20, 53, 21, 0);
			// 
			// specialNotesTextBox
			// 
			this.specialNotesTextBox.Location = new System.Drawing.Point(126, 341);
			this.specialNotesTextBox.Multiline = true;
			this.specialNotesTextBox.Name = "specialNotesTextBox";
			this.specialNotesTextBox.Size = new System.Drawing.Size(297, 50);
			this.specialNotesTextBox.TabIndex = 40;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(19, 341);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 50);
			this.label7.TabIndex = 39;
			this.label7.Text = "Special\r\nNotes:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(19, 291);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 25);
			this.label6.TabIndex = 38;
			this.label6.Text = "Room type:";
			// 
			// peopleCount
			// 
			this.peopleCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.peopleCount.Location = new System.Drawing.Point(126, 245);
			this.peopleCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.peopleCount.Name = "peopleCount";
			this.peopleCount.Size = new System.Drawing.Size(80, 25);
			this.peopleCount.TabIndex = 37;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(22, 245);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 25);
			this.label5.TabIndex = 36;
			this.label5.Text = "Count:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(22, 196);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 25);
			this.label4.TabIndex = 35;
			this.label4.Text = "Phone:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(126, 150);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(297, 23);
			this.addressTextBox.TabIndex = 34;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(22, 148);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 25);
			this.label3.TabIndex = 33;
			this.label3.Text = "Adress:";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(126, 104);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(297, 23);
			this.nameTextBox.TabIndex = 32;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(22, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 25);
			this.label2.TabIndex = 31;
			this.label2.Text = "Name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(253, -75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(286, 65);
			this.label1.TabIndex = 30;
			this.label1.Text = "Order Pizza";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(99, 21);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(260, 54);
			this.label12.TabIndex = 54;
			this.label12.Text = "RENT ROOM";
			// 
			// saveBtn
			// 
			this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
			this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.saveBtn.ForeColor = System.Drawing.Color.White;
			this.saveBtn.Location = new System.Drawing.Point(19, 498);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(177, 50);
			this.saveBtn.TabIndex = 55;
			this.saveBtn.Text = "SAVE";
			this.saveBtn.UseVisualStyleBackColor = false;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// loadBtn
			// 
			this.loadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
			this.loadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loadBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.loadBtn.ForeColor = System.Drawing.Color.White;
			this.loadBtn.Location = new System.Drawing.Point(246, 498);
			this.loadBtn.Name = "loadBtn";
			this.loadBtn.Size = new System.Drawing.Size(177, 50);
			this.loadBtn.TabIndex = 56;
			this.loadBtn.Text = "LOAD";
			this.loadBtn.UseVisualStyleBackColor = false;
			this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
			this.ClientSize = new System.Drawing.Size(444, 644);
			this.Controls.Add(this.loadBtn);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.phoneNumberTextBox);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.rentButton);
			this.Controls.Add(this.termsCheckBox);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.specialNotesTextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.peopleCount);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.peopleCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MaskedTextBox phoneNumberTextBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton economRadioBtn;
		private System.Windows.Forms.RadioButton standartRadioBtn;
		private System.Windows.Forms.RadioButton luxRadioBtn;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button rentButton;
		private System.Windows.Forms.CheckBox termsCheckBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox specialNotesTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown peopleCount;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Button loadBtn;
	}
}
