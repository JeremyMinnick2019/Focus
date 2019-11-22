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
                new User(1, "John Smith", "JSmith@MyEmail.com", "14404541980", "Image")
                );
                
            modelBuilder.Entity<Business>().HasData(
                   new Business(1, "Small Business", "Retail", "Image", 1)
                   );

            modelBuilder.Entity<Category>().HasData(
                   new Category(1, "Marketing", "Marketing And Promotion Activities",  1),
                   new Category(2, "Payroll", "Payroll Activities", 1),
                   new Category(3, "Accounting/Auditing", "Accounting and Auditing Activities", 1),
                   new Category(4, "Customer Service", "How You Help Your Customers", 1),
                   new Category(5, "Budgeting", "Managing Your Budget And Looking To The Future", 1),
                   new Category(6, "Sales", "Give Your Sales A Boost", 1),
                   new Category(7, "Operations", "Operational Activities", 1),
                   new Category(8, "Small Tasks", "Small Activities That Must Be Done", 1)

                   );
            modelBuilder.Entity<Activity>().HasData(
                   new Activity(1, "Pay Workers", "Outsourced From Temp Agency", DateTime.Now, DateTime.Now, 9, 9, false, 2),
                   new Activity(2, "Sales Planning", "Follow Up With Prospects", DateTime.Now, DateTime.Now, 10, 3, false, 6),
                   new Activity(3, "Buy Stamps", "Get More Stamps For Pay Checks", DateTime.Now, DateTime.Now, 4, 6, false, 8)
                   );
        }
    }
}
