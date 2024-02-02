using System.Diagnostics;

namespace TaskManager
{
	public partial class Form1 : Form
	{
		private int interval = 100000;
		public Form1()
		{
			InitializeComponent();
			Thread thread = new Thread(UpdateProcesses);
			thread.Start();
		}

		private void UpdateProcesses()
		{
			while (true)
			{
				var list = Process.GetProcesses().Select(x => new ProcessViewModel(x)).ToList();
				dataGridView1.Invoke(new Action(() => { dataGridView1.DataSource = list; }));
				Thread.Sleep(interval);
			}
		}

		private void refreshListButton_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(UpdateProcesses);
			thread.Start();
		}

		class ProcessViewModel
		{
			public int PID { get; set; }
			public string Name { get; set; }
			public string Priority { get; set; }
			public long Memory { get; set; }
			public string ProcessStartTime { get; set; }

			public ProcessViewModel(Process x)
			{
				try
				{
					PID = x.Id;
					Name = x.ProcessName;
					Priority = x.PriorityClass.ToString();
					Memory = x.PrivateMemorySize64 / 1024;
					ProcessStartTime = x.StartTime.ToString();
				}
				catch { }
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var value = comboBox1.SelectedItem as string;
			Thread thread = new Thread(UpdateProcesses);

			switch (value)
			{
				case "1":
					interval = 1000;
					thread.Start();
					break;
				case "2":
					interval = 2000;
					thread.Start();
					break;
				case "5":
					interval = 5000;
					thread.Start();
					break;
				default:
					break;
			}
		}

		private void openProcessButton_Click(object sender, EventArgs e)
		{
			OpenProcessForm form = new OpenProcessForm();
			form.ShowDialog();
		}
	}
}