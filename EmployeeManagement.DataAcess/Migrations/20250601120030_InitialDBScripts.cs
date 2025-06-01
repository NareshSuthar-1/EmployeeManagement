using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagement.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialDBScripts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IFSCCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankAccounts_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "New York", "Human Resources" },
                    { 2, "Chicago", "Finance" },
                    { 3, "San Francisco", "IT" },
                    { 4, "Los Angeles", "Marketing" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "DepartmentId", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, 29, 1, "Alice Johnson", 75000.00m },
                    { 2, 35, 2, "Bob Smith", 62000.00m },
                    { 3, 42, 3, "Carol Davis", 88000.00m },
                    { 4, 31, 4, "David Lee", 54000.00m }
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "AccountNumber", "AccountType", "BankName", "BranchName", "CreatedOn", "Currency", "DeletedOn", "EmployeeId", "IFSCCode", "IsActive" },
                values: new object[,]
                {
                    { 1, "1234567890", "Savings", "HDFC Bank", "Mumbai Main", new DateTime(2024, 12, 1, 5, 0, 28, 803, DateTimeKind.Local).AddTicks(4188), "INR", null, 1, "HDFC0001234", 1 },
                    { 2, "9876543210", "Current", "State Bank of India", "Delhi Branch", new DateTime(2024, 6, 1, 5, 0, 28, 803, DateTimeKind.Local).AddTicks(4303), "INR", null, 2, "SBIN0005678", 1 },
                    { 3, "1122334455", "Savings", "ICICI Bank", "Pune Central", new DateTime(2024, 6, 1, 5, 0, 28, 803, DateTimeKind.Local).AddTicks(4316), "INR", null, 3, "ICIC0002468", 0 },
                    { 4, "5566778899", "Current", "Axis Bank", "Chennai South", new DateTime(2025, 5, 2, 5, 0, 28, 803, DateTimeKind.Local).AddTicks(4329), "INR", null, 1, "UTIB0007890", 1 },
                    { 5, "BOA99887766", "Checking", "Bank of America", "New York HQ", new DateTime(2023, 6, 1, 5, 0, 28, 803, DateTimeKind.Local).AddTicks(4341), "USD", null, 2, "BOFA0USA123", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_EmployeeId",
                table: "BankAccounts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
