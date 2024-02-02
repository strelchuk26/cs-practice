namespace аля_нотепад
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectAlllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.changeBgColorButton = new System.Windows.Forms.ToolStripButton();
			this.changeTextColorButton = new System.Windows.Forms.ToolStripButton();
			this.makeBulletListButoon = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.alignLeftButton = new System.Windows.Forms.ToolStripMenuItem();
			this.alignCenterButton = new System.Windows.Forms.ToolStripMenuItem();
			this.alignRightButton = new System.Windows.Forms.ToolStripMenuItem();
			this.changeFontButton = new System.Windows.Forms.ToolStripButton();
			this.saveFileButton = new System.Windows.Forms.ToolStripButton();
			this.loafFileButton = new System.Windows.Forms.ToolStripButton();
			this.contextMenuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.richTextBox1.Location = new System.Drawing.Point(-3, 42);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(1016, 538);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAlllToolStripMenuItem,
            this.deselectAllToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(178, 114);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.pasteToolStripMenuItem.Text = "Paste";
			this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
			// 
			// selectAlllToolStripMenuItem
			// 
			this.selectAlllToolStripMenuItem.Name = "selectAlllToolStripMenuItem";
			this.selectAlllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.selectAlllToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.selectAlllToolStripMenuItem.Text = "Select All";
			this.selectAlllToolStripMenuItem.Click += new System.EventHandler(this.selectAlllToolStripMenuItem_Click);
			// 
			// deselectAllToolStripMenuItem
			// 
			this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
			this.deselectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.deselectAllToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.deselectAllToolStripMenuItem.Text = "Deselect All";
			this.deselectAllToolStripMenuItem.Click += new System.EventHandler(this.deselectAllToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBgColorButton,
            this.changeTextColorButton,
            this.makeBulletListButoon,
            this.toolStripDropDownButton1,
            this.changeFontButton,
            this.saveFileButton,
            this.loafFileButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1011, 39);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// changeBgColorButton
			// 
			this.changeBgColorButton.Image = ((System.Drawing.Image)(resources.GetObject("changeBgColorButton.Image")));
			this.changeBgColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.changeBgColorButton.Name = "changeBgColorButton";
			this.changeBgColorButton.Size = new System.Drawing.Size(107, 36);
			this.changeBgColorButton.Text = "Background";
			this.changeBgColorButton.Click += new System.EventHandler(this.changeBgColorButton_Click);
			// 
			// changeTextColorButton
			// 
			this.changeTextColorButton.Image = ((System.Drawing.Image)(resources.GetObject("changeTextColorButton.Image")));
			this.changeTextColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.changeTextColorButton.Name = "changeTextColorButton";
			this.changeTextColorButton.Size = new System.Drawing.Size(72, 36);
			this.changeTextColorButton.Text = "Color";
			this.changeTextColorButton.Click += new System.EventHandler(this.changeTextColorButton_Click);
			// 
			// makeBulletListButoon
			// 
			this.makeBulletListButoon.Image = ((System.Drawing.Image)(resources.GetObject("makeBulletListButoon.Image")));
			this.makeBulletListButoon.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.makeBulletListButoon.Name = "makeBulletListButoon";
			this.makeBulletListButoon.Size = new System.Drawing.Size(73, 36);
			this.makeBulletListButoon.Text = "Bullet";
			this.makeBulletListButoon.Click += new System.EventHandler(this.makeBulletListButoon_Click);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alignLeftButton,
            this.alignCenterButton,
            this.alignRightButton});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(108, 36);
			this.toolStripDropDownButton1.Text = "Alignment";
			// 
			// alignLeftButton
			// 
			this.alignLeftButton.Name = "alignLeftButton";
			this.alignLeftButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.L)));
			this.alignLeftButton.Size = new System.Drawing.Size(180, 22);
			this.alignLeftButton.Text = "Left";
			this.alignLeftButton.Click += new System.EventHandler(this.alignLeftButton_Click);
			// 
			// alignCenterButton
			// 
			this.alignCenterButton.Name = "alignCenterButton";
			this.alignCenterButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
			this.alignCenterButton.Size = new System.Drawing.Size(180, 22);
			this.alignCenterButton.Text = "Center";
			this.alignCenterButton.Click += new System.EventHandler(this.alignCenterButton_Click);
			// 
			// alignRightButton
			// 
			this.alignRightButton.Name = "alignRightButton";
			this.alignRightButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
			this.alignRightButton.Size = new System.Drawing.Size(180, 22);
			this.alignRightButton.Text = "Right";
			this.alignRightButton.Click += new System.EventHandler(this.alignRightButton_Click);
			// 
			// changeFontButton
			// 
			this.changeFontButton.Image = ((System.Drawing.Image)(resources.GetObject("changeFontButton.Image")));
			this.changeFontButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.changeFontButton.Name = "changeFontButton";
			this.changeFontButton.Size = new System.Drawing.Size(67, 36);
			this.changeFontButton.Text = "Font";
			this.changeFontButton.Click += new System.EventHandler(this.changeFontButton_Click);
			// 
			// saveFileButton
			// 
			this.saveFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("saveFileButton.Image")));
			this.saveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveFileButton.Name = "saveFileButton";
			this.saveFileButton.Size = new System.Drawing.Size(36, 36);
			this.saveFileButton.Text = "Save";
			this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
			// 
			// loafFileButton
			// 
			this.loafFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.loafFileButton.Image = ((System.Drawing.Image)(resources.GetObject("loafFileButton.Image")));
			this.loafFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.loafFileButton.Name = "loafFileButton";
			this.loafFileButton.Size = new System.Drawing.Size(36, 36);
			this.loafFileButton.Text = "Open";
			this.loafFileButton.Click += new System.EventHandler(this.loafFileButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1011, 605);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.richTextBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Аля Нотепад";
			this.contextMenuStrip1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RichTextBox richTextBox1;
		private ToolStrip toolStrip1;
		private ToolStripButton changeBgColorButton;
		private ToolStripButton changeTextColorButton;
		private ToolStripButton makeBulletListButoon;
		private ToolStripDropDownButton toolStripDropDownButton1;
		private ToolStripMenuItem alignLeftButton;
		private ToolStripMenuItem alignCenterButton;
		private ToolStripMenuItem alignRightButton;
		private ToolStripButton changeFontButton;
		private ToolStripButton saveFileButton;
		private ToolStripButton loafFileButton;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem copyToolStripMenuItem;
		private ToolStripMenuItem pasteToolStripMenuItem;
		private ToolStripMenuItem selectAlllToolStripMenuItem;
		private ToolStripMenuItem deselectAllToolStripMenuItem;
		private ToolStripMenuItem deleteToolStripMenuItem;
	}
}