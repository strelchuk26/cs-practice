namespace sales_wf
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
			this.saveChangesButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.chooseTableComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// saveChangesButton
			// 
			this.saveChangesButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.saveChangesButton.Location = new System.Drawing.Point(29, 166);
			this.saveChangesButton.Name = "saveChangesButton";
			this.saveChangesButton.Size = new System.Drawing.Size(213, 45);
			this.saveChangesButton.TabIndex = 0;
			this.saveChangesButton.Text = "Save changes";
			this.saveChangesButton.UseVisualStyleBackColor = true;
			this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(271, 24);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(920, 647);
			this.dataGridView1.TabIndex = 1;
			// 
			// chooseTableComboBox
			// 
			this.chooseTableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.chooseTableComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.chooseTableComboBox.FormattingEnabled = true;
			this.chooseTableComboBox.ItemHeight = 21;
			this.chooseTableComboBox.Items.AddRange(new object[] {
            "Buyers",
            "Sallers",
            "Sales"});
			this.chooseTableComboBox.Location = new System.Drawing.Point(29, 105);
			this.chooseTableComboBox.Name = "chooseTableComboBox";
			this.chooseTableComboBox.Size = new System.Drawing.Size(213, 29);
			this.chooseTableComboBox.TabIndex = 2;
			this.chooseTableComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseTableComboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(102, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Table:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1214, 692);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chooseTableComboBox);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.saveChangesButton);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveChangesButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox chooseTableComboBox;
		private System.Windows.Forms.Label label1;
	}
}
