using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAIGS.Data.Migrations
{
    /// <inheritdoc />
    public partial class manyToManyChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spend_SpendingDetails_IncomeSpendId",
                table: "Spend");

            migrationBuilder.DropForeignKey(
                name: "FK_Spend_SpendingDetails_OutcomeSpendingDetailsId",
                table: "Spend");

            migrationBuilder.DropIndex(
                name: "IX_Spend_IncomeSpendId",
                table: "Spend");

            migrationBuilder.DropColumn(
                name: "IncomeSpendId",
                table: "Spend");

            migrationBuilder.RenameColumn(
                name: "OutcomeSpendId",
                table: "Spend",
                newName: "IncomeSpendingDetailsId");

            migrationBuilder.AlterColumn<int>(
                name: "OutcomeSpendingDetailsId",
                table: "Spend",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Spend_IncomeSpendingDetailsId",
                table: "Spend",
                column: "IncomeSpendingDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spend_SpendingDetails_IncomeSpendingDetailsId",
                table: "Spend",
                column: "IncomeSpendingDetailsId",
                principalTable: "SpendingDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spend_SpendingDetails_OutcomeSpendingDetailsId",
                table: "Spend",
                column: "OutcomeSpendingDetailsId",
                principalTable: "SpendingDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spend_SpendingDetails_IncomeSpendingDetailsId",
                table: "Spend");

            migrationBuilder.DropForeignKey(
                name: "FK_Spend_SpendingDetails_OutcomeSpendingDetailsId",
                table: "Spend");

            migrationBuilder.DropIndex(
                name: "IX_Spend_IncomeSpendingDetailsId",
                table: "Spend");

            migrationBuilder.RenameColumn(
                name: "IncomeSpendingDetailsId",
                table: "Spend",
                newName: "OutcomeSpendId");

            migrationBuilder.AlterColumn<int>(
                name: "OutcomeSpendingDetailsId",
                table: "Spend",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "IncomeSpendId",
                table: "Spend",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Spend_IncomeSpendId",
                table: "Spend",
                column: "IncomeSpendId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spend_SpendingDetails_IncomeSpendId",
                table: "Spend",
                column: "IncomeSpendId",
                principalTable: "SpendingDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spend_SpendingDetails_OutcomeSpendingDetailsId",
                table: "Spend",
                column: "OutcomeSpendingDetailsId",
                principalTable: "SpendingDetails",
                principalColumn: "Id");
        }
    }
}
