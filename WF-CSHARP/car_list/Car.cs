using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_list
{
	internal class Car
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public int Year { get; set; }
		public string Number { get; set; }
		public string VinNumber { get; set; }

		public override string ToString()
		{
			return $"{Brand} {Model} {Year}";
		}
	}
}
