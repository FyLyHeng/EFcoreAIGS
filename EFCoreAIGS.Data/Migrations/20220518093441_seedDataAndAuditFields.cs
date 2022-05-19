using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAIGS.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedDataAndAuditFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "SpendingDetails",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "SpendingDetails",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateBy",
                table: "SpendingDetails",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                table: "SpendingDetails",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Spend",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Spend",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateBy",
                table: "Spend",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Spend",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Employees",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Employees",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateBy",
                table: "Employees",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Employees",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "CreditCard",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "CreditCard",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateBy",
                table: "CreditCard",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                table: "CreditCard",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreateBy", "CreatedDate", "FirstName", "Hired", "LastName", "LastUpdateBy", "LastUpdateDate" },
                values: new object[] { 1, null, null, "default first name", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "default last name", null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "SpendingDetails");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "SpendingDetails");

            migrationBuilder.DropColumn(
                name: "LastUpdateBy",
                table: "SpendingDetails");

            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                table: "SpendingDetails");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Spend");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Spend");

            migrationBuilder.DropColumn(
                name: "LastUpdateBy",
                table: "Spend");

            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                table: "Spend");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastUpdateBy",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "LastUpdateBy",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                table: "CreditCard");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
