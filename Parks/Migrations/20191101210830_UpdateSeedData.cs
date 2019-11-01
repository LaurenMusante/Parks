using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                column: "Activities",
                value: "Trail running, birdwatching");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Activities", "Name", "Rating", "State", "StateOrNational" },
                values: new object[,]
                {
                    { 28, "Rock-climbing, camping", "Tombigbee", 6, "MS", "State" },
                    { 29, "Cycling, camping, bird-watching", "Little Missouri", 8, "MO", "State" },
                    { 30, "Mountain biking, backpacking", "Shenandoah", 8, "VA", "National" },
                    { 31, "Cycling, canoeing", "DeSoto", 2, "AL", "State" },
                    { 32, "Swimming, clam digging", "Acadia", 7, "ME", "National" },
                    { 33, "Mushroom foraging, hiking", "Biscayne", 5, "FL", "National" },
                    { 34, "Trekking, camping", "Cuyahoga Valley", 4, "OH", "National" },
                    { 35, "Plogging, skyrunning", "Everglades", 7, "FL", "National" },
                    { 36, "Running, bird-watching", "Oak Mountain", 6, "AL", "State" },
                    { 37, "Canyoning, Skiing, hiking", "Borderland", 8, "MA", "State" },
                    { 38, "Trail running, birdwatching, paragliding", "Burlingame", 9, "RI", "State" },
                    { 39, "Fly fishing, kayaking", "Camel's Hump", 10, "VT", "State" },
                    { 40, "Rappelling, hiking", "Green River Resevoir", 3, "VT", "State" },
                    { 41, "Skiing, snowshoeing", "Gates of the Arctic", 10, "AK", "National" },
                    { 42, "Camping, backpacking, train running", "Great Basin", 6, "NV", "National" },
                    { 43, "Mountain biking, rock climbing", "Great Sand Dunes", 9, "CO", "National" },
                    { 44, "Clam digging, swimming, sailing", "High Falls", 6, "GA", "National" },
                    { 45, "Windsurfing, birdwatching", "Isle Royale", 7, "MI", "National" },
                    { 46, "Ice climbing, running, birdwatching", "Katmai", 8, "AK", "National" },
                    { 47, "Trekking, running, hiking", "Olympic", 10, "WA", "National" },
                    { 48, "Mushroom foraging, plogging, tree climbing", "Petrified Forest", 9, "AZ", "National" },
                    { 27, "Mountaineering, hiking", "Arrowhead", 7, "OK", "State" },
                    { 26, "Running, hiking, climbing, swimming", "Zion", 10, "UT", "National" },
                    { 25, "Running, bird-watching", "Carlsbad Caverns", 8, "NM", "National" },
                    { 24, "Mountain biking, hiking, sunset-viewing", "Joaquin Miller", 10, "CA", "State" },
                    { 2, "Snowshoeing, snowman-building", "Denali", 10, "AK", "National" },
                    { 3, "Hiking, picnicking", "Grand Canyon", 4, "AZ", "National" },
                    { 4, "Rock-climbing", "Joshua Tree", 10, "CA", "National" },
                    { 5, "Fishing, swimming, trail-running", "Lake Tahoe", 9, "NV", "State" },
                    { 6, "Hiking, running, mountaineering", "Rocky Mounatin", 5, "CO", "National" },
                    { 7, "Backpacking, hiking", "Yellowstone", 2, "ID", "National" },
                    { 8, "Coconut-hunting, cycling", "Haleakala", 8, "HI", "National" },
                    { 9, "Running, bat-watching", "Mammoth Cave", 6, "KY", "National" },
                    { 10, "Trekking, kayaking", "Glacier", 10, "MT", "National" },
                    { 11, "Rock-climbing, hiking,", "Goblin Valley", 10, "UT", "State" },
                    { 49, "Paragliding, wingsuit flying", "Wind Cave", 3, "SD", "National" },
                    { 12, "Hiking, sun-bathing", "Arches", 10, "UT", "National" },
                    { 14, "Hiking, exploring", "Bryce Canyon", 10, "UT", "National" },
                    { 15, "Hiking, walking, squeezing", "Carlsbad Caverns", 8, "NM", "National" },
                    { 16, "Trail running, mountain-ogling", "Grand Teton", 3, "WY", "National" },
                    { 17, "Running, walking, crawling", "Congaree", 7, "SC", "National" },
                    { 18, "Boating, hiking, picnicking", "Crater Lake", 10, "OR", "National" },
                    { 19, "Mountaineering, skyrunning", "Great Smoky Mountains", 9, "TN", "National" },
                    { 20, "Sight-seeing, picnicking", "Guadalupe Mountains", 7, "TX", "National" },
                    { 21, "Trekking, waterfalls", "Voyageurs", 8, "MN", "National" },
                    { 22, "Swimming, walking, cartwheeling", "Big Creek", 7, "IA", "State" },
                    { 23, "Trail running, camping", "Cheboygan", 9, "MI", "State" },
                    { 13, "Trail running, hiking", "BadLands", 9, "SD", "National" },
                    { 50, "Motorbike expedition, sightseeing", "Indiana Dunes", 4, "IN", "State" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                column: "Activities",
                value: "Running, bird-watching");
        }
    }
}
