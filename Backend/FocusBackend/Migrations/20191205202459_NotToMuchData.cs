using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FocusBackend.Migrations
{
    public partial class NotToMuchData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 10);

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
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 5, 15, 24, 59, 824, DateTimeKind.Local), new DateTime(2019, 12, 5, 15, 24, 59, 823, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local), new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local), new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local), new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local), new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local), new DateTime(2019, 12, 5, 15, 24, 59, 825, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "Description",
                value: "Marketing And Promotion Actions");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "Description",
                value: "Payroll Actions");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "Description",
                value: "Accounting and Auditing Actions");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                column: "Description",
                value: "Operational Actions");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                column: "Description",
                value: "Small Actions That Must Be Done");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "BusinessID", "Description", "Name" },
                values: new object[] { 9, 1, "Other Actions To Do", "Miscellaneous" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9);

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
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ID", "CategoryID", "Completion", "Creation", "Description", "Done", "Importance", "Name", "Rank", "Urgency" },
                values: new object[,]
                {
                    { 6, 5, new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), "Keep The Lights On", false, 8, "Pay Bills", 16, 8 },
                    { 17, 4, new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), "Thank User For Nice Online Review", false, 5, "Accolade", 14, 9 },
                    { 15, 1, new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), "FB and Google Ads", false, 5, "Online Ad", 14, 9 },
                    { 5, 7, new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), "Make The Dojo Presentable", false, 5, "Clean Store", 10, 5 },
                    { 13, 8, new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), "Fix Front Steps", false, 5, "Building Maintenance", 14, 9 },
                    { 14, 5, new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), "Next Quarter Cleaning Funds", false, 5, "Allocation", 14, 9 },
                    { 10, 4, new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), "Respond To Complaint", false, 5, "Client Concern", 14, 9 },
                    { 3, 6, new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), "Follow Up With Prospects", false, 10, "Sales Planning", 13, 3 },
                    { 4, 8, new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), "Get More Stamps For Paychecks", false, 4, "Buy Stamps", 10, 6 },
                    { 7, 7, new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 732, DateTimeKind.Local), "Set Up Deliveries For Stock", false, 7, "Order Food", 12, 5 },
                    { 12, 6, new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), new DateTime(2019, 12, 5, 13, 25, 25, 733, DateTimeKind.Local), "Plan Presentation", false, 5, "New Member Outreach", 14, 9 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "Description",
                value: "Marketing And Promotion Activities");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "Description",
                value: "Payroll Activities");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "Description",
                value: "Accounting and Auditing Activities");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                column: "Description",
                value: "Operational Activities");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                column: "Description",
                value: "Small Activities That Must Be Done");
        }
    }
}
