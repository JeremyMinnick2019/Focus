using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FocusBackend.Migrations
{
    public partial class addimages : Migration
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
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "./images/blank-profile-picture.png");
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "Image");

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
