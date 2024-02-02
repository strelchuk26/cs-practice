using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_forms
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }
		List<Country> countries = new List<Country>();

		public ProductForm(string mode)
        {
            InitializeComponent();
            UpdateCountryList();
			label1.Text = mode;
            Product = new Product();
        }

		private void UpdateCountryList()
		{
            countryComboBox.DataSource = null;

            string[] lines = File.ReadAllLines(@"countries.txt");

            foreach (string line in lines)
                countries.Add(new Country {Name = line});

            countryComboBox.DataSource = countries;
		}

		public ProductForm(string mode, Product product)
        {
            InitializeComponent();
            UpdateCountryList();
			label1.Text = mode;
            Product = product;
            UpdateInputs(Product);
        }

        private void UpdateInputs(Product product)
        {
            nameTextBox.Text = product.Name;
            priceNum.Value = product.Price;
            countNum.Value = product.Count;
            countryComboBox.Text = product.Country;
            discountNum.Value = product.Discount;
        }

        public void ShowMode(Product product)
        {
            UpdateInputs(product);

            nameTextBox.Enabled = false;
            priceNum.Enabled = false;
            countNum.Enabled = false;
            countryComboBox.Enabled = false;
            discountNum.Enabled = false;
            this.ShowDialog();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            Product.Name = nameTextBox.Text;
            Product.Price = (int)priceNum.Value;
            Product.Count = (int)countNum.Value;
            Product.Country = countryComboBox.Text;
            Product.Discount = (int)discountNum.Value;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
