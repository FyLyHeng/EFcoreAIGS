using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAIGS.Data.Migrations
{
    /// <inheritdoc />
    public partial class removeEmpConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employees_Id",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "version",
                table: "Employees",
                newName: "Version");

            migrationBuilder.AlterColumn<long>(
                name: "Version",
                table: "Employees",
                type: "bigint",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldRowVersion: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Version",
                table: "Employees",
                newName: "version");

            migrationBuilder.AlterColumn<int>(
                name: "version",
                table: "Employees",
                type: "integer",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldRowVersion: true);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreateBy", "CreatedDate", "FirstName", "Hired", "LastName", "LastUpdateBy", "LastUpdateDate" },
                values: new object[] { 1, null, null, "default first name", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "default last name", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Id",
                table: "Employees",
                column: "Id",
                unique: true);
        }
    }
}
