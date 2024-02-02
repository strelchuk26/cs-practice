namespace text_editor
{
	public partial class Form1 : Form
	{
		public string copyText { get; set; }
		public Form1()
		{
			InitializeComponent();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new() { Filter = "Text Files|*.txt" };
			dialog.DefaultExt = ".txt";

			if (dialog.ShowDialog() == DialogResult.OK)
				File.WriteAllText(dialog.FileName, textBox1.Text);
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new() { Filter = "Text Files|*.txt" };

			if (dialog.ShowDialog() == DialogResult.OK)
				textBox1.Text = File.ReadAllText(dialog.FileName);
		}

		private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new();

			if (dialog.ShowDialog() == DialogResult.OK)
				textBox1.ForeColor = dialog.Color;
		}

		private void changeBGColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new();

			if (dialog.ShowDialog() == DialogResult.OK)
				textBox1.BackColor = dialog.Color;
		}

		private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FontDialog dialog = new();
			dialog.Font = textBox1.Font;

			if (dialog.ShowDialog() == DialogResult.OK)
				textBox1.Font = dialog.Font;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			symbCountLabel.Text = textBox1.Text.Length.ToString();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			copyText = textBox1.Text;
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.Text = copyText;
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.SelectAll();
		}

		private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox1.DeselectAll();
		}
	}
}