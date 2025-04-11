using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyEFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class addPLZ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PLZ",
                table: "Cities",
                type: "TEXT",
                nullable: false,
                defaultValue: "6844");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PLZ",
                table: "Cities");
        }
    }
}
