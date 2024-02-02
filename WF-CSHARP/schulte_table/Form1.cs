using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace schulte_table
{
	public partial class Form1 : Form
	{
		public int timeLeft { get; set; } = 60;
		public int gameTime { get; set; }
		private int index = 1;
		public Form1()
		{
			InitializeComponent();
		}

		public static void Shuffle<T>(IList<T> values)
		{
			Random random = new Random();
			for (int i = values.Count - 1; i > 0; i--)
			{
				int k = random.Next(i + 1);
				T value = values[k];
				values[k] = values[i];
				values[i] = value;
			}
		}

		private void ClearButtons()
		{
			foreach (var button in panel1.Controls.OfType<Button>())
			{
				button.BackColor = Color.FromArgb(225, 225, 225);
				button.Text = "X";
			}
		}

		private void SetComplexity(int value)
		{
			switch (value)
			{
				case 0:
					timeLeft = 60;
					toolStripStatusLabel2.Text = timeLeft.ToString();
					break;
				case 1:
					toolStripStatusLabel2.Text = timeLeft.ToString();
					timeLeft = 50;
					break;
				case 2:
					timeLeft = 40;
					toolStripStatusLabel2.Text = timeLeft.ToString();
					break;
				case 3:
					timeLeft = 30;
					toolStripStatusLabel2.Text = timeLeft.ToString();
					break;
				case 4:
					timeLeft = 20;
					toolStripStatusLabel2.Text = timeLeft.ToString();
					break;
				case 5:
					timeLeft = 10;
					toolStripStatusLabel2.Text = timeLeft.ToString();
					break;
				default:
					break;
			}
		}

		private void startButtonClick(object sender, EventArgs e)
		{
			List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16};
			Shuffle(numbers);
			ClearButtons();

			trackBar1.Enabled = false;

			int counter = 0;
			foreach (var button in panel1.Controls.OfType<Button>())
			{
				button.Text = numbers[counter].ToString();
				counter++;
			}

			timer1.Tick += timer1_Tick;
			timer1.Start();
		}

		private void buttonClick(object sender, EventArgs e)
		{
			var btn = (Button)sender;

			progressBar1.Value = index;
			if (index == 16)
			{
				timer1.Stop();
				toolStripStatusLabel2.Text = timeLeft.ToString();
				progressBar1.Value = 0;
				trackBar1.Enabled = true;
				btn.BackColor = Color.FromArgb(46, 204, 113);
				MessageBox.Show($"You win!\n" +
								$"Time elapsed: {gameTime} seconds!");
				index = 1;
				ClearButtons();
			}

			else if (btn.Text == index.ToString())
			{
				btn.BackColor = Color.FromArgb(46, 204, 113);
				index++;
			}
		}
		
		private void timer1_Tick(object sender, EventArgs e)
		{
			toolStripStatusLabel2.Text = timeLeft.ToString();
			timeLeft--;
			gameTime++;
			if (timeLeft <= 0)
			{
				timer1.Stop();
				SetComplexity(trackBar1.Value);
				progressBar1.Value = 0;
				gameTime = 0;
				trackBar1.Enabled = true;
				MessageBox.Show("You loose!(");
				ClearButtons();
			}
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			SetComplexity(trackBar1.Value);
		}
	}
}
