using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FocusBackend.Migrations
{
    public partial class MoreActivities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 2, 11, 40, 51, 383, DateTimeKind.Local), new DateTime(2019, 12, 2, 11, 40, 51, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 2, 11, 40, 51, 383, DateTimeKind.Local), new DateTime(2019, 12, 2, 11, 40, 51, 383, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 2, 11, 40, 51, 383, DateTimeKind.Local), new DateTime(2019, 12, 2, 11, 40, 51, 383, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ID", "CategoryID", "Completion", "Creation", "Description", "Done", "Importance", "Name", "Rank", "Urgency" },
                values: new object[,]
                {
                    { 4, 7, new DateTime(2019, 12, 2, 11, 40, 51, 383, DateTimeKind.Local), new DateTime(2019, 12, 2, 11, 40, 51, 383, DateTimeKind.Local), "Make The Restaurant Presentable", false, 5, "Clean Store", 10, 5 },
                    { 5, 5, new DateTime(2019, 12, 2, 11, 40, 51, 383, DateTimeKind.Local), new DateTime(2019, 12, 2, 11, 40, 51, 383, DateTimeKind.Local), "Keep The Lights On", false, 8, "Pay Bills", 16, 8 },
                    { 6, 7, new DateTime(2019, 12, 2, 11, 40, 51, 383, DateTimeKind.Local), new DateTime(2019, 12, 2, 11, 40, 51, 383, DateTimeKind.Local), "St Up Deliveries For Stock", false, 7, "Order Food", 12, 5 },
                    { 7, 1, new DateTime(2019, 12, 2, 11, 40, 51, 383, DateTimeKind.Local), new DateTime(2019, 12, 2, 11, 40, 51, 383, DateTimeKind.Local), "Turn In Newspaper Add", false, 5, "Advertising", 14, 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 27, 12, 9, 58, 702, DateTimeKind.Local), new DateTime(2019, 11, 27, 12, 9, 58, 700, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 27, 12, 9, 58, 702, DateTimeKind.Local), new DateTime(2019, 11, 27, 12, 9, 58, 702, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 27, 12, 9, 58, 702, DateTimeKind.Local), new DateTime(2019, 11, 27, 12, 9, 58, 702, DateTimeKind.Local) });
        }
    }
}
