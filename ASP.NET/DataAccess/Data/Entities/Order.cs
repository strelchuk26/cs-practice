﻿using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }
        public string BuyerId { get; set; }
        public int AdvertId { get; set; }
        public int Price { get; set; }
        public User User { get; set; }
        public ICollection<Advert> Adverts { get; set; }
    }
}