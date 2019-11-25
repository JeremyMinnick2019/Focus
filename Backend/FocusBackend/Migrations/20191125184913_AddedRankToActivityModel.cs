using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FocusBackend.Migrations
{
    public partial class AddedRankToActivityModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rank",
                table: "Activities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation", "Rank" },
                values: new object[] { new DateTime(2019, 11, 25, 13, 49, 12, 842, DateTimeKind.Local), new DateTime(2019, 11, 25, 13, 49, 12, 841, DateTimeKind.Local), 18 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Completion", "Creation", "Rank" },
                values: new object[] { new DateTime(2019, 11, 25, 13, 49, 12, 843, DateTimeKind.Local), new DateTime(2019, 11, 25, 13, 49, 12, 843, DateTimeKind.Local), 13 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Completion", "Creation", "Rank" },
                values: new object[] { new DateTime(2019, 11, 25, 13, 49, 12, 843, DateTimeKind.Local), new DateTime(2019, 11, 25, 13, 49, 12, 843, DateTimeKind.Local), 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rank",
                table: "Activities");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 21, 12, 47, 1, 832, DateTimeKind.Local), new DateTime(2019, 11, 21, 12, 47, 1, 831, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 21, 12, 47, 1, 833, DateTimeKind.Local), new DateTime(2019, 11, 21, 12, 47, 1, 833, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 21, 12, 47, 1, 833, DateTimeKind.Local), new DateTime(2019, 11, 21, 12, 47, 1, 833, DateTimeKind.Local) });
        }
    }
}
