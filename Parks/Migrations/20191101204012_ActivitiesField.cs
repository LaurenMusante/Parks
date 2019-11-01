using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class ActivitiesField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11);

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

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 50);

            migrationBuilder.AddColumn<string>(
                name: "Activities",
                table: "Parks",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                column: "Activities",
                value: "Running, bird-watching");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activities",
                table: "Parks");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "Rating", "State", "StateOrNational" },
                values: new object[,]
                {
                    { 2, "Denali", 10, "AK", "National" },
                    { 28, "Tombigbee", 6, "MS", "State" },
                    { 29, "Little Missouri", 8, "MO", "State" },
                    { 30, "Shenandoah", 8, "VA", "National" },
                    { 31, "DeSoto", 2, "AL", "State" },
                    { 32, "Acadia", 7, "ME", "National" },
                    { 33, "Biscayne", 5, "FL", "National" },
                    { 34, "Cuyahoga Valley", 4, "OH", "National" },
                    { 35, "Everglades", 7, "FL", "National" },
                    { 36, "Oak Mountain", 6, "AL", "State" },
                    { 37, "Borderland", 8, "MA", "State" },
                    { 38, "Burlingame", 9, "RI", "State" },
                    { 39, "Camel's Hump", 10, "VT", "State" },
                    { 40, "Green River Resevoir", 3, "VT", "State" },
                    { 41, "Gates of the Arctic", 10, "AK", "National" },
                    { 42, "Great Basin", 6, "NV", "National" },
                    { 43, "Great Sand Dunes", 9, "CO", "National" },
                    { 44, "High Falls", 6, "GA", "National" },
                    { 45, "Isle Royale", 7, "MI", "National" },
                    { 46, "Katmai", 8, "AK", "National" },
                    { 47, "Olympic", 10, "WA", "National" },
                    { 48, "Petrified Forest", 9, "AZ", "National" },
                    { 27, "Arrowhead", 7, "OK", "State" },
                    { 49, "Wind Cave", 3, "SD", "National" },
                    { 26, "Zion", 10, "UT", "National" },
                    { 24, "Joaquin Miller", 10, "CA", "State" },
                    { 3, "Grand Canyon", 4, "AZ", "National" },
                    { 4, "Joshua Tree", 10, "CA", "National" },
                    { 5, "Lake Tahoe", 9, "NV", "State" },
                    { 6, "Rocky Mounatin", 5, "CO", "National" },
                    { 7, "Yellowstone", 2, "ID", "National" },
                    { 8, "Haleakala", 8, "HI", "National" },
                    { 9, "Mammoth Cave", 6, "KY", "National" },
                    { 10, "Glacier", 10, "MT", "National" },
                    { 11, "Goblin Valley", 10, "UT", "State" },
                    { 12, "Arches", 10, "UT", "National" },
                    { 13, "BadLands", 9, "SD", "National" },
                    { 14, "Bryce Canyon", 10, "UT", "National" },
                    { 15, "Carlsbad Caverns", 8, "NM", "National" },
                    { 16, "Grand Teton", 3, "WY", "National" },
                    { 17, "Congaree", 7, "SC", "National" },
                    { 18, "Crater Lake", 10, "OR", "National" },
                    { 19, "Great Smoky Mountains", 9, "TN", "National" },
                    { 20, "Guadalupe Mountains", 7, "TX", "National" },
                    { 21, "Voyageurs", 8, "MN", "National" },
                    { 22, "Big Creek", 7, "IA", "State" },
                    { 23, "Cheboygan", 9, "MI", "State" },
                    { 25, "Carlsbad Caverns", 8, "NM", "National" },
                    { 50, "Indiana Dunes", 4, "IN", "State" }
                });
        }
    }
}
