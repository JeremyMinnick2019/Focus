using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FocusBackend.Migrations
{
    public partial class PointValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "Points",
            //    table: "Activities",
            //    nullable: false,
            //    defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 26, 10, 32, 53, 111, DateTimeKind.Local), new DateTime(2019, 11, 26, 10, 32, 53, 110, DateTimeKind.Local)});

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 26, 10, 32, 53, 111, DateTimeKind.Local), new DateTime(2019, 11, 26, 10, 32, 53, 111, DateTimeKind.Local)});

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 26, 10, 32, 53, 111, DateTimeKind.Local), new DateTime(2019, 11, 26, 10, 32, 53, 111, DateTimeKind.Local)});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "Points",
            //    table: "Activities");

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
        }
    }
}
