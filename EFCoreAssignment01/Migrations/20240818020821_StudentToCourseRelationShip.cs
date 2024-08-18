using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment01.Migrations
{
    /// <inheritdoc />
    public partial class StudentToCourseRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "StudCourse",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "StudCourse",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudCourse_CourseId",
                table: "StudCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudCourse_StudentId",
                table: "StudCourse",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_Courses_CourseId",
                table: "StudCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_Students_StudentId",
                table: "StudCourse",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_Courses_CourseId",
                table: "StudCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_Students_StudentId",
                table: "StudCourse");

            migrationBuilder.DropIndex(
                name: "IX_StudCourse_CourseId",
                table: "StudCourse");

            migrationBuilder.DropIndex(
                name: "IX_StudCourse_StudentId",
                table: "StudCourse");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "StudCourse");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudCourse");
        }
    }
}
