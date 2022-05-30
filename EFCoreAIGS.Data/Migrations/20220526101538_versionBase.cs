using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAIGS.Data.Migrations
{
    /// <inheritdoc />
    public partial class versionBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Version",
                table: "SpendingDetails",
                type: "bigint",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<long>(
                name: "Version",
                table: "Spend",
                type: "bigint",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<long>(
                name: "Version",
                table: "Employees",
                type: "bigint",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<long>(
                name: "Version",
                table: "CreditCard",
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
            migrationBuilder.AlterColumn<int>(
                name: "Version",
                table: "SpendingDetails",
                type: "integer",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<int>(
                name: "Version",
                table: "Spend",
                type: "integer",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<int>(
                name: "Version",
                table: "Employees",
                type: "integer",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<int>(
                name: "Version",
                table: "CreditCard",
                type: "integer",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldRowVersion: true);
        }
    }
}
