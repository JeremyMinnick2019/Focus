using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FocusBackend.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 487, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 486, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Completion", "Creation", "Description" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), "Get More Stamps For Paychecks" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Completion", "Creation", "Description" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), "Set Up Deliveries For Stock" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Completion", "Creation", "Description" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), "Turn In Newspaper Ad" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ID", "CategoryID", "Completion", "Creation", "Description", "Done", "Importance", "Name", "Rank", "Urgency" },
                values: new object[,]
                {
                    { 16, 4, new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), "Thank User For Nice Online Review", false, 5, "Accolade", 14, 9 },
                    { 15, 3, new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), "Organize receipts", false, 5, "Tax Paperwork", 14, 9 },
                    { 14, 1, new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), "FB and Google Ads", false, 5, "Online Ad", 14, 9 },
                    { 13, 5, new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), "Next Quarter Cleaning Funds", false, 5, "Allocation", 14, 9 },
                    { 10, 2, new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), "Check Employee Pay", false, 5, "Paycheck Error", 14, 9 },
                    { 11, 6, new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), "Plan Presentation", false, 5, "New Member Outreach", 14, 9 },
                    { 9, 4, new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), "Respond To Complaint", false, 5, "Client Concern", 14, 9 },
                    { 8, 3, new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), "Go Through Invoices", false, 5, "Paperwork", 14, 9 },
                    { 12, 8, new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), "Fix Front Steps", false, 5, "Building Maintenance", 14, 9 }
                });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Industry", "Name" },
                values: new object[] { "School", "Jane's Dojo" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "Name",
                value: "Accounting");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "JSmith@MyEmail.com", "Jane Smith", "440-454-1980" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 3, 15, 42, 54, 843, DateTimeKind.Local), new DateTime(2019, 12, 3, 15, 42, 54, 842, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 3, 15, 42, 54, 843, DateTimeKind.Local), new DateTime(2019, 12, 3, 15, 42, 54, 843, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Completion", "Creation", "Description" },
                values: new object[] { new DateTime(2019, 12, 3, 15, 42, 54, 843, DateTimeKind.Local), new DateTime(2019, 12, 3, 15, 42, 54, 843, DateTimeKind.Local), "Get More Stamps For Pay Checks" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 3, 15, 42, 54, 843, DateTimeKind.Local), new DateTime(2019, 12, 3, 15, 42, 54, 843, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 3, 15, 42, 54, 843, DateTimeKind.Local), new DateTime(2019, 12, 3, 15, 42, 54, 843, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Completion", "Creation", "Description" },
                values: new object[] { new DateTime(2019, 12, 3, 15, 42, 54, 843, DateTimeKind.Local), new DateTime(2019, 12, 3, 15, 42, 54, 843, DateTimeKind.Local), "St Up Deliveries For Stock" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Completion", "Creation", "Description" },
                values: new object[] { new DateTime(2019, 12, 3, 15, 42, 54, 843, DateTimeKind.Local), new DateTime(2019, 12, 3, 15, 42, 54, 843, DateTimeKind.Local), "Turn In Newspaper Add" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Industry", "Name" },
                values: new object[] { "Restaurant", "Bertha and Bubba's Seafood Palace" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "Name",
                value: "Accounting/Auditing");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "BGump@MyEmail.com", "Bubba Gump", "14404541980" });
        }
    }
}
