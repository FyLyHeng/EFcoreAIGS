using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAIGS.Data.Migrations
{
    /// <inheritdoc />
    public partial class manyToManyAddForeginKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spend_SpendingDetails_IncomeSpendingDetailsId",
                table: "Spend");

            migrationBuilder.DropForeignKey(
                name: "FK_Spend_SpendingDetails_OutcomeSpendingDetailsId",
                table: "Spend");

            migrationBuilder.AddForeignKey(
                name: "FK_Spend_SpendingDetails_IncomeSpendingDetailsId",
                table: "Spend",
                column: "IncomeSpendingDetailsId",
                principalTable: "SpendingDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spend_SpendingDetails_OutcomeSpendingDetailsId",
                table: "Spend",
                column: "OutcomeSpendingDetailsId",
                principalTable: "SpendingDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
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
    }
}
