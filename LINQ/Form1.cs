using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace LINQ
{
	public partial class Form1 : Form
	{
		List<int> numbers = new List<int>();
		List<int> years = new List<int>();
		List<string> words = new List<string>();
		public Form1()
		{
			InitializeComponent();
			numbers.AddRange(new[]
			{
				1, 5, 72, 0, -1, 21,-5,4,0,2,5,61,4,-5,36,48,20,1249,43,24,2434,2
			});

			years.AddRange(new[]
			{
				1945, 1978, 2002, 1959, 1986, 2010, 1967, 1992, 1932, 2018
			});

			words.AddRange(new[]
			{
				"elephant", "rainbow", "chemistry", "guitar", "pineapple", "astronaut", "compass", "kangaroo", "universe", "volleyball"
			});

			listBox1.DataSource = numbers;
		}
		private void resetButton_Click(object sender, EventArgs e)
		{
			listBox1.DataSource = null;
			listBox1.DataSource = numbers;
		}

		// task 1
		private void task1Button_Click(object sender, EventArgs e)
		{
			listBox1.DataSource = null;
			listBox1.DataSource = numbers.Where(x => x > 0).OrderBy(x => x).ToList();
		}

		// task 2
		private void task2Button_Click(object sender, EventArgs e)
		{
			listBox1.DataSource = null;
			var positive_two_digit = numbers.Where(x => x > 0 && x > 10 && x < 100).ToList();

			var avg = positive_two_digit.Average();

			MessageBox.Show($"Count: {positive_two_digit.Count()}\n" +
							$"Average: {avg}");
		}

		// task 3
		private void task3Button_Click(object sender, EventArgs e)
		{
			listBox1.DataSource = null;
			var leap_years = years.Where(x => DateTime.IsLeapYear(x)).OrderByDescending(x => x).ToList();

			listBox1.DataSource = leap_years;
		}

		// task 4

		private bool IsEven(int num)
		{ 
			return num % 2 == 0;
		}

		private void task4Button_Click(object sender, EventArgs e)
		{
			listBox1.DataSource = null;
			var even = numbers.Where(IsEven).ToList();
			var max = even.Max();

			listBox1.Items.Add(max);
		}

		// task 5
		private void task5Button_Click(object sender, EventArgs e)
		{
			listBox1.DataSource = null;
			var strings = words.Select(x => x + "!!!").ToList();

			listBox1.DataSource = strings;
		}

		// task 6
		private void task6Button_Click(object sender, EventArgs e)
		{
			listBox1.DataSource = null;
			char s = 'a';
			var strings = words.Where(x => x.Contains(s)).ToList();

			listBox1.DataSource = strings;
		}

		// task 7
		private void task7Button_Click(object sender, EventArgs e)
		{
			listBox1.DataSource = null;
			var string_groups = words.GroupBy(x => x.Length);

			foreach (var g in string_groups)
			{
				listBox1.Items.Add(g.Key.ToString());
			}
		}
	}
}
