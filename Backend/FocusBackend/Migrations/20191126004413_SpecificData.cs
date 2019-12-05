using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FocusBackend.Migrations
{
    public partial class SpecificData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 25, 19, 44, 13, 103, DateTimeKind.Local), new DateTime(2019, 11, 25, 19, 44, 13, 102, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 25, 19, 44, 13, 103, DateTimeKind.Local), new DateTime(2019, 11, 25, 19, 44, 13, 103, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 25, 19, 44, 13, 103, DateTimeKind.Local), new DateTime(2019, 11, 25, 19, 44, 13, 103, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Industry", "Name" },
                values: new object[] { "Restaurant", "Bertha and Bubba's Seafood Palace" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Email", "Name" },
                values: new object[] { "BGump@MyEmail.com", "Bubba Gump" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 25, 13, 49, 12, 842, DateTimeKind.Local), new DateTime(2019, 11, 25, 13, 49, 12, 841, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 25, 13, 49, 12, 843, DateTimeKind.Local), new DateTime(2019, 11, 25, 13, 49, 12, 843, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 25, 13, 49, 12, 843, DateTimeKind.Local), new DateTime(2019, 11, 25, 13, 49, 12, 843, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Industry", "Name" },
                values: new object[] { "Retail", "Small Business" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Email", "Name" },
                values: new object[] { "JSmith@MyEmail.com", "John Smith" });
        }
    }
}
