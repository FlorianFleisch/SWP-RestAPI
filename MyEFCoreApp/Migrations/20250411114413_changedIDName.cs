using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyEFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class changedIDName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Cities_CityId",
                table: "People");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "People",
                newName: "CityID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "People",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_People_CityId",
                table: "People",
                newName: "IX_People_CityID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cities",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Cities_CityID",
                table: "People",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Cities_CityID",
                table: "People");

            migrationBuilder.RenameColumn(
                name: "CityID",
                table: "People",
                newName: "CityId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "People",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_People_CityID",
                table: "People",
                newName: "IX_People_CityId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Cities",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Cities_CityId",
                table: "People",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");
        }
    }
}
