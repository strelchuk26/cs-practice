namespace EF_MusicProgram
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
			this.tracklistBox = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.createPlaylistButton = new System.Windows.Forms.Button();
			this.playlistListBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.playlistName = new System.Windows.Forms.Label();
			this.removeTrackButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tracklistBox
			// 
			this.tracklistBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.tracklistBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tracklistBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.tracklistBox.ForeColor = System.Drawing.Color.White;
			this.tracklistBox.FormattingEnabled = true;
			this.tracklistBox.ItemHeight = 37;
			this.tracklistBox.Location = new System.Drawing.Point(250, 112);
			this.tracklistBox.Name = "tracklistBox";
			this.tracklistBox.Size = new System.Drawing.Size(808, 555);
			this.tracklistBox.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.createPlaylistButton);
			this.panel1.Controls.Add(this.playlistListBox);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(237, 665);
			this.panel1.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(53, 43);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(127, 127);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// createPlaylistButton
			// 
			this.createPlaylistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
			this.createPlaylistButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.createPlaylistButton.FlatAppearance.BorderSize = 0;
			this.createPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createPlaylistButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.createPlaylistButton.ForeColor = System.Drawing.Color.White;
			this.createPlaylistButton.Location = new System.Drawing.Point(53, 207);
			this.createPlaylistButton.Name = "createPlaylistButton";
			this.createPlaylistButton.Size = new System.Drawing.Size(127, 37);
			this.createPlaylistButton.TabIndex = 5;
			this.createPlaylistButton.Text = "Create Playlist";
			this.createPlaylistButton.UseVisualStyleBackColor = false;
			this.createPlaylistButton.Click += new System.EventHandler(this.createPlaylistButton_Click);
			// 
			// playlistListBox
			// 
			this.playlistListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.playlistListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.playlistListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.playlistListBox.ForeColor = System.Drawing.Color.White;
			this.playlistListBox.FormattingEnabled = true;
			this.playlistListBox.ItemHeight = 25;
			this.playlistListBox.Location = new System.Drawing.Point(1, 262);
			this.playlistListBox.Name = "playlistListBox";
			this.playlistListBox.Size = new System.Drawing.Size(236, 400);
			this.playlistListBox.TabIndex = 4;
			this.playlistListBox.SelectedIndexChanged += new System.EventHandler(this.playlistListBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(893, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 54);
			this.label1.TabIndex = 4;
			this.label1.Text = "Tracks";
			// 
			// playlistName
			// 
			this.playlistName.AutoSize = true;
			this.playlistName.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.playlistName.ForeColor = System.Drawing.Color.White;
			this.playlistName.Location = new System.Drawing.Point(250, 43);
			this.playlistName.Name = "playlistName";
			this.playlistName.Size = new System.Drawing.Size(0, 54);
			this.playlistName.TabIndex = 5;
			// 
			// removeTrackButton
			// 
			this.removeTrackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
			this.removeTrackButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.removeTrackButton.FlatAppearance.BorderSize = 0;
			this.removeTrackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removeTrackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.removeTrackButton.ForeColor = System.Drawing.Color.White;
			this.removeTrackButton.Location = new System.Drawing.Point(1095, 112);
			this.removeTrackButton.Name = "removeTrackButton";
			this.removeTrackButton.Size = new System.Drawing.Size(127, 49);
			this.removeTrackButton.TabIndex = 7;
			this.removeTrackButton.Text = "Remove Track";
			this.removeTrackButton.UseVisualStyleBackColor = false;
			this.removeTrackButton.Click += new System.EventHandler(this.removeTrackButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1271, 660);
			this.Controls.Add(this.removeTrackButton);
			this.Controls.Add(this.playlistName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tracklistBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Music Manager";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ListBox tracklistBox;
		private Panel panel1;
		private ListBox playlistListBox;
		private Button createPlaylistButton;
		private Label label1;
		private Label playlistName;
		private PictureBox pictureBox1;
		private Button removeTrackButton;
	}
}