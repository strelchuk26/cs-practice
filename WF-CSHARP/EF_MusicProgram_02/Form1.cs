using EF_MusicProgram.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_MusicProgram
{
	public partial class Form1 : Form
	{
		MusicDbContext db = new MusicDbContext();
		List<Playlist> playlists = new List<Playlist>();
		List<Track> tracks = new List<Track>();

		public Form1()
		{
			InitializeComponent();
			FillPlaylistList();
			UpdatePlaylistList();
		}

		private void FillPlaylistList()
		{
			foreach (var p in db.Playlists)
			{
				playlists.Add
				(
					new Playlist()
					{
						Name = p.Name,
						Tracks = p.Tracks
					}
				);
			}
		}

		private void UpdatePlaylistList()
		{
			playlistListBox.DataSource = null;
			playlistListBox.DataSource = playlists;
		}

		private void createPlaylistButton_Click(object sender, EventArgs e)
		{
			CreatePlaylistForm form = new CreatePlaylistForm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				playlists.Add(form.Playlist);
				UpdatePlaylistList();
			}
		}

		private void playlistListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var playlist = playlistListBox.SelectedItem as Playlist;
			if (playlist == null || playlist.Tracks.Count == 0)
			{
				return;
			}

			playlistName.Text = playlist.Name;

			tracklistBox.DataSource = null;
			tracks.Clear();

			foreach (var t in playlist.Tracks)
			{
				tracks.Add(t);
			}

			tracklistBox.DataSource = tracks;
		}


		// TODO
		private void removeTrackButton_Click(object sender, EventArgs e)
		{
			var track = tracklistBox.SelectedItem as Track;
			if (track == null)
			{
				MessageBox.Show("Select track to delete!");
				return;
			}

			tracklistBox.DataSource = null;
			tracks.Clear();

			//foreach (var t in track.Playlist.Tracks)
			//{
			//	tracks.Add
			//		(
			//			new Track()
			//			{
			//				Name = t.Name,
			//				Genre = new Genre() { Name = t.Genre.Name },
			//				Duration = t.Duration,
			//				Performer = new Performer() { Name = t.Performer.Name },
			//				Playlist = t.Playlist
			//			}
			//		);
			//}

			tracklistBox.DataSource = tracks;
		}

		private void ShowTracksByAuditions()
		{
			var res = db.Tracks.Where(x => x.Auditions > 1000);
			MessageBox.Show(res.ToString());
		}

		private void ShowTopTracks()
		{
			var res = db.Tracks.Select(x => x).OrderByDescending(x => x.Rating).Take(3);
			MessageBox.Show(res.ToString());
		}
	}
}