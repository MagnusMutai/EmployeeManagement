using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Api.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Email",
                value: "John@gmail.com");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "Gender", "LastName" },
                values: new object[] { "Linda@gmail.com", "Linda", 1, "Mills" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Harry@gmail.com", "Harry", "Long" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "Gender", "LastName" },
                values: new object[] { "Mary@gmail.com", "Mary", 1, "Jane" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Email", "FirstName", "Gender", "LastName" },
                values: new object[] { 3, "Eunice@gmail.com", "Eunice", 1, "Hepta" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Email", "FirstName", "LastName" },
                values: new object[] { 2, "Kelvin@gmail.com", "Kelvin", "Pokemon" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Email",
                value: "Mutaigilly02@gmail.com");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "Gender", "LastName" },
                values: new object[] { "Mutaigilly02@gmail.com", "John", 0, "Hastings" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Mutaigilly02@gmail.com", "John", "Hastings" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "Gender", "LastName" },
                values: new object[] { "Mutaigilly02@gmail.com", "John", 0, "Hastings" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Email", "FirstName", "Gender", "LastName" },
                values: new object[] { 5, "Mutaigilly02@gmail.com", "John", 0, "Hastings" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Email", "FirstName", "LastName" },
                values: new object[] { 6, "Mutaigilly02@gmail.com", "John", "Hastings" });
        }
    }
}
