using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment01.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseInstTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseInst",
                columns: table => new
                {
                    InstId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Evaluate = table.Column<decimal>(type: "decimal(5,2)", nullable: false, defaultValue: 0m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseInst", x => new { x.InstId, x.CourseId });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseInst");
        }
    }
}
