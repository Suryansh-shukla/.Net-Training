using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DtoLab.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialSecurityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfileImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsAdmin", "PasswordHash", "ProfileImageUrl", "SocialSecurityNumber", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 3, 12, 5, 53, 2, 320, DateTimeKind.Utc).AddTicks(2393), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@example.com", false, "hashed_12345", null, "123-45-6789", "john_doe" },
                    { 2, new DateTime(2026, 3, 12, 5, 53, 2, 320, DateTimeKind.Utc).AddTicks(2688), new DateTime(1985, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane@example.com", true, "hashed_67890", null, "987-65-4321", "jane_admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
