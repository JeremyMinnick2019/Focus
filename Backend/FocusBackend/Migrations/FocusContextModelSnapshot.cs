﻿// <auto-generated />
using System;
using FocusBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FocusBackend.Migrations
{
    [DbContext(typeof(FocusContext))]
    partial class FocusContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FocusBackend.Models.Activity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID");

                    b.Property<DateTime>("Completion");

                    b.Property<DateTime>("Creation");

                    b.Property<string>("Description");

                    b.Property<bool>("Done");

                    b.Property<int>("Importance");

                    b.Property<string>("Name");

                    b.Property<int>("Rank");

                    b.Property<int>("Urgency");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Activities");

                    b.HasData(
                        new { ID = 1, CategoryID = 2, Completion = new DateTime(2019, 12, 5, 15, 24, 59, 824, DateTimeKind.Local), Creation = new DateTime(2019, 12, 5, 15, 24, 59, 823, DateTimeKind.Local), Description = "Outsourced From Temp Agency", Done = false, Importance = 9, Name = "Pay Workers", Rank = 18, Urgency = 9 },
                        new { ID = 2, CategoryID = 1, Completion = new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local), Creation = new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local), Description = "Plan Booth and Outreach", Done = false, Importance = 24, Name = "Charity Event", Rank = 49, Urgency = 25 },
                        new { ID = 8, CategoryID = 1, Completion = new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local), Creation = new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local), Description = "Turn In Newspaper Ad", Done = false, Importance = 5, Name = "Advertising", Rank = 14, Urgency = 9 },
                        new { ID = 9, CategoryID = 3, Completion = new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local), Creation = new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local), Description = "Go Through Invoices", Done = false, Importance = 5, Name = "Paperwork", Rank = 14, Urgency = 9 },
                        new { ID = 11, CategoryID = 2, Completion = new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local), Creation = new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local), Description = "Check Employee Pay", Done = false, Importance = 5, Name = "Paycheck Error", Rank = 14, Urgency = 9 },
                        new { ID = 16, CategoryID = 3, Completion = new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local), Creation = new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local), Description = "Organize receipts", Done = false, Importance = 5, Name = "Tax Paperwork", Rank = 14, Urgency = 9 }
                    );
                });

            modelBuilder.Entity("FocusBackend.Models.Business", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image");

                    b.Property<string>("Industry");

                    b.Property<string>("Name");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Businesses");

                    b.HasData(
                        new { ID = 1, Image = "image", Industry = "School", Name = "Jane's Dojo", UserID = 1 }
                    );
                });

            modelBuilder.Entity("FocusBackend.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusinessID");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("BusinessID");

                    b.ToTable("Categories");

                    b.HasData(
                        new { ID = 1, BusinessID = 1, Description = "Marketing And Promotion Actions", Name = "Marketing" },
                        new { ID = 2, BusinessID = 1, Description = "Payroll Actions", Name = "Payroll" },
                        new { ID = 3, BusinessID = 1, Description = "Accounting and Auditing Actions", Name = "Accounting" },
                        new { ID = 4, BusinessID = 1, Description = "How You Help Your Customers", Name = "Customer Service" },
                        new { ID = 5, BusinessID = 1, Description = "Managing Your Budget And Looking To The Future", Name = "Budgeting" },
                        new { ID = 6, BusinessID = 1, Description = "Give Your Sales A Boost", Name = "Sales" },
                        new { ID = 7, BusinessID = 1, Description = "Operational Actions", Name = "Operations" },
                        new { ID = 8, BusinessID = 1, Description = "Small Actions That Must Be Done", Name = "Small Tasks" },
                        new { ID = 9, BusinessID = 1, Description = "Other Actions To Do", Name = "Miscellaneous" }
                    );
                });

            modelBuilder.Entity("FocusBackend.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new { ID = 1, Email = "JSmith@MyEmail.com", Image = "./images/blank-profile-picture.png", Name = "Jane Smith", Phone = "(440) 454-1980" }
                    );
                });

            modelBuilder.Entity("FocusBackend.Models.Activity", b =>
                {
                    b.HasOne("FocusBackend.Models.Category", "Category")
                        .WithMany("Activities")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FocusBackend.Models.Business", b =>
                {
                    b.HasOne("FocusBackend.Models.User", "User")
                        .WithMany("Businesses")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FocusBackend.Models.Category", b =>
                {
                    b.HasOne("FocusBackend.Models.Business", "Business")
                        .WithMany("Categories")
                        .HasForeignKey("BusinessID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
