using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class StillMoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Parks",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                column: "Name",
                value: "SamuelPTaylor");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5,
                column: "Rating",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7,
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9,
                column: "Rating",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 16,
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 28,
                column: "Rating",
                value: 6);

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "Rating", "State", "StateOrNational" },
                values: new object[,]
                {
                    { 42, "Great Basin", 6, "NV", "National" },
                    { 43, "Great Sand Dunes", 9, "CO", "National" },
                    { 44, "High Falls", 6, "GA", "National" },
                    { 48, "Petrified Forest", 9, "AZ", "National" },
                    { 46, "Katmai", 8, "AK", "National" },
                    { 47, "Olympic", 10, "WA", "National" },
                    { 41, "Gates of the Arctic", 10, "AK", "National" },
                    { 45, "Isle Royale", 7, "MI", "National" },
                    { 40, "Green River Resevoir", 3, "VT", "State" },
                    { 36, "Oak Mountain", 6, "AL", "State" },
                    { 38, "Burlingame", 9, "RI", "State" },
                    { 37, "Borderland", 8, "MA", "State" },
                    { 49, "Wind Cave", 3, "SD", "National" },
                    { 35, "Everglades", 7, "FL", "National" },
                    { 34, "Cuyahoga Valley", 4, "OH", "National" },
                    { 33, "Biscayne", 5, "FL", "National" },
                    { 32, "Acadia", 7, "ME", "National" },
                    { 31, "DeSoto", 2, "AL", "State" },
                    { 39, "Camel's Hump", 10, "VT", "State" },
                    { 50, "Indiana Dunes", 4, "IN", "State" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Parks",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 40);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                column: "Name",
                value: "Samuel P. Taylor");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                column: "Rating",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5,
                column: "Rating",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                column: "Rating",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7,
                column: "Rating",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9,
                column: "Rating",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 16,
                column: "Rating",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 28,
                column: "Rating",
                value: 10);
        }
    }
}
