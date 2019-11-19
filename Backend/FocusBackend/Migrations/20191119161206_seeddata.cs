using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FocusBackend.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Image", "Industry", "Name" },
                values: new object[] { "Image", "Retail", "Small Business" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Marketing And Promotion Activities", "Marketing" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "BusinessID", "Description", "Name" },
                values: new object[,]
                {
                    { 2, 1, "Payroll Activities", "Payroll" },
                    { 3, 1, "Accounting and Auditing Activities", "Accounting/Auditing" },
                    { 4, 1, "How You Help Your Customers", "Customer Service" },
                    { 5, 1, "Managing Your Budget And Looking To The Future", "Budgeting" },
                    { 6, 1, "Give Your Sales A Boost", "Sales" },
                    { 7, 1, "Operational Activities", "Operations" },
                    { 8, 1, "Small Activities That Must Be Done", "Small Tasks" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Email", "Image", "Name", "Phone" },
                values: new object[] { "JSmith@MyEmail.com", "Image", "John Smith", "14404541980" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Email", "Image", "Name", "Phone" },
                values: new object[] { 2, "BJones@MyEmail.com", "Image", "Brad Jones", "15554541812" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Importance", "Name", "Urgency" },
                values: new object[] { 2, new DateTime(2019, 11, 19, 11, 12, 6, 557, DateTimeKind.Local), new DateTime(2019, 11, 19, 11, 12, 6, 555, DateTimeKind.Local), "Outsourced From Temp Agency", 9, "Pay Workers", 9 });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ID", "CategoryID", "Completion", "Creation", "Description", "Importance", "Name", "Urgency" },
                values: new object[,]
                {
                    { 2, 6, new DateTime(2019, 11, 19, 11, 12, 6, 558, DateTimeKind.Local), new DateTime(2019, 11, 19, 11, 12, 6, 558, DateTimeKind.Local), "Follow Up With Prospects", 10, "Sales Planning", 3 },
                    { 3, 8, new DateTime(2019, 11, 19, 11, 12, 6, 558, DateTimeKind.Local), new DateTime(2019, 11, 19, 11, 12, 6, 558, DateTimeKind.Local), "Get More Stamps For Pay Checks", 4, "Buy Stamps", 6 }
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "ID", "Image", "Industry", "Name", "UserID" },
                values: new object[] { 2, "Image", "Retail", "Fish Shop", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Importance", "Name", "Urgency" },
                values: new object[] { 1, new DateTime(2019, 11, 18, 15, 20, 56, 307, DateTimeKind.Local), new DateTime(2019, 11, 18, 15, 20, 56, 305, DateTimeKind.Local), "test", 1, "test", 1 });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Image", "Industry", "Name" },
                values: new object[] { "test", "test", "test" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "test", "test" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Email", "Image", "Name", "Phone" },
                values: new object[] { "test", "test", "test", "test" });
        }
    }
}
