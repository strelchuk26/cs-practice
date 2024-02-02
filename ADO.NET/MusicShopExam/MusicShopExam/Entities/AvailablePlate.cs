using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopExam.Entities
{
	public class AvailablePlate
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Year { get; set; }
		public int Price { get; set; }
		public int TracksCount { get; set; }
		public Genre Genre { get; set; }
		public Publisher Publisher { get; set; }
		public ICollection<Sale> Sales { get; set; }

		public override string ToString() => $"[{Id}] {Name} {Year} {Price} {TracksCount} {Genre.Name} {Publisher.Name}";
	}
}
