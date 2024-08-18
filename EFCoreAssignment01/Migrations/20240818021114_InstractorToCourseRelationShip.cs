using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment01.Migrations
{
    /// <inheritdoc />
    public partial class InstractorToCourseRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "CourseInst",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseInst_CourseId",
                table: "CourseInst",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseInst_InstructorId",
                table: "CourseInst",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInst_Courses_CourseId",
                table: "CourseInst",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInst_instructor_InstructorId",
                table: "CourseInst",
                column: "InstructorId",
                principalTable: "instructor",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseInst_Courses_CourseId",
                table: "CourseInst");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseInst_instructor_InstructorId",
                table: "CourseInst");

            migrationBuilder.DropIndex(
                name: "IX_CourseInst_CourseId",
                table: "CourseInst");

            migrationBuilder.DropIndex(
                name: "IX_CourseInst_InstructorId",
                table: "CourseInst");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "CourseInst");
        }
    }
}
