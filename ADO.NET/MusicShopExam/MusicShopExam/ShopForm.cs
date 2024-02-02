using Microsoft.EntityFrameworkCore;
using MusicShopExam.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicShopExam
{
	public partial class ShopForm : Form
	{
		MusicShopDbContext context = new MusicShopDbContext();
		public Client CurrentClient { get; set; } = null;
		public List<Sale> Sales { get; set; }

		public ShopForm()
		{
			InitializeComponent();
			UpdatePlatesList("Id");
		}

		public ShopForm(Client curr_client)
		{
			InitializeComponent();
			UpdatePlatesList("Id");
			CurrentClient = curr_client;
			loginLabel.Text = CurrentClient.Login;
			amountLabel.Text = CurrentClient.TotalAmount.ToString();
		}

		private void UpdatePlatesList(string filter)
		{
			itemsListBox.Items.Clear();
			IOrderedQueryable<AvailablePlate> availablePlates = null;

			switch (filter)
			{
				case "Id":
					availablePlates = context.AvailablePlates.Include(x => x.Genre).Include(x => x.Publisher).OrderBy(x => x.Id);
					break;
				case "Name":
					availablePlates = context.AvailablePlates.Include(x => x.Genre).Include(x => x.Publisher).OrderBy(x => x.Name);
					break;
				case "Genre":
					availablePlates = context.AvailablePlates.Include(x => x.Genre).Include(x => x.Publisher).OrderBy(x => x.Genre);
					break;
				case "Publisher":
					availablePlates = context.AvailablePlates.Include(x => x.Genre).Include(x => x.Publisher).OrderBy(x => x.Publisher);
					break;
				case "Tracks Count":
					availablePlates = context.AvailablePlates.Include(x => x.Genre).Include(x => x.Publisher).OrderBy(x => x.TracksCount);
					break;
				default:
					break;
			}

			foreach (var p in availablePlates)
			{
				itemsListBox.Items.Add(new AvailablePlate()
				{
					Id = p.Id,
					Name = p.Name,
					Year = p.Year,
					Price = p.Price,
					TracksCount = p.TracksCount,
					Genre = new Genre { Name = p.Genre.Name },
					Publisher = new Publisher { Name = p.Publisher.Name }
				});
			}
		}

		private void buyButtonClick(object sender, EventArgs e)
		{
			if (itemsListBox.SelectedItems.Count == 0) return;
			var plate = itemsListBox.SelectedItems[0] as AvailablePlate;

			var newSale = new Sale
			{
				Amount = plate.Price,
				SaleDate = DateTime.Now.ToString(),
				PlateId = plate.Id,
				ClientId = CurrentClient.Id
			};

			context.Sales.Add(newSale);
			context.AvailablePlates.Remove(plate);
			context.SaveChanges();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var filter = comboBox1.SelectedItem as string;
			UpdatePlatesList(filter);
		}
	}
}
