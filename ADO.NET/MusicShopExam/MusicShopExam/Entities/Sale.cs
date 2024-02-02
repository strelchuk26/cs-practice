using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopExam.Entities
{
	public class Sale
	{
		public int Id { get; set; }
        public int PlateId { get; set; }
        public int ClientId { get; set; }
        public double Amount { get; set; }
		public string SaleDate { get; set; }
        public Plate Plate { get; set; }
        public Client Client { get; set; }

		public override string ToString() => $"{PlateId} {ClientId} {Amount} {SaleDate}";
	}
}
