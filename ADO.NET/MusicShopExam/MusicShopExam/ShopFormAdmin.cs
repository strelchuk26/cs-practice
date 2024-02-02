using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
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
	public partial class ShopFormAdmin : Form
	{
		MusicShopDbContext context = new MusicShopDbContext();

		public ShopFormAdmin()
		{
			InitializeComponent();
			UpdatePlatesList();
		}

		private void UpdatePlatesList()
		{
			itemsListBox.Items.Clear();
			var availablePlates = context.AvailablePlates.Include(x => x.Genre).Include(x => x.Publisher);

			foreach (var p in availablePlates)
			{
				itemsListBox.Items.Add(new AvailablePlate()
				{
					Id = p.Id,
					Name = p.Name,
					Year = p.Year,
					Price = p.Price,
					TracksCount = p.TracksCount,
					Genre = new Genre { Id = p.Genre.Id, Name = p.Genre.Name },
					Publisher = new Publisher { Id = p.Publisher.Id, Name = p.Publisher.Name }
				});
			}
		}

		private void addPlateButton_Click(object sender, EventArgs e)
		{
			AddPlateForm form = new AddPlateForm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				var plate = new Plate()
				{
					Name = form.Plate.Name,
					Year = form.Plate.Year,
					Price = form.Plate.Price,
					TracksCount = form.Plate.TracksCount,
					Publisher = form.Plate.Publisher,
					Genre = form.Plate.Genre
				};

				var availablePlate = new AvailablePlate()
				{
					Name = form.Plate.Name,
					Year = form.Plate.Year,
					Price = form.Plate.Price,
					TracksCount = form.Plate.TracksCount,
					Publisher = form.Plate.Publisher,
					Genre = form.Plate.Genre
				};

				context.Plates.Add(plate);
				context.AvailablePlates.Add(availablePlate);
				context.SaveChanges();
				UpdatePlatesList();
			}
		}

		private void deletePlateButton_Click(object sender, EventArgs e)
		{
			if (itemsListBox.SelectedItems.Count == 0) return;
			var item = itemsListBox.SelectedItems[0] as AvailablePlate;
			if (item == null) return;

			context.AvailablePlates.Remove(item);
			context.SaveChanges();
			UpdatePlatesList();
		}
	}
}
