using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FocusBackend.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Industry = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Businesses_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    BusinessID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Categories_Businesses_BusinessID",
                        column: x => x.BusinessID,
                        principalTable: "Businesses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Creation = table.Column<DateTime>(nullable: false),
                    Completion = table.Column<DateTime>(nullable: false),
                    Importance = table.Column<int>(nullable: false),
                    Urgency = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Activities_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Email", "Image", "Name", "Phone" },
                values: new object[] { 1, "test", "test", "test", "test" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "ID", "Image", "Industry", "Name", "UserID" },
                values: new object[] { 1, "test", "test", "test", 1 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "BusinessID", "Description", "Name" },
                values: new object[] { 1, 1, "test", "test" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ID", "CategoryID", "Completion", "Creation", "Description", "Importance", "Name", "Urgency" },
                values: new object[] { 1, 1, new DateTime(2019, 11, 18, 15, 20, 56, 307, DateTimeKind.Local), new DateTime(2019, 11, 18, 15, 20, 56, 305, DateTimeKind.Local), "test", 1, "test", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_CategoryID",
                table: "Activities",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Businesses_UserID",
                table: "Businesses",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_BusinessID",
                table: "Categories",
                column: "BusinessID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
