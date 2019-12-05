using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FocusBackend.Migrations
{
    public partial class ActionAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 731, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Importance", "Name", "Rank", "Urgency" },
                values: new object[] { 1, new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), "Plan Booth and Outreach", 24, "Charity Event", 49, 25 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Importance", "Name", "Rank", "Urgency" },
                values: new object[] { 6, new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), "Follow Up With Prospects", 10, "Sales Planning", 13, 3 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Importance", "Name", "Urgency" },
                values: new object[] { 8, new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), "Get More Stamps For Paychecks", 4, "Buy Stamps", 6 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Importance", "Name", "Rank", "Urgency" },
                values: new object[] { 7, new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), "Make The Dojo Presentable", 5, "Clean Store", 10, 5 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Importance", "Name", "Rank", "Urgency" },
                values: new object[] { 5, new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), "Keep The Lights On", 8, "Pay Bills", 16, 8 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Importance", "Name", "Rank", "Urgency" },
                values: new object[] { 7, new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), "Set Up Deliveries For Stock", 7, "Order Food", 12, 5 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 1, new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), "Turn In Newspaper Ad", "Advertising" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 3, new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), "Go Through Invoices", "Paperwork" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 4, new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), "Respond To Complaint", "Client Concern" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 2, new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), "Check Employee Pay", "Paycheck Error" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 6, new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), "Plan Presentation", "New Member Outreach" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 8, new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), "Fix Front Steps", "Building Maintenance" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 5, new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), "Next Quarter Cleaning Funds", "Allocation" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 1, new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), "FB and Google Ads", "Online Ad" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 3, new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), "Organize receipts", "Tax Paperwork" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ID", "CategoryID", "Completion", "Creation", "Description", "Done", "Importance", "Name", "Rank", "Urgency" },
                values: new object[] { 17, 4, new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), "Thank User For Nice Online Review", false, 5, "Accolade", 14, 9 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 43, 36, 290, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 288, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Importance", "Name", "Rank", "Urgency" },
                values: new object[] { 6, new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), "Follow Up With Prospects", 10, "Sales Planning", 13, 3 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Importance", "Name", "Rank", "Urgency" },
                values: new object[] { 8, new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), "Get More Stamps For Paychecks", 4, "Buy Stamps", 10, 6 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Importance", "Name", "Urgency" },
                values: new object[] { 7, new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), "Make The Restaurant Presentable", 5, "Clean Store", 5 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Importance", "Name", "Rank", "Urgency" },
                values: new object[] { 5, new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), "Keep The Lights On", 8, "Pay Bills", 16, 8 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Importance", "Name", "Rank", "Urgency" },
                values: new object[] { 7, new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), "Set Up Deliveries For Stock", 7, "Order Food", 12, 5 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Importance", "Name", "Rank", "Urgency" },
                values: new object[] { 1, new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), "Turn In Newspaper Ad", 5, "Advertising", 14, 9 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 3, new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), "Go Through Invoices", "Paperwork" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 4, new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), "Respond To Complaint", "Client Concern" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 2, new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), "Check Employee Pay", "Paycheck Error" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 6, new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), "Plan Presentation", "New Member Outreach" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 8, new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), "Fix Front Steps", "Building Maintenance" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 5, new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), "Next Quarter Cleaning Funds", "Allocation" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 1, new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), "FB and Google Ads", "Online Ad" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 3, new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), "Organize receipts", "Tax Paperwork" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryID", "Completion", "Creation", "Description", "Name" },
                values: new object[] { 4, new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), "Thank User For Nice Online Review", "Accolade" });
        }
    }
}
