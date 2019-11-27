using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FocusBackend.Migrations
{
    public partial class DataUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Users_UserID",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_UserID",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Activities");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 26, 15, 39, 0, 92, DateTimeKind.Local), new DateTime(2019, 11, 26, 15, 39, 0, 91, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 26, 15, 39, 0, 93, DateTimeKind.Local), new DateTime(2019, 11, 26, 15, 39, 0, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 26, 15, 39, 0, 93, DateTimeKind.Local), new DateTime(2019, 11, 26, 15, 39, 0, 93, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "Activities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Activities",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation", "Points" },
                values: new object[] { new DateTime(2019, 11, 26, 10, 46, 5, 380, DateTimeKind.Local), new DateTime(2019, 11, 26, 10, 46, 5, 379, DateTimeKind.Local), 180 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Completion", "Creation", "Points" },
                values: new object[] { new DateTime(2019, 11, 26, 10, 46, 5, 381, DateTimeKind.Local), new DateTime(2019, 11, 26, 10, 46, 5, 381, DateTimeKind.Local), 130 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Completion", "Creation", "Points" },
                values: new object[] { new DateTime(2019, 11, 26, 10, 46, 5, 381, DateTimeKind.Local), new DateTime(2019, 11, 26, 10, 46, 5, 381, DateTimeKind.Local), 100 });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_UserID",
                table: "Activities",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Users_UserID",
                table: "Activities",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
