using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace maihelper.Migrations
{
    public partial class checkingnewdatabases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_laboratoryWorks_Subjects_SubjectId",
                table: "laboratoryWorks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_laboratoryWorks",
                table: "laboratoryWorks");

            migrationBuilder.RenameTable(
                name: "laboratoryWorks",
                newName: "LaboratoryWorks");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "LaboratoryWorks",
                newName: "Theme");

            migrationBuilder.RenameIndex(
                name: "IX_laboratoryWorks_SubjectId",
                table: "LaboratoryWorks",
                newName: "IX_LaboratoryWorks_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LaboratoryWorks",
                table: "LaboratoryWorks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Theme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_Subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Theme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notes_SubjectID",
                table: "Notes",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SubjectId",
                table: "Tickets",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_LaboratoryWorks_Subjects_SubjectId",
                table: "LaboratoryWorks",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LaboratoryWorks_Subjects_SubjectId",
                table: "LaboratoryWorks");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LaboratoryWorks",
                table: "LaboratoryWorks");

            migrationBuilder.RenameTable(
                name: "LaboratoryWorks",
                newName: "laboratoryWorks");

            migrationBuilder.RenameColumn(
                name: "Theme",
                table: "laboratoryWorks",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_LaboratoryWorks_SubjectId",
                table: "laboratoryWorks",
                newName: "IX_laboratoryWorks_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_laboratoryWorks",
                table: "laboratoryWorks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_laboratoryWorks_Subjects_SubjectId",
                table: "laboratoryWorks",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
