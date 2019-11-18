using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FocusBackend.Models;


namespace FocusBackend.Data
{
    public class FocusContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=FocusPocus;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
            //.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User(1, "test", "test", "test", "test")
                );
            modelBuilder.Entity<Business>().HasData(
                   //gucci mane, East Atlanta santa song list
                   new Business(1, "test", "test", "test", 1)
                   );
            modelBuilder.Entity<Category>().HasData(
                   //gucci mane, East Atlanta santa song list
                   new Category(1, "test", "test",  1)
                   );
            modelBuilder.Entity<Activity>().HasData(
                   //gucci mane, East Atlanta santa song list
                   new Activity(1, "test", "test", DateTime.Now, DateTime.Now, 1, 1, 1)
                   );
        }
    }
}
