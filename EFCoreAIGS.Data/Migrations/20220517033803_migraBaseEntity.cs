using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAIGS.Data.Migrations
{
    /// <inheritdoc />
    public partial class migraBaseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SpendingDetailId",
                table: "SpendingDetails",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employees",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SpendingDetails",
                newName: "SpendingDetailId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employees",
                newName: "EmployeeId");
        }
    }
}
