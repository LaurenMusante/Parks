using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class CityState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Parks",
                newName: "State");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Parks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Parks");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Parks",
                newName: "Location");
        }
    }
}
