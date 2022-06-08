using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_delete_column_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImnageUrl2",
                table: "Portfolios",
                newName: "ImageUrl2");

            migrationBuilder.RenameColumn(
                name: "ImnageUrl",
                table: "Portfolios",
                newName: "ImageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl2",
                table: "Portfolios",
                newName: "ImnageUrl2");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Portfolios",
                newName: "ImnageUrl");
        }
    }
}
