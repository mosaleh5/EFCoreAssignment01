using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment01.Migrations
{
    /// <inheritdoc />
    public partial class InstructorTableToDepartmentRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Top_ID",
                table: "Courses",
                newName: "Top_Id");

            migrationBuilder.AlterColumn<int>(
                name: "Dep_id",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.CreateTable(
                name: "CourseInst",
                columns: table => new
                {
                    InstId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Evaluate = table.Column<decimal>(type: "decimal(5,2)", nullable: false, defaultValue: 0m),
                    InstructorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseInst", x => new { x.InstId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_CourseInst_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    HiringDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    InsManagerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instructor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BounsAmount = table.Column<decimal>(type: "decimal(18,2)", maxLength: 18, precision: 18, scale: 2, nullable: false, defaultValue: 0m),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    HoureRate = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false),
                    Dept_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_instructor_Department_Dept_Id",
                        column: x => x.Dept_Id,
                        principalTable: "Department",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_Dep_id",
                table: "Students",
                column: "Dep_id");

            migrationBuilder.CreateIndex(
                name: "IX_StudCourse_CourseId",
                table: "StudCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudCourse_StudentId",
                table: "StudCourse",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_Id",
                table: "Courses",
                column: "Top_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseInst_CourseId",
                table: "CourseInst",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseInst_InstructorId",
                table: "CourseInst",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_InsManagerId",
                table: "Department",
                column: "InsManagerId",
                unique: true,
                filter: "[InsManagerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_instructor_Dept_Id",
                table: "instructor",
                column: "Dept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_instructor_Id",
                table: "instructor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topices_Top_Id",
                table: "Courses",
                column: "Top_Id",
                principalTable: "Topices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Department_Dep_id",
                table: "Students",
                column: "Dep_id",
                principalTable: "Department",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInst_instructor_InstructorId",
                table: "CourseInst",
                column: "InstructorId",
                principalTable: "instructor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_instructor_InsManagerId",
                table: "Department",
                column: "InsManagerId",
                principalTable: "instructor",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topices_Top_Id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_Courses_CourseId",
                table: "StudCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_Students_StudentId",
                table: "StudCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Department_Dep_id",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_instructor_InsManagerId",
                table: "Department");

            migrationBuilder.DropTable(
                name: "CourseInst");

            migrationBuilder.DropTable(
                name: "instructor");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Students_Dep_id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_StudCourse_CourseId",
                table: "StudCourse");

            migrationBuilder.DropIndex(
                name: "IX_StudCourse_StudentId",
                table: "StudCourse");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_Id",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "StudCourse");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudCourse");

            migrationBuilder.RenameColumn(
                name: "Top_Id",
                table: "Courses",
                newName: "Top_ID");

            migrationBuilder.AlterColumn<int>(
                name: "Dep_id",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
