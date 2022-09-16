using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace maihelper.Migrations
{
    public partial class testinitializer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Directions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Directions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LaboratoryWorks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LaboratoryWorks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Directions",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { 1, "09.03.04" },
                    { 2, "09.03.02" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Программирование" },
                    { 2, "Дискретная математика" }
                });

            migrationBuilder.InsertData(
                table: "LaboratoryWorks",
                columns: new[] { "Id", "Author", "DownloadFile", "Listing", "OptionLab", "SubjectId", "Teacher", "Theme", "Views" },
                values: new object[,]
                {
                    { 1, "Denis", null, "./path", 1, 1, "Чечиков Ю.Б.", "Вычисление суммы бесконечного числового ряда", 0 },
                    { 2, "SlepoyShaman", null, "./path", 1, 1, "Чечиков Ю.Б.", "Табулирование функций", 0 }
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "SubjectId", "Theme" },
                values: new object[,]
                {
                    { 1, 1, "Определение алгоритма и первая лабораторная работа" },
                    { 2, 1, "Указатели на массивы и функции" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "SubjectId", "Theme" },
                values: new object[,]
                {
                    { 1, 1, "Понятие алгоритма" },
                    { 2, 1, "Понятие языка программирования" }
                });
        }
    }
}
