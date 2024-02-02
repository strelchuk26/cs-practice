using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_list
{
	internal class Brand
	{
		public string value { get; set; }
		public string title { get; set; }
		public List<Model> models { get; set; }

		public override string ToString()
		{
			return title;
		}
	}
}
