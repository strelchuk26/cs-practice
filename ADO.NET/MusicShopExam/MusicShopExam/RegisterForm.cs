using MusicShopExam.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicShopExam
{
	public partial class RegisterForm : Form
	{
		MusicShopDbContext context = new MusicShopDbContext();
		public RegisterForm()
		{
			InitializeComponent();
		}

		private void registerButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(loginTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text))
			{
				MessageBox.Show("Enter correct data!");
				return;
			}

			Client client = new()
			{
				Login = loginTextBox.Text,
				Password = passwordTextBox.Text,
				TotalAmount = 0
			};

			context.Clients.Add(client);
			context.SaveChanges();

			Form1 form = new Form1();
			this.Hide();
			form.ShowDialog();
			this.Close();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			registerButton.Enabled = checkBox1.Checked;
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			this.Hide();
			form.ShowDialog();
			this.Close();
		}
	}
}
