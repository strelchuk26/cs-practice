using EF_MusicProgram.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_MusicProgram
{
	public partial class AddTrackForm : Form
	{
		public Track Track { get; set; }
		public Playlist TrackPlaylist { get; set; }

		public AddTrackForm()
		{
			InitializeComponent();
		}

		public AddTrackForm(Playlist playlist)
		{
			InitializeComponent();
			TrackPlaylist = new Playlist()
			{
				Name = playlist.Name
			};
		}

		private void addTrackButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(trackNameTextBox.Text) || trackDuration.Value == 0)
			{
				MessageBox.Show("Enter valid data!");
				return;
			}

			DialogResult = DialogResult.OK;

			Track = new Track()
			{
				Name = trackNameTextBox.Text,
				Duration = (int)trackDuration.Value,
				Performer = new Performer() { Name = performerTextBox.Text},
				Genre = new Genre() { Name = genreTextBox.Text },
				//Playlist = TrackPlaylist
			};

			this.Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
