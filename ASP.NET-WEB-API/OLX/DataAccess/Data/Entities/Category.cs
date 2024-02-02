﻿namespace DataAccess.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Advert> Adverts { get; set; }
    }
}
