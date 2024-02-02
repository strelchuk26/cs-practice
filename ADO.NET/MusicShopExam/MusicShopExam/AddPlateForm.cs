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
	public partial class AddPlateForm : Form
	{
		MusicShopDbContext context = new MusicShopDbContext();
        public Plate Plate { get; set; }
        public AvailablePlate AvailablePlate { get; set; }

        public AddPlateForm()
		{
			InitializeComponent();
			LoadGenres();
		}

		private void LoadGenres()
		{
			foreach (var g in context.Genres)
			{
				genreComboBox.Items.Add(new Genre() { Id = g.Id, Name = g.Name });
			}
		}

		private void addPlateButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(publisherTextBox.Text) || genreComboBox.SelectedItem == null)
			{
				MessageBox.Show("Enter correct data!");
				return;
			}

			var genre = genreComboBox.SelectedItem as Genre;

			Plate = new Plate()
			{ 
				Name = nameTextBox.Text,
				Year = (int)yearNum.Value,
				Price = (int)priceNum.Value,
				TracksCount = (int)treacksCountNum.Value,
				Publisher = new Publisher() { Name = publisherTextBox.Text },
				Genre = new Genre() {Name = genre.Name}
			};

			AvailablePlate = new AvailablePlate()
			{
				Name = nameTextBox.Text,
				Year = (int)yearNum.Value,
				Price = (int)priceNum.Value,
				TracksCount = (int)treacksCountNum.Value,
				Publisher = new Publisher() { Name = publisherTextBox.Text },
				Genre = new Genre() { Name = genre.Name }
			};

			this.Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
