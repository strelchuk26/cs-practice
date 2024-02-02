using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threads
{
	public partial class Form2 : Form
	{
		Random r = new Random();
		List<int> numbers = new List<int>();
        public int Max { get; set; }
        public int Min { get; set; }
        public float Avg { get; set; }

        public Form2()
		{
			InitializeComponent();
		}

		private void FillNumbers()
		{
			for (int i = 0; i < 10000; i++)
				lock (this)
					numbers.Add(r.Next());
		}

		private void GetMax()
		{ 
			foreach (var num in numbers)
				lock (this)
					Max = Math.Max(Max, num);
		}

		private void GetMin()
		{
			foreach (var num in numbers)
				lock (this)
					Min = Math.Min(Min, num);
		}

		private void GetAvg()
		{
			int sum = 0;
			foreach (var num in numbers)
				lock (this)
					sum += num;

			Avg = sum / numbers.Count;
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			Thread thread1 = new Thread(FillNumbers);
			thread1.Start();

			Thread thread2 = new Thread(GetMax);
			thread2.Start();

			Thread thread3 = new Thread(GetMin);
			thread3.Start();

			Thread thread4 = new Thread(GetAvg);
			thread4.Start();

			maxLabel.Text = Max.ToString();
			minLabel.Text = Min.ToString();
			avgLabel.Text = Avg.ToString();
		}
	}
}
