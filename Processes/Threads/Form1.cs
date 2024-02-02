using System;

namespace Threads
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Update()
		{
			int start = (int)startNum.Value;
			int end = (int)endNum.Value;
			int num = 0;

			for (int i = start; i < end + 1; i++)
			{
				lock (this)
				{
					listBox1.Invoke(() => listBox1.Items.Add(num));
					num++;
				}
			}
		}

		private void StartButtonClick(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			int count = (int)threadsCount.Value;

			Thread[] threads = new Thread[count];

			for (int i = 0; i < threads.Length; i++)
			{
				threads[i] = new Thread(Update);
				threads[i].Start();
			}
		}
	}
}