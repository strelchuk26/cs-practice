namespace EF_MusicProgram
{
	partial class CreatePlaylistForm
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
			this.playlistNameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tracksListBox = new System.Windows.Forms.ListBox();
			this.addTrackButton = new System.Windows.Forms.Button();
			this.deleteTrackButton = new System.Windows.Forms.Button();
			this.createPlaylistButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(117, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(271, 54);
			this.label1.TabIndex = 0;
			this.label1.Text = "Create Playlist";
			// 
			// playlistNameTextBox
			// 
			this.playlistNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.playlistNameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.playlistNameTextBox.ForeColor = System.Drawing.Color.White;
			this.playlistNameTextBox.Location = new System.Drawing.Point(27, 120);
			this.playlistNameTextBox.Name = "playlistNameTextBox";
			this.playlistNameTextBox.Size = new System.Drawing.Size(448, 29);
			this.playlistNameTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(27, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 28);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(27, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 28);
			this.label4.TabIndex = 10;
			this.label4.Text = "Tracks";
			// 
			// tracksListBox
			// 
			this.tracksListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.tracksListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.tracksListBox.ForeColor = System.Drawing.Color.White;
			this.tracksListBox.FormattingEnabled = true;
			this.tracksListBox.ItemHeight = 21;
			this.tracksListBox.Location = new System.Drawing.Point(27, 213);
			this.tracksListBox.Name = "tracksListBox";
			this.tracksListBox.Size = new System.Drawing.Size(448, 214);
			this.tracksListBox.TabIndex = 11;
			// 
			// addTrackButton
			// 
			this.addTrackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
			this.addTrackButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addTrackButton.FlatAppearance.BorderSize = 0;
			this.addTrackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addTrackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.addTrackButton.ForeColor = System.Drawing.Color.White;
			this.addTrackButton.Location = new System.Drawing.Point(62, 442);
			this.addTrackButton.Name = "addTrackButton";
			this.addTrackButton.Size = new System.Drawing.Size(162, 49);
			this.addTrackButton.TabIndex = 12;
			this.addTrackButton.Text = "ADD";
			this.addTrackButton.UseVisualStyleBackColor = false;
			this.addTrackButton.Click += new System.EventHandler(this.addTrackButton_Click);
			// 
			// deleteTrackButton
			// 
			this.deleteTrackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
			this.deleteTrackButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.deleteTrackButton.FlatAppearance.BorderSize = 0;
			this.deleteTrackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteTrackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.deleteTrackButton.ForeColor = System.Drawing.Color.White;
			this.deleteTrackButton.Location = new System.Drawing.Point(278, 442);
			this.deleteTrackButton.Name = "deleteTrackButton";
			this.deleteTrackButton.Size = new System.Drawing.Size(162, 49);
			this.deleteTrackButton.TabIndex = 13;
			this.deleteTrackButton.Text = "DELETE";
			this.deleteTrackButton.UseVisualStyleBackColor = false;
			this.deleteTrackButton.Click += new System.EventHandler(this.deleteTrackButton_Click);
			// 
			// createPlaylistButton
			// 
			this.createPlaylistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
			this.createPlaylistButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.createPlaylistButton.FlatAppearance.BorderSize = 0;
			this.createPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createPlaylistButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.createPlaylistButton.ForeColor = System.Drawing.Color.White;
			this.createPlaylistButton.Location = new System.Drawing.Point(27, 510);
			this.createPlaylistButton.Name = "createPlaylistButton";
			this.createPlaylistButton.Size = new System.Drawing.Size(197, 49);
			this.createPlaylistButton.TabIndex = 14;
			this.createPlaylistButton.Text = "CREATE";
			this.createPlaylistButton.UseVisualStyleBackColor = false;
			this.createPlaylistButton.Click += new System.EventHandler(this.createPlaylistButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
			this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cancelButton.FlatAppearance.BorderSize = 0;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.cancelButton.ForeColor = System.Drawing.Color.White;
			this.cancelButton.Location = new System.Drawing.Point(278, 510);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(197, 49);
			this.cancelButton.TabIndex = 15;
			this.cancelButton.Text = "CANCEL";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// CreatePlaylistForm
			// 
			this.AcceptButton = this.createPlaylistButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(505, 581);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.createPlaylistButton);
			this.Controls.Add(this.deleteTrackButton);
			this.Controls.Add(this.addTrackButton);
			this.Controls.Add(this.tracksListBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.playlistNameTextBox);
			this.Controls.Add(this.label1);
			this.Name = "CreatePlaylistForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CreatePlaylistForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private TextBox playlistNameTextBox;
		private Label label2;
		private Label label4;
		private ListBox tracksListBox;
		private Button addTrackButton;
		private Button deleteTrackButton;
		private Button createPlaylistButton;
		private Button cancelButton;
	}
}