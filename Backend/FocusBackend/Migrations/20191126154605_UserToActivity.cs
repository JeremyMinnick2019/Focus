using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FocusBackend.Migrations
{
    public partial class UserToActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Activities",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 26, 10, 46, 5, 380, DateTimeKind.Local), new DateTime(2019, 11, 26, 10, 46, 5, 379, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 26, 10, 46, 5, 381, DateTimeKind.Local), new DateTime(2019, 11, 26, 10, 46, 5, 381, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 26, 10, 46, 5, 381, DateTimeKind.Local), new DateTime(2019, 11, 26, 10, 46, 5, 381, DateTimeKind.Local) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Users_UserID",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_UserID",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Activities");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 26, 10, 32, 53, 111, DateTimeKind.Local), new DateTime(2019, 11, 26, 10, 32, 53, 110, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 26, 10, 32, 53, 111, DateTimeKind.Local), new DateTime(2019, 11, 26, 10, 32, 53, 111, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Completion", "Creation" },
                values: new object[] { new DateTime(2019, 11, 26, 10, 32, 53, 111, DateTimeKind.Local), new DateTime(2019, 11, 26, 10, 32, 53, 111, DateTimeKind.Local) });
        }
    }
}
