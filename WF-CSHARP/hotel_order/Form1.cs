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

namespace hotel_order
{
	public partial class Form1 : Form
	{

		public class Room
		{
			public string Name { get; set; }
			public string Address { get; set; }
			public string Phone { get; set; }
			public int PeopleCount { get; set; }
			public string RoomType { get; set; }
			public string SpecialNotes { get; set; }
			public string Date { get; set; }
		}

		public string TypeOfRoom { get; set; }

		public Form1()
		{
			InitializeComponent();
			dateTimePicker1.MinDate = DateTime.Now;
		}

		public void CheckTypeOfRoom()
		{
			if (economRadioBtn.Checked)
				TypeOfRoom = "Econom";
			else if (standartRadioBtn.Checked)
				TypeOfRoom = "Standart";
			else if (luxRadioBtn.Checked)
				TypeOfRoom = "Lux";
			else
				TypeOfRoom = "typeNotSelected";
		}

		private void rentButton_Click(object sender, EventArgs e)
		{
			CheckTypeOfRoom();

			MessageBox.Show(
				$"Name: {nameTextBox.Text}\n" +
				$"Address: {addressTextBox.Text}\n" +
				$"Phone: {phoneNumberTextBox.Text}\n" +
				$"Count of people: {peopleCount.Value}\n" +
				$"Room type: {TypeOfRoom}\n" +
				$"Special notes: {specialNotesTextBox.Text}\n" +
				$"Date: {dateTimePicker1.Value}");
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			nameTextBox.Clear();
			addressTextBox.Clear();
			phoneNumberTextBox.Clear();
			peopleCount.Value = 0;
			economRadioBtn.Checked = false;
			standartRadioBtn.Checked = false;
			luxRadioBtn.Checked = false;
			specialNotesTextBox.Clear();
			dateTimePicker1.Value = DateTime.Now;
			termsCheckBox.Checked = false;
		}

		private void termsCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (termsCheckBox.Checked)
				rentButton.Enabled = true;
			else
				rentButton.Enabled = false;
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			CheckTypeOfRoom();

			Room room = new Room()
			{
				Name = nameTextBox.Text,
				Address = addressTextBox.Text,
				Phone = phoneNumberTextBox.Text,
				PeopleCount = (int)peopleCount.Value,
				RoomType = TypeOfRoom,
				SpecialNotes = specialNotesTextBox.Text,
				Date = dateTimePicker1.Value.ToString()
			};

			try
			{
				string jsonString = JsonSerializer.Serialize(room);
				File.WriteAllText("room.json", jsonString);
				MessageBox.Show("File saved!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void loadBtn_Click(object sender, EventArgs e)
		{
			try
			{
				string jsonString = File.ReadAllText("room.json");
				Room room = JsonSerializer.Deserialize<Room>(jsonString);

				nameTextBox.Text = room.Name;
				addressTextBox.Text = room.Address;
				phoneNumberTextBox.Text = room.Phone;
				peopleCount.Value = (int)room.PeopleCount;
				if (room.RoomType == "Econom")
					economRadioBtn.Checked = true;
				else if (room.RoomType == "Standart")
					standartRadioBtn.Checked = true;
				else if (room.RoomType == "Lux")
					luxRadioBtn.Checked = true;
				specialNotesTextBox.Text = room.SpecialNotes;
				dateTimePicker1.Value = DateTime.Parse(room.Date);

				MessageBox.Show("File loaded!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
