namespace text_editor
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
			this.components = new System.ComponentModel.Container();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeFontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeBGColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.symbCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.contextMenuStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.textBox1.Location = new System.Drawing.Point(-1, 27);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(950, 512);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.deselectAllToolStripMenuItem,
            this.changeTextColorToolStripMenuItem,
            this.changeFontToolStripMenuItem1});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(175, 136);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.pasteToolStripMenuItem.Text = "Paste";
			this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.selectAllToolStripMenuItem.Text = "Select All";
			this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
			// 
			// deselectAllToolStripMenuItem
			// 
			this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
			this.deselectAllToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.deselectAllToolStripMenuItem.Text = "Deselect All";
			this.deselectAllToolStripMenuItem.Click += new System.EventHandler(this.deselectAllToolStripMenuItem_Click);
			// 
			// changeTextColorToolStripMenuItem
			// 
			this.changeTextColorToolStripMenuItem.Name = "changeTextColorToolStripMenuItem";
			this.changeTextColorToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.changeTextColorToolStripMenuItem.Text = "Change  Text Color";
			this.changeTextColorToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
			// 
			// changeFontToolStripMenuItem1
			// 
			this.changeFontToolStripMenuItem1.Name = "changeFontToolStripMenuItem1";
			this.changeFontToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
			this.changeFontToolStripMenuItem1.Text = "Change Font";
			this.changeFontToolStripMenuItem1.Click += new System.EventHandler(this.changeFontToolStripMenuItem_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.textToolStripMenuItem,
            this.fontToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(948, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.loadToolStripMenuItem.Text = "Load";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// textToolStripMenuItem
			// 
			this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem,
            this.changeBGColorToolStripMenuItem});
			this.textToolStripMenuItem.Name = "textToolStripMenuItem";
			this.textToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.textToolStripMenuItem.Text = "Color";
			// 
			// changeColorToolStripMenuItem
			// 
			this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
			this.changeColorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
			this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
			this.changeColorToolStripMenuItem.Text = "Change Text Color";
			this.changeColorToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
			// 
			// changeBGColorToolStripMenuItem
			// 
			this.changeBGColorToolStripMenuItem.Name = "changeBGColorToolStripMenuItem";
			this.changeBGColorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
			this.changeBGColorToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
			this.changeBGColorToolStripMenuItem.Text = "Change BG Color";
			this.changeBGColorToolStripMenuItem.Click += new System.EventHandler(this.changeBGColorToolStripMenuItem_Click);
			// 
			// fontToolStripMenuItem
			// 
			this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeFontToolStripMenuItem});
			this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
			this.fontToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.fontToolStripMenuItem.Text = "Font";
			// 
			// changeFontToolStripMenuItem
			// 
			this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
			this.changeFontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
			this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.changeFontToolStripMenuItem.Text = "Change Font";
			this.changeFontToolStripMenuItem.Click += new System.EventHandler(this.changeFontToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.symbCountLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 542);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(948, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
			this.toolStripStatusLabel1.Text = "Count:";
			// 
			// symbCountLabel
			// 
			this.symbCountLabel.Name = "symbCountLabel";
			this.symbCountLabel.Size = new System.Drawing.Size(13, 17);
			this.symbCountLabel.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 564);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Simple Text Editor";
			this.contextMenuStrip1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox textBox1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem loadToolStripMenuItem;
		private ToolStripMenuItem textToolStripMenuItem;
		private ToolStripMenuItem changeColorToolStripMenuItem;
		private ToolStripMenuItem changeBGColorToolStripMenuItem;
		private ToolStripMenuItem fontToolStripMenuItem;
		private ToolStripMenuItem changeFontToolStripMenuItem;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStripStatusLabel symbCountLabel;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem copyToolStripMenuItem;
		private ToolStripMenuItem pasteToolStripMenuItem;
		private ToolStripMenuItem selectAllToolStripMenuItem;
		private ToolStripMenuItem deselectAllToolStripMenuItem;
		private ToolStripMenuItem changeTextColorToolStripMenuItem;
		private ToolStripMenuItem changeFontToolStripMenuItem1;
	}
}