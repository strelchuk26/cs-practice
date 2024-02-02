using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
	internal class ProcessViewModel
	{
		public int PID { get; set; }
		public string Name { get; set; }
		public string Priority { get; set; }
		public long Memory { get; set; }
        public bool Responding { get; set; }
        public DateTime StartTime { get; set; }

        public ProcessViewModel(Process x)
		{
			try
			{
				PID = x.Id;
				Name = x.ProcessName;
				Priority = x.PriorityClass.ToString();
				Memory = x.PrivateMemorySize64 / 1024;
				Responding = x.Responding;
				StartTime = x.StartTime;
			}
			catch { }
		}
	}
}
