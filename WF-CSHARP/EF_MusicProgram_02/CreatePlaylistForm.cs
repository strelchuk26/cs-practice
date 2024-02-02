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
	public partial class CreatePlaylistForm : Form
	{
		public Playlist Playlist { get; set; }
		List<Track> tracks = new List<Track>();

		public CreatePlaylistForm()
		{
			InitializeComponent();
		}

		private void UpdateTrackList()
		{
			tracksListBox.DataSource = null;
			tracksListBox.DataSource = tracks;
		}

		private void addTrackButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(playlistNameTextBox.Text))
			{
				MessageBox.Show("Enter valid data!");
				return;
			}

			Playlist = new Playlist()
			{
				Name = playlistNameTextBox.Text,
				Tracks = null
			};

			AddTrackForm form = new AddTrackForm(Playlist);

			if (form.ShowDialog() == DialogResult.OK)
			{
				tracks.Add(form.Track);
			}

			UpdateTrackList();
		}

		private void deleteTrackButton_Click(object sender, EventArgs e)
		{
			if (tracksListBox.SelectedItem == null)
			{
				MessageBox.Show("No tracks selected!");
				return;
			}

			var item = tracksListBox.SelectedItem as Track;
			tracks.Remove(item);

			UpdateTrackList();
		}

		private void createPlaylistButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(playlistNameTextBox.Text) || tracksListBox.Items.Count == 0)
			{
				MessageBox.Show("Enter valid data!");
				return;
			}

			DialogResult = DialogResult.OK;

			Playlist = new Playlist()
			{
				Name = playlistNameTextBox.Text,
				Tracks = tracks
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
