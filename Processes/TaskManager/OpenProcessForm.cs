using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
	public partial class OpenProcessForm : Form
	{
		public string Path { get; set; }
		public OpenProcessForm()
		{
			InitializeComponent();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			Path = textBox1.Text;

			if (string.IsNullOrWhiteSpace(Path))
			{
				MessageBox.Show("Enter correct path!");
				return;
			}

			try
			{
				Process.Start(Path);
			}
			catch (Exception)
			{
				throw;
			}

			this.Close();
		}
	}
}
