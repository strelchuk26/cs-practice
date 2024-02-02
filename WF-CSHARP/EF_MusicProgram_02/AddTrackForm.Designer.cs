namespace EF_MusicProgram
{
	partial class AddTrackForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.trackNameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.addTrackButton = new System.Windows.Forms.Button();
			this.trackDuration = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.performerTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.genreTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.trackDuration)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(156, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 54);
			this.label1.TabIndex = 1;
			this.label1.Text = "Add Track";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(27, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 28);
			this.label2.TabIndex = 4;
			this.label2.Text = "Name";
			// 
			// trackNameTextBox
			// 
			this.trackNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.trackNameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.trackNameTextBox.ForeColor = System.Drawing.Color.White;
			this.trackNameTextBox.Location = new System.Drawing.Point(27, 120);
			this.trackNameTextBox.Name = "trackNameTextBox";
			this.trackNameTextBox.Size = new System.Drawing.Size(448, 29);
			this.trackNameTextBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(27, 381);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 28);
			this.label3.TabIndex = 6;
			this.label3.Text = "Duration";
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
			this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cancelButton.FlatAppearance.BorderSize = 0;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.cancelButton.ForeColor = System.Drawing.Color.White;
			this.cancelButton.Location = new System.Drawing.Point(278, 479);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(197, 49);
			this.cancelButton.TabIndex = 17;
			this.cancelButton.Text = "CANCEL";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// addTrackButton
			// 
			this.addTrackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
			this.addTrackButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addTrackButton.FlatAppearance.BorderSize = 0;
			this.addTrackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addTrackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.addTrackButton.ForeColor = System.Drawing.Color.White;
			this.addTrackButton.Location = new System.Drawing.Point(27, 479);
			this.addTrackButton.Name = "addTrackButton";
			this.addTrackButton.Size = new System.Drawing.Size(197, 49);
			this.addTrackButton.TabIndex = 16;
			this.addTrackButton.Text = "ADD";
			this.addTrackButton.UseVisualStyleBackColor = false;
			this.addTrackButton.Click += new System.EventHandler(this.addTrackButton_Click);
			// 
			// trackDuration
			// 
			this.trackDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.trackDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.trackDuration.ForeColor = System.Drawing.Color.White;
			this.trackDuration.Location = new System.Drawing.Point(27, 412);
			this.trackDuration.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
			this.trackDuration.Name = "trackDuration";
			this.trackDuration.Size = new System.Drawing.Size(120, 29);
			this.trackDuration.TabIndex = 20;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(27, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 28);
			this.label4.TabIndex = 22;
			this.label4.Text = "Performer";
			// 
			// performerTextBox
			// 
			this.performerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.performerTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.performerTextBox.ForeColor = System.Drawing.Color.White;
			this.performerTextBox.Location = new System.Drawing.Point(27, 213);
			this.performerTextBox.Name = "performerTextBox";
			this.performerTextBox.Size = new System.Drawing.Size(448, 29);
			this.performerTextBox.TabIndex = 21;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(27, 280);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 28);
			this.label5.TabIndex = 24;
			this.label5.Text = "Genre";
			// 
			// genreTextBox
			// 
			this.genreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.genreTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.genreTextBox.ForeColor = System.Drawing.Color.White;
			this.genreTextBox.Location = new System.Drawing.Point(27, 311);
			this.genreTextBox.Name = "genreTextBox";
			this.genreTextBox.Size = new System.Drawing.Size(448, 29);
			this.genreTextBox.TabIndex = 23;
			// 
			// AddTrackForm
			// 
			this.AcceptButton = this.addTrackButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(505, 550);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.genreTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.performerTextBox);
			this.Controls.Add(this.trackDuration);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.addTrackButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.trackNameTextBox);
			this.Controls.Add(this.label1);
			this.Name = "AddTrackForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AddTrackForm";
			((System.ComponentModel.ISupportInitialize)(this.trackDuration)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox trackNameTextBox;
		private Label label3;
		private Button cancelButton;
		private Button addTrackButton;
		private NumericUpDown trackDuration;
		private Label label4;
		private TextBox performerTextBox;
		private Label label5;
		private TextBox genreTextBox;
	}
}