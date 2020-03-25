using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectV2.Migrations
{
    public partial class IdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductSpec",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductSpec");
        }
    }
}
