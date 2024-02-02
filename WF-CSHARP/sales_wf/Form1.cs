using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sales_wf
{
	public partial class Form1 : Form
	{
		string connectionString = null;
		SqlConnection connection = null;
		SqlDataAdapter adapter = null;
		DataSet set = new DataSet();

		public Form1()
		{
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["SalesDb"].ConnectionString;
			connection = new SqlConnection(connectionString);
		}

		private void saveChangesButton_Click(object sender, EventArgs e)
		{
			adapter.Update(set);
		}

		private void chooseTableComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (chooseTableComboBox.SelectedIndex == -1)
				{
					MessageBox.Show("Select table!");
				}

				string table = chooseTableComboBox.Text;
				string command = null;

				if (table == "Sales")
					command = "select * from Sales";
				else if (table == "Sellers")
					command = "select * from Sellers";
				else if (table == "Buyers")
					command = "select * from Buyers";

				adapter = new SqlDataAdapter(command, connection);

				new SqlCommandBuilder(adapter);

				set.Clear();
				dataGridView1.DataSource = null;

				adapter.Fill(set);

				dataGridView1.DataSource = set.Tables[0];
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
