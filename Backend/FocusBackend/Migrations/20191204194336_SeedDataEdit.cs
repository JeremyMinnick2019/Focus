using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FocusBackend.Migrations
{
    public partial class SeedDataEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 43, 36, 291, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "Phone",
                value: "(440) 454-1980");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local) });

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
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local), new DateTime(2019, 12, 4, 14, 7, 21, 488, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "Phone",
                value: "440-454-1980");
        }
    }
}
