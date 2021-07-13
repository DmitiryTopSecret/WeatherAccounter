using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherAccounter.DAL.Migrations
{
    public partial class EditedCityModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Weather_WeatherId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_WeatherId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "WeatherId",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Weather",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weather_CityId",
                table: "Weather",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_Cities_CityId",
                table: "Weather",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Cities_CityId",
                table: "Weather");

            migrationBuilder.DropIndex(
                name: "IX_Weather_CityId",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Weather");

            migrationBuilder.AddColumn<int>(
                name: "WeatherId",
                table: "Cities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_WeatherId",
                table: "Cities",
                column: "WeatherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Weather_WeatherId",
                table: "Cities",
                column: "WeatherId",
                principalTable: "Weather",
                principalColumn: "WeatherId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
