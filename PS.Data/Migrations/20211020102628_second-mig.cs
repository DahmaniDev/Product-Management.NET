using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class secondmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "imageUrl",
                table: "Products",
                newName: "imageUrl3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "imageUrl3",
                table: "Products",
                newName: "imageUrl");
        }
    }
}
