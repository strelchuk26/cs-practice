
namespace shop_forms
{
    partial class ProductForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.priceNum = new System.Windows.Forms.NumericUpDown();
			this.countryComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.countNum = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.discountNum = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.priceNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.countNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.discountNum)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(121, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Product";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(34, 78);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(291, 23);
			this.nameTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(34, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(34, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "Price:";
			// 
			// priceNum
			// 
			this.priceNum.Location = new System.Drawing.Point(34, 138);
			this.priceNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.priceNum.Name = "priceNum";
			this.priceNum.Size = new System.Drawing.Size(291, 23);
			this.priceNum.TabIndex = 5;
			// 
			// countryComboBox
			// 
			this.countryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.countryComboBox.FormattingEnabled = true;
			this.countryComboBox.Location = new System.Drawing.Point(34, 204);
			this.countryComboBox.Name = "countryComboBox";
			this.countryComboBox.Size = new System.Drawing.Size(291, 23);
			this.countryComboBox.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(34, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 19);
			this.label4.TabIndex = 7;
			this.label4.Text = "Country:";
			// 
			// countNum
			// 
			this.countNum.Location = new System.Drawing.Point(34, 267);
			this.countNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.countNum.Name = "countNum";
			this.countNum.Size = new System.Drawing.Size(291, 23);
			this.countNum.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(34, 245);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 19);
			this.label5.TabIndex = 8;
			this.label5.Text = "Count:";
			// 
			// discountNum
			// 
			this.discountNum.Location = new System.Drawing.Point(34, 339);
			this.discountNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.discountNum.Name = "discountNum";
			this.discountNum.Size = new System.Drawing.Size(291, 23);
			this.discountNum.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(34, 317);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 19);
			this.label6.TabIndex = 10;
			this.label6.Text = "Disount:";
			// 
			// okButton
			// 
			this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(41)))), ((int)(((byte)(113)))));
			this.okButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.okButton.ForeColor = System.Drawing.Color.White;
			this.okButton.Location = new System.Drawing.Point(34, 395);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(128, 51);
			this.okButton.TabIndex = 12;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(41)))), ((int)(((byte)(113)))));
			this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.cancelButton.ForeColor = System.Drawing.Color.White;
			this.cancelButton.Location = new System.Drawing.Point(197, 395);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(128, 51);
			this.cancelButton.TabIndex = 13;
			this.cancelButton.Text = "CANCEL";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// ProductForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(357, 468);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.discountNum);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.countNum);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.countryComboBox);
			this.Controls.Add(this.priceNum);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.label1);
			this.Name = "ProductForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Product";
			((System.ComponentModel.ISupportInitialize)(this.priceNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.countNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.discountNum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown priceNum;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown countNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown discountNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}