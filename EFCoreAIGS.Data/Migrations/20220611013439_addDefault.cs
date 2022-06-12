using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAIGS.Data.Migrations
{
    /// <inheritdoc />
    public partial class addDefault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "spending_details",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "spend",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "employees",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "credit_card",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "spending_details");

            migrationBuilder.DropColumn(
                name: "status",
                table: "spend");

            migrationBuilder.DropColumn(
                name: "status",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "status",
                table: "credit_card");
        }
    }
}
