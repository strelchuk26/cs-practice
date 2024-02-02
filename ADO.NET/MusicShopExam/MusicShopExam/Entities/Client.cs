using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopExam.Entities
{
	public class Client
	{
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public double TotalAmount { get; set; }
        public ICollection<Sale> Sales { get; set; }

		public override string ToString() => $"{Login} {Password} {TotalAmount}";
	}
}
