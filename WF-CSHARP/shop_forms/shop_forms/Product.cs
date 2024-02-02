using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_forms
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Country { get; set; }
        public int Count { get; set; }
        public int Discount { get; set; }

        public override string ToString()
        {
            return $"{Name} {Price}UAH {Country} {Count} {Discount}%";
        }
    }
}
