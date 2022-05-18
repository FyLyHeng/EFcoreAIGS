using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EFCoreAIGS.Data.Migrations
{
    /// <inheritdoc />
    public partial class manyToManyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spend",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IncomeSpendId = table.Column<int>(type: "integer", nullable: false),
                    OutcomeSpendId = table.Column<int>(type: "integer", nullable: false),
                    OutcomeSpendingDetailsId = table.Column<int>(type: "integer", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spend", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spend_SpendingDetails_IncomeSpendId",
                        column: x => x.IncomeSpendId,
                        principalTable: "SpendingDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spend_SpendingDetails_OutcomeSpendingDetailsId",
                        column: x => x.OutcomeSpendingDetailsId,
                        principalTable: "SpendingDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Spend_IncomeSpendId",
                table: "Spend",
                column: "IncomeSpendId");

            migrationBuilder.CreateIndex(
                name: "IX_Spend_OutcomeSpendingDetailsId",
                table: "Spend",
                column: "OutcomeSpendingDetailsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spend");
        }
    }
}
