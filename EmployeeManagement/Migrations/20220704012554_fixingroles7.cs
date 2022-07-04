using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Migrations
{
    public partial class fixingroles7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Name", "RoleId", "Salary" },
                values: new object[] { 3, "Amanda Lima", 2, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Name", "RoleId", "Salary" },
                values: new object[] { 1, "Howard Lima", 2, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Name", "RoleId", "Salary" },
                values: new object[] { 2, "Todd Man", 1, null });
        }
    }
}
