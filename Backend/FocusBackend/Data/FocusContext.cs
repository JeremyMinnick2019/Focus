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
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=FocusDB2;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
            //.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User(1, "Jane Smith", "JSmith@MyEmail.com", "(440) 454-1980", "./images/blank-profile-picture.png")
                );
                
            modelBuilder.Entity<Business>().HasData(
                   new Business(1, "Jane's Dojo", "School", "image", 1)
                   );

            modelBuilder.Entity<Category>().HasData(
                   new Category(1, "Marketing", "Marketing And Promotion Activities",  1),
                   new Category(2, "Payroll", "Payroll Activities", 1),
                   new Category(3, "Accounting", "Accounting and Auditing Activities", 1),
                   new Category(4, "Customer Service", "How You Help Your Customers", 1),
                   new Category(5, "Budgeting", "Managing Your Budget And Looking To The Future", 1),
                   new Category(6, "Sales", "Give Your Sales A Boost", 1),
                   new Category(7, "Operations", "Operational Activities", 1),
                   new Category(8, "Small Tasks", "Small Activities That Must Be Done", 1)

                   );
            modelBuilder.Entity<Activity>().HasData(
                   new Activity(1, "Pay Workers", "Outsourced From Temp Agency", DateTime.Now, DateTime.Now, 9, 9, false, 2),
                   new Activity(2, "Sales Planning", "Follow Up With Prospects", DateTime.Now, DateTime.Now, 10, 3, false, 6),
                   new Activity(3, "Buy Stamps", "Get More Stamps For Paychecks", DateTime.Now, DateTime.Now, 4, 6, false, 8),
                   new Activity(4, "Clean Store", "Make The Restaurant Presentable", DateTime.Now, DateTime.Now,5, 5, false, 7),
                   new Activity(5, "Pay Bills", "Keep The Lights On", DateTime.Now, DateTime.Now, 8, 8, false, 5),
                   new Activity(6, "Order Food", "Set Up Deliveries For Stock", DateTime.Now, DateTime.Now, 7, 5, false, 7),
                   new Activity(7, "Advertising", "Turn In Newspaper Ad", DateTime.Now, DateTime.Now, 5, 9, false, 1),
                   new Activity(8, "Paperwork", "Go Through Invoices", DateTime.Now, DateTime.Now, 5, 9, false, 3),
                   new Activity(9, "Client Concern", "Respond To Complaint", DateTime.Now, DateTime.Now, 5, 9, false, 4),
                   new Activity(10, "Paycheck Error", "Check Employee Pay", DateTime.Now, DateTime.Now, 5, 9, false, 2),
                   new Activity(11, "New Member Outreach", "Plan Presentation", DateTime.Now, DateTime.Now, 5, 9, false, 6),
                   new Activity(12, "Building Maintenance", "Fix Front Steps", DateTime.Now, DateTime.Now, 5, 9, false, 8),
                   new Activity(13, "Allocation", "Next Quarter Cleaning Funds", DateTime.Now, DateTime.Now, 5, 9, false, 5),
                   new Activity(14, "Online Ad", "FB and Google Ads", DateTime.Now, DateTime.Now, 5, 9, false, 1),
                   new Activity(15, "Tax Paperwork", "Organize receipts", DateTime.Now, DateTime.Now, 5, 9, false, 3),
                   new Activity(16, "Accolade", "Thank User For Nice Online Review", DateTime.Now, DateTime.Now, 5, 9, false, 4)

                   );
        }
    }
}
