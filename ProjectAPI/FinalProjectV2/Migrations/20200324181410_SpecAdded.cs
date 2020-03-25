using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectV2.Migrations
{
    public partial class SpecAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Specification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSpec",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    SpecificationId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpec", x => new { x.SpecificationId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductSpec_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSpec_Specification_SpecificationId",
                        column: x => x.SpecificationId,
                        principalTable: "Specification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpec_ProductId",
                table: "ProductSpec",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSpec");

            migrationBuilder.DropTable(
                name: "Specification");
        }
    }
}
