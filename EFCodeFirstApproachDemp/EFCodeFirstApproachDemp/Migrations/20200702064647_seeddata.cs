using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCodeFirstApproachDemp.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "CompanyName", "Department", "Designation", "EmployeeName", "Location", "Salary" },
                values: new object[] { 1, "Atos Syntel", "IT", "Consultant", "Nirmal Garg", "Pune", 5000f });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "CompanyName", "Department", "Designation", "EmployeeName", "Location", "Salary" },
                values: new object[] { 2, "CTS", "IT", "Consultant", "Neha Goyal", "Pune", 10000f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2);
        }
    }
}
