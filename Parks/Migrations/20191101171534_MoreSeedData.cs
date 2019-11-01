using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class MoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "Rating", "State", "StateOrNational" },
                values: new object[,]
                {
                    { 12, "Arches", 10, "UT", "National" },
                    { 28, "Tombigbee", 10, "MS", "State" },
                    { 27, "Arrowhead", 7, "OK", "State" },
                    { 26, "Zion", 10, "UT", "National" },
                    { 25, "Carlsbad Caverns", 8, "NM", "National" },
                    { 24, "Joaquin Miller", 10, "CA", "State" },
                    { 23, "Cheboygan", 9, "MI", "State" },
                    { 22, "Big Creek", 7, "IA", "State" },
                    { 29, "Little Missouri", 8, "MO", "State" },
                    { 21, "Voyageurs", 8, "MN", "National" },
                    { 19, "Great Smoky Mountains", 9, "TN", "National" },
                    { 18, "Crater Lake", 10, "OR", "National" },
                    { 17, "Congaree", 7, "SC", "National" },
                    { 16, "Grand Teton", 10, "WY", "National" },
                    { 15, "Carlsbad Caverns", 8, "NM", "National" },
                    { 14, "Bryce Canyon", 10, "UT", "National" },
                    { 13, "BadLands", 9, "SD", "National" },
                    { 20, "Guadalupe Mountains", 7, "TX", "National" },
                    { 30, "Shenandoah", 8, "VA", "National" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 30);
        }
    }
}
