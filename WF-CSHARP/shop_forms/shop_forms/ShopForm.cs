using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_forms
{
    public partial class ShopForm : Form
    {
        List<Product> products = new List<Product>();

        public ShopForm()
        {
            InitializeComponent();
        }

		private void UpdateList()
        {
            productsList.DataSource = null;
            productsList.DataSource = products;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm("ADD");
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                products.Add(form.Product);
                UpdateList();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (productsList.SelectedItem == null!)
            {
                MessageBox.Show("Select product to remove!");
                return;
            }

            var item = productsList.SelectedItem as Product;

            products.Remove(item);
            UpdateList();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (productsList.SelectedItem == null!)
            {
                MessageBox.Show("Select product to edit!");
                return;
            }

            var product = productsList.SelectedItem as Product;
            ProductForm form = new ProductForm("EDIT", product);

            form.ShowDialog();
            UpdateList();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm("SHOW");
            var product = productsList.SelectedItem as Product;
            form.ShowMode(product);
        }

        private void changeBgButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new();
            dialog.Color = this.BackColor;

            if (dialog.ShowDialog() == DialogResult.OK)
                this.BackColor = dialog.Color;
        }

        private void changeFontButton_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new();
            dialog.Font = productsList.Font;

            if (dialog.ShowDialog() == DialogResult.OK)
                productsList.Font = dialog.Font;
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            if (productsList.Items.Count == 0)
            {
                MessageBox.Show("List of products is empty!");
                return;
            }

            SaveFileDialog dialog = new();
            dialog.DefaultExt = ".json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
				var items = JsonConvert.SerializeObject(products);
                File.WriteAllText(dialog.FileName, items);
			}
        }

        private void loadListButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.Filter = "JSON Files|*.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var json = File.ReadAllText(dialog.FileName);
                products = JsonConvert.DeserializeObject<List<Product>>(json);
                UpdateList();
			}
        }
    }
}
