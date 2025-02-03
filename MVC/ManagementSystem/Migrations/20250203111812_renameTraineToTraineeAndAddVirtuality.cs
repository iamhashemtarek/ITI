using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class renameTraineToTraineeAndAddVirtuality : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoursesResult_Traines_TraineeId",
                table: "CoursesResult");

            migrationBuilder.DropForeignKey(
                name: "FK_Traines_Department_DeptId",
                table: "Traines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Traines",
                table: "Traines");

            migrationBuilder.RenameTable(
                name: "Traines",
                newName: "Trainees");

            migrationBuilder.RenameIndex(
                name: "IX_Traines_DeptId",
                table: "Trainees",
                newName: "IX_Trainees_DeptId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trainees",
                table: "Trainees",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesResult_Trainees_TraineeId",
                table: "CoursesResult",
                column: "TraineeId",
                principalTable: "Trainees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Department_DeptId",
                table: "Trainees",
                column: "DeptId",
                principalTable: "Department",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoursesResult_Trainees_TraineeId",
                table: "CoursesResult");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Department_DeptId",
                table: "Trainees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trainees",
                table: "Trainees");

            migrationBuilder.RenameTable(
                name: "Trainees",
                newName: "Traines");

            migrationBuilder.RenameIndex(
                name: "IX_Trainees_DeptId",
                table: "Traines",
                newName: "IX_Traines_DeptId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Traines",
                table: "Traines",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesResult_Traines_TraineeId",
                table: "CoursesResult",
                column: "TraineeId",
                principalTable: "Traines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Traines_Department_DeptId",
                table: "Traines",
                column: "DeptId",
                principalTable: "Department",
                principalColumn: "Id");
        }
    }
}
