using System.Text;

namespace аля_нотепад
{
	public partial class Form1 : Form
	{
		StringBuilder text = new StringBuilder();
		public string copyText { get; set; }
		public Form1()
		{
			InitializeComponent();
		}

		private void changeBgColorButton_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new();
			dialog.Color = richTextBox1.SelectionBackColor;

			if (dialog.ShowDialog() == DialogResult.OK)
				richTextBox1.SelectionBackColor = dialog.Color;
		}

		private void changeTextColorButton_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new();
			dialog.Color = richTextBox1.SelectionColor;

			if (dialog.ShowDialog() == DialogResult.OK)
				richTextBox1.SelectionColor = dialog.Color;
		}

		private void makeBulletListButoon_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
		}

		private void alignLeftButton_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
		}

		private void alignCenterButton_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
		}

		private void alignRightButton_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
		}

		private void changeFontButton_Click(object sender, EventArgs e)
		{
			FontDialog dialog = new();
			dialog.Font = richTextBox1.SelectionFont;

			if (dialog.ShowDialog() == DialogResult.OK)
				richTextBox1.SelectionFont = dialog.Font;
		}

		private void saveFileButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new() { Filter = "RTF Files|*.rtf" };

			if (dialog.ShowDialog() == DialogResult.OK)
				richTextBox1.SaveFile(dialog.FileName);
		}

		private void loafFileButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new() { Filter = "RTF Files|*.rtf" };

			if (dialog.ShowDialog() == DialogResult.OK)
				richTextBox1.LoadFile(dialog.FileName);
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(richTextBox1.SelectedText);
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Text += Clipboard.GetText();
		}

		private void selectAlllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectAll();
		}

		private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.DeselectAll();
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectedText = "";
		}
	}
}