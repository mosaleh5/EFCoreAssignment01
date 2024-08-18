using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment01.Migrations
{
    /// <inheritdoc />
    public partial class InstractorToDepartmentManagerRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "instructor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsManagerId",
                table: "Department",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_instructor_DepartmentId",
                table: "instructor",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_InsManagerId",
                table: "Department",
                column: "InsManagerId",
                unique: true,
                filter: "[InsManagerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_instructor_InsManagerId",
                table: "Department",
                column: "InsManagerId",
                principalTable: "instructor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_instructor_Department_DepartmentId",
                table: "instructor",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_instructor_InsManagerId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_instructor_Department_DepartmentId",
                table: "instructor");

            migrationBuilder.DropIndex(
                name: "IX_instructor_DepartmentId",
                table: "instructor");

            migrationBuilder.DropIndex(
                name: "IX_Department_InsManagerId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "instructor");

            migrationBuilder.DropColumn(
                name: "InsManagerId",
                table: "Department");
        }
    }
}
