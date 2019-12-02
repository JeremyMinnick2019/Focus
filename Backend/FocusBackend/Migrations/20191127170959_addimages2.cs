using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FocusBackend.Migrations
{
    public partial class addimages2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "image");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 27, 11, 57, 58, 632, DateTimeKind.Local), new DateTime(2019, 11, 27, 11, 57, 58, 630, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 27, 11, 57, 58, 633, DateTimeKind.Local), new DateTime(2019, 11, 27, 11, 57, 58, 633, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 27, 11, 57, 58, 633, DateTimeKind.Local), new DateTime(2019, 11, 27, 11, 57, 58, 633, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "Image");
        }
    }
}
