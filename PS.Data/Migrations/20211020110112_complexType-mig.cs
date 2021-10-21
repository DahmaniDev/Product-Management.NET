using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class complexTypemig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetAdress",
                table: "Products",
                newName: "LabAddress_StreetAdress");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Products",
                newName: "LabAddress_City");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LabAddress_StreetAdress",
                table: "Products",
                newName: "StreetAdress");

            migrationBuilder.RenameColumn(
                name: "LabAddress_City",
                table: "Products",
                newName: "City");
        }
    }
}
