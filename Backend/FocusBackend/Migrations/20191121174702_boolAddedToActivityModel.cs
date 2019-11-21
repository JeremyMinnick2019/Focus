using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FocusBackend.Migrations
{
    public partial class boolAddedToActivityModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Activities",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Done",
                table: "Activities");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 19, 11, 12, 6, 557, DateTimeKind.Local), new DateTime(2019, 11, 19, 11, 12, 6, 555, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 19, 11, 12, 6, 558, DateTimeKind.Local), new DateTime(2019, 11, 19, 11, 12, 6, 558, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 19, 11, 12, 6, 558, DateTimeKind.Local), new DateTime(2019, 11, 19, 11, 12, 6, 558, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Email", "Image", "Name", "Phone" },
                values: new object[] { 2, "BJones@MyEmail.com", "Image", "Brad Jones", "15554541812" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "ID", "Image", "Industry", "Name", "UserID" },
                values: new object[] { 2, "Image", "Retail", "Fish Shop", 2 });
        }
    }
}
