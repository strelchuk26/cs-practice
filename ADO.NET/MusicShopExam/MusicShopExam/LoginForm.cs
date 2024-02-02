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
	public partial class LoginForm : Form
	{
		MusicShopDbContext context = new MusicShopDbContext();
		List<Client> clients = new List<Client>();

		public LoginForm()
		{
			InitializeComponent();
			LoadClients();
		}

		private void LoadClients()
		{
			foreach (var c in context.Clients)
			{
				clients.Add(new Client()
				{
					Id = c.Id,
					Login = c.Login,
					Password = c.Password
				});
			}
		}

		private Client FindClient(string login, string password)
		{
			var new_client = new Client();
			new_client = null;
			foreach (var c in context.Clients)
			{
				if (c.Login == login && c.Password == password)
				{
					new_client = new Client()
					{
						Id = c.Id,
						Login = c.Login,
						Password = c.Password,
						TotalAmount = c.TotalAmount,
						Sales = null                    // ДОРОБИТИ!!!!
					};
				}
			}
			return new_client;
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			var login = loginTextBox.Text;
			var password = passwordTextBox.Text;

			if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
			{
				MessageBox.Show("Enter correct data!");
				return;
			}

			if (login == "admin" && password == "admin")
			{
				ShopFormAdmin form = new ShopFormAdmin();
				this.Hide();
				form.ShowDialog();
				this.Close();
				return;
			}

			var new_client = FindClient(login, password);
			if (new_client != null)
			{
				ShopForm form = new ShopForm(new_client);
				this.Hide();
				form.ShowDialog();
				this.Close();
			}
			else
			{
				MessageBox.Show("Incorrect login or password!");
				return;
			}
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
