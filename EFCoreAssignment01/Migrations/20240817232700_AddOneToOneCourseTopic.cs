using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment01.Migrations
{
    /// <inheritdoc />
    public partial class AddOneToOneCourseTopic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "instructor");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_Id",
                table: "instructor",
                newName: "IX_instructor_Id");

            migrationBuilder.RenameColumn(
                name: "Top_ID",
                table: "Courses",
                newName: "Top_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_instructor",
                table: "instructor",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_Id",
                table: "Courses",
                column: "Top_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topices_Top_Id",
                table: "Courses",
                column: "Top_Id",
                principalTable: "Topices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topices_Top_Id",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_instructor",
                table: "instructor");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_Id",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "instructor",
                newName: "Instructor");

            migrationBuilder.RenameIndex(
                name: "IX_instructor_Id",
                table: "Instructor",
                newName: "IX_Instructor_Id");

            migrationBuilder.RenameColumn(
                name: "Top_Id",
                table: "Courses",
                newName: "Top_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "Id");
        }
    }
}
