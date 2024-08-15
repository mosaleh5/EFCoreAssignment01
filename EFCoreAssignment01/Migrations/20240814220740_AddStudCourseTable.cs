using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment01.Migrations
{
    /// <inheritdoc />
    public partial class AddStudCourseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudCourse",
                columns: table => new
                {
                    Stud_Id = table.Column<int>(type: "int", nullable: false),
                    Course_Id = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudCourse", x => new { x.Stud_Id, x.Course_Id });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudCourse");
        }
    }
}
