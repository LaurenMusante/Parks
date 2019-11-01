using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class FirstSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "Rating", "State", "StateOrNational" },
                values: new object[,]
                {
                    { 1, "Samuel P. Taylor", 10, "CA", "State" },
                    { 2, "Denali", 10, "AK", "National" },
                    { 3, "Grand Canyon", 9, "AZ", "National" },
                    { 4, "Joshua Tree", 10, "CA", "National" },
                    { 5, "Lake Tahoe", 10, "NV", "State" },
                    { 6, "Rocky Mounatin", 10, "CO", "National" },
                    { 7, "Yellowstone", 10, "ID", "National" },
                    { 8, "Haleakala", 8, "HI", "National" },
                    { 9, "Mammoth Cave", 10, "KY", "National" },
                    { 10, "Glacier", 10, "MT", "National" },
                    { 11, "Goblin Valley", 10, "UT", "State" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

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
        }
    }
}
