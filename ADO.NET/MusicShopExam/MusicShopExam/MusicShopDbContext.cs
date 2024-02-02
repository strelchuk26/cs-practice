using Microsoft.EntityFrameworkCore;
using MusicShopExam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopExam
{
	internal class MusicShopDbContext : DbContext
	{
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Plate>().HasOne(x => x.Genre).WithMany(x => x.Plates);
			modelBuilder.Entity<Plate>().HasOne(x => x.Publisher).WithMany(x => x.Plates);
			modelBuilder.Entity<AvailablePlate>().HasOne(x => x.Genre).WithMany(x => x.AvailablePlates);
			modelBuilder.Entity<AvailablePlate>().HasOne(x => x.Publisher).WithMany(x => x.AvailablePlates);
			modelBuilder.Entity<Sale>().HasOne(x => x.Client).WithMany(x => x.Sales).HasForeignKey(x => x.ClientId);
			modelBuilder.Entity<Sale>().HasOne(x => x.Plate).WithMany(x => x.Sales).HasForeignKey(x => x.PlateId);

			modelBuilder.Entity<Genre>().HasData(new[] 
			{
				new Genre() { Id = 1, Name = "Jazz"},
				new Genre() { Id = 2, Name = "Pop"},
				new Genre() { Id = 3, Name = "Hip-Hop"},
				new Genre() { Id = 4, Name = "Rock"},
				new Genre() { Id = 5, Name = "Funk"},
				new Genre() { Id = 6, Name = "Disco"},
				new Genre() { Id = 7, Name = "Electronic"},
				new Genre() { Id = 8, Name = "Dubstep"},
				new Genre() { Id = 9, Name = "Phonk"}
			});

			modelBuilder.Entity<Client>().HasData(new[]
			{
				new Client() { Id = 1, Login = "user1", Password = "1234", TotalAmount = 132.0},
				new Client() { Id = 2, Login = "superUser", Password = "qwerty1234", TotalAmount = 572.0}
			});
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MusicShopDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
		}

        public DbSet<Client> Clients { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Plate> Plates { get; set; }
        public DbSet<AvailablePlate> AvailablePlates { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
