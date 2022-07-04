using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Migrations
{
    public partial class Seedwithrelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "DepartmentId", "Salary", "Title" },
                values: new object[] { 1, null, 20000.0, "Sales Associate" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "DepartmentId", "Salary", "Title" },
                values: new object[] { 2, null, 25000.0, "Sales Team Lead" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "ManagerId", "Name", "RoleId", "Salary" },
                values: new object[] { 1, null, "Howard Lima", 2, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "ManagerId", "Name", "RoleId", "Salary" },
                values: new object[] { 2, 1, "Todd Man", 1, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
