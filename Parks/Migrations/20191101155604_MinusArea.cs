using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class MinusArea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Parks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Area",
                table: "Parks",
                nullable: false,
                defaultValue: 0);
        }
    }
}
