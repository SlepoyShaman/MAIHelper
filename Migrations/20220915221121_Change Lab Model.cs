using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace maihelper.Migrations
{
    public partial class ChangeLabModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "LaboratoryWorks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "LaboratoryWorks",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
