using System.Diagnostics;
using System.Windows.Forms;
using tree_list;

namespace _11_tree_list_view
{
	public partial class Form1 : Form
	{
		string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		public Form1()
		{
			InitializeComponent();

			LoadDirectories(userProfilePath, treeView1.Nodes);
		}

		private void LoadDirectories(string root, TreeNodeCollection nodes)
		{
			try
			{
				treeView1.Nodes.Clear();
				var dirInfo = new DirectoryInfo(root);

				foreach (var d in dirInfo.GetDirectories())
				{
					TreeNode node = new TreeNode(d.Name);
					node.Tag = d.FullName;
					LoadDirectories(d.FullName, node.Nodes);
					nodes.Add(node);
				}
			}
			catch { }
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (treeView1.SelectedNode == null) return;

			var node = treeView1.SelectedNode;

			if (node.Tag == null) return;

			DirectoryInfo dir = new(node.Tag.ToString());

			listView1.Items.Clear();
			foreach (var f in dir.GetFiles())
			{
				ListViewItem item = new(f.Name, 0);

				item.SubItems.Add(Path.GetExtension(f.Name));
				item.SubItems.Add($"{Math.Round(f.Length / 1024.0, 2, MidpointRounding.ToEven)} KB");

				item.Tag = f.FullName;
				listView1.Items.Add(item);
			}
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//if (listView1.SelectedItems.Count == 0) return;

			//var path = listView1.SelectedItems[0].Tag.ToString();

			////MessageBox.Show(path);

			//// open file: Process.Start(path);
		}

		private void createNewFolderButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				DirectoryInfo dirInfo = new(dialog.FileName);
				dirInfo.Create();

				LoadDirectories(userProfilePath, treeView1.Nodes);
			}
		}

		private void deleteFileButton_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count == 0) return;
			var item = listView1.SelectedItems[0];

			File.Delete(item.Tag.ToString());
			listView1.Items.Remove(item);

			LoadDirectories(userProfilePath, treeView1.Nodes);
		}

		private void copyFileButton_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count == 0) return;
			var path = listView1.SelectedItems[0].Tag.ToString();

			var file = new FileInfo(path);
			File.Move(file.Name, "Copy" + file.Name);
		}

		private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listView1.View = View.Details;
		}

		private void tileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listView1.View = View.Tile;
			trackBar1.Enabled = true;
		}

		private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listView1.View = View.LargeIcon;
		}

		private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listView1.View = View.SmallIcon;
		}

		private void listToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listView1.View = View.List;
		}

		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count == 0) return;

			var path = listView1.SelectedItems[0].Tag.ToString();
			Process.Start(path);
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			var size = trackBar1.Value;

			switch (size)
			{
				case 0:
					listView1.TileSize = new(150, 30);
					break;
				case 1:
					listView1.TileSize = new(200, 40);
					break;
				case 2:
					listView1.TileSize = new(250, 50);
					break;
				case 3:
					listView1.TileSize = new(300, 55);
					break;
				case 4:
					listView1.TileSize = new(350, 60);
					break;
				default:
					break;
			}
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems[0] == null || string.IsNullOrWhiteSpace(renameTextBox.Text))
				return;
			
			var item = listView1.SelectedItems[0];
			var text = renameTextBox.Text;

			Directory.Move(item.Text, text);
		}
	}
}
