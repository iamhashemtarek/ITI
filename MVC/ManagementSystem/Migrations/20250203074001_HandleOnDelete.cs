using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class HandleOnDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Department_DeptId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseResult_Course_CourseId",
                table: "CourseResult");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseResult_Trainee_TraineeId",
                table: "CourseResult");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_ManagerId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Course_CourseId",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Department_DeptId",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainee_Department_DeptId",
                table: "Trainee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trainee",
                table: "Trainee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseResult",
                table: "CourseResult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Trainee",
                newName: "Traines");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors");

            migrationBuilder.RenameTable(
                name: "CourseResult",
                newName: "CoursesResult");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_Trainee_DeptId",
                table: "Traines",
                newName: "IX_Traines_DeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_DeptId",
                table: "Instructors",
                newName: "IX_Instructors_DeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_CourseId",
                table: "Instructors",
                newName: "IX_Instructors_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseResult_TraineeId",
                table: "CoursesResult",
                newName: "IX_CoursesResult_TraineeId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseResult_CourseId",
                table: "CoursesResult",
                newName: "IX_CoursesResult_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_DeptId",
                table: "Courses",
                newName: "IX_Courses_DeptId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Traines",
                table: "Traines",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoursesResult",
                table: "CoursesResult",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Department_DeptId",
                table: "Courses",
                column: "DeptId",
                principalTable: "Department",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesResult_Courses_CourseId",
                table: "CoursesResult",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesResult_Traines_TraineeId",
                table: "CoursesResult",
                column: "TraineeId",
                principalTable: "Traines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructors_ManagerId",
                table: "Department",
                column: "ManagerId",
                principalTable: "Instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_CourseId",
                table: "Instructors",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Department_DeptId",
                table: "Instructors",
                column: "DeptId",
                principalTable: "Department",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Traines_Department_DeptId",
                table: "Traines",
                column: "DeptId",
                principalTable: "Department",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Department_DeptId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CoursesResult_Courses_CourseId",
                table: "CoursesResult");

            migrationBuilder.DropForeignKey(
                name: "FK_CoursesResult_Traines_TraineeId",
                table: "CoursesResult");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructors_ManagerId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_CourseId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Department_DeptId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Traines_Department_DeptId",
                table: "Traines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Traines",
                table: "Traines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoursesResult",
                table: "CoursesResult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Traines",
                newName: "Trainee");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor");

            migrationBuilder.RenameTable(
                name: "CoursesResult",
                newName: "CourseResult");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_Traines_DeptId",
                table: "Trainee",
                newName: "IX_Trainee_DeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_DeptId",
                table: "Instructor",
                newName: "IX_Instructor_DeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_CourseId",
                table: "Instructor",
                newName: "IX_Instructor_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CoursesResult_TraineeId",
                table: "CourseResult",
                newName: "IX_CourseResult_TraineeId");

            migrationBuilder.RenameIndex(
                name: "IX_CoursesResult_CourseId",
                table: "CourseResult",
                newName: "IX_CourseResult_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_DeptId",
                table: "Course",
                newName: "IX_Course_DeptId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trainee",
                table: "Trainee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseResult",
                table: "CourseResult",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Department_DeptId",
                table: "Course",
                column: "DeptId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseResult_Course_CourseId",
                table: "CourseResult",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseResult_Trainee_TraineeId",
                table: "CourseResult",
                column: "TraineeId",
                principalTable: "Trainee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_ManagerId",
                table: "Department",
                column: "ManagerId",
                principalTable: "Instructor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Course_CourseId",
                table: "Instructor",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Department_DeptId",
                table: "Instructor",
                column: "DeptId",
                principalTable: "Department",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainee_Department_DeptId",
                table: "Trainee",
                column: "DeptId",
                principalTable: "Department",
                principalColumn: "Id");
        }
    }
}
