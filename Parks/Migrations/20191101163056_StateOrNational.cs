using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class StateOrNational : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Parks");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Parks",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Parks",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StateOrNational",
                table: "Parks",
                maxLength: 8,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StateOrNational",
                table: "Parks");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Parks",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Parks",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Parks",
                nullable: true);
        }
    }
}
