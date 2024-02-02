using Newtonsoft.Json;
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

namespace car_list
{
	public partial class Form1 : Form
	{
		List<Car> cars = new List<Car>();
		List<Brand> brands = new List<Brand>();
		List<Model> models = new List<Model>();
		List<string> colors = new List<string>();

		public Form1()
		{
			InitializeComponent();
			SetBrandsList();
			SetColorsList();
			UpdateCarsListBox();
			UpdateBrandComboBox();
			UpdateModelsComboBox();
			UpdateColorComboBox();
			UpdateSelectCarComboBox();
		}

		private void SetBrandsList()
		{
			var json = File.ReadAllText(@"models.json");
			brands = JsonConvert.DeserializeObject<List<Brand>>(json);
		}

		private void SetColorsList()
		{
			string[] lines = File.ReadAllLines("colors.txt");

			foreach (var line in lines)
				colors.Add(line);
		}

		private void UpdateCarsListBox()
		{
			carsListBox.DataSource = null;
			carsListBox.DataSource = cars;
		}

		private void UpdateBrandComboBox()
		{
			brandComboBox.DataSource = null;
			brandComboBox.DataSource = brands;
		}

		private void UpdateModelsComboBox()
		{
			modelComboBox.DataSource = null;
			models.Clear();

			foreach (var brand in brands)
			{
				if (brand.title == brandComboBox.Text)
				{
					foreach (var model in brand.models)
					{
						models.Add(model);
					}
				}
			}

			modelComboBox.DataSource = models;
		}

		private void UpdateColorComboBox()
		{
			colorComboBox.DataSource = null;
			colorComboBox.DataSource = colors;
		}

		private void UpdateSelectCarComboBox()
		{
			selectCarComboBox.DataSource = null;
			selectCarComboBox.DataSource = cars;
		}

		private bool ValidateInputs()
		{
			bool flag = false;
			if (string.IsNullOrWhiteSpace(brandComboBox.Text) ||
				string.IsNullOrWhiteSpace(modelComboBox.Text) ||
				string.IsNullOrWhiteSpace(colorComboBox.Text) ||
				string.IsNullOrWhiteSpace(numberMaskedTextBox.Text) ||
				string.IsNullOrWhiteSpace(vinNumTextBox.Text))
				flag = false;
			else
				flag = true;

			return flag;
		}

		private void addCarButton_Click(object sender, EventArgs e)
		{
			if (ValidateInputs() == false)
			{
				MessageBox.Show("Enter valid data!");
				return;
			}

			cars.Add
			(
				new Car
				{
					Brand = brandComboBox.Text,
					Model = modelComboBox.Text,
					Color = colorComboBox.Text,
					Year = (int)yearNumeric.Value,
					Number = numberMaskedTextBox.Text,
					VinNumber = vinNumTextBox.Text
				}
			);
			UpdateCarsListBox();
			UpdateSelectCarComboBox();
		}

		private void deleteCarButton_Click(object sender, EventArgs e)
		{
			var car = selectCarComboBox.SelectedItem as Car;

			cars.Remove(car);
			UpdateCarsListBox();
			UpdateSelectCarComboBox();
		}

		private void showCarInfoButton_Click(object sender, EventArgs e)
		{
			if (selectCarComboBox.SelectedItem == null)
			{
				MessageBox.Show("Select car to show!");
				return;
			}

			Car car = selectCarComboBox.SelectedItem as Car;

			MessageBox.Show(
				$"{car.Brand} {car.Model}\n" +
				$"{car.Color}\n" +
				$"{car.Year}\n" +
				$"{car.Number}\n" +
				$"{car.VinNumber}", "Car info", MessageBoxButtons.OK, MessageBoxIcon.Information
			);
		}

		private void carsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectCarComboBox.SelectedItem = carsListBox.SelectedItem;
		}

		private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateModelsComboBox();
		}
	}
}
