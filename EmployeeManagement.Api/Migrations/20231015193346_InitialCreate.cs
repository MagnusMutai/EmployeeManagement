using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagement.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "Payroll" },
                    { 4, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mutaigilly02@gmail.com", "John", 0, "Hastings", "/Images/JohnJameson.jpg" },
                    { 2, new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Mutaigilly02@gmail.com", "John", 0, "Hastings", "/Images/JennyMarks.jpg" },
                    { 3, new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Mutaigilly02@gmail.com", "John", 0, "Hastings", "/Images/MaleDefault.jpg" },
                    { 4, new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Mutaigilly02@gmail.com", "John", 0, "Hastings", "/Images/NoahRobinson.jpg" },
                    { 5, new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Mutaigilly02@gmail.com", "John", 0, "Hastings", "/Images/OliviaMills.jpg" },
                    { 6, new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Mutaigilly02@gmail.com", "John", 0, "Hastings", "/Images/Profile5_Woman.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
