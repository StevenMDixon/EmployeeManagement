using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Migrations
{
    public partial class AddingDepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_DepartmentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Role",
                newName: "Title");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Role",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Salary",
                table: "Role",
                type: "float",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Role_DepartmentId",
                table: "Role",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Role_Department_DepartmentId",
                table: "Role",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Role_Department_DepartmentId",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Role_DepartmentId",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Role");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Role",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id");
        }
    }
}
