using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.AIGS.UUID.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_item_item_group_item_group_id",
                table: "item");

            migrationBuilder.AddForeignKey(
                name: "fk_item_item_group_item_group_id",
                table: "item",
                column: "item_group_id",
                principalTable: "item_group",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_item_item_group_item_group_id",
                table: "item");

            migrationBuilder.AddForeignKey(
                name: "fk_item_item_group_item_group_id",
                table: "item",
                column: "item_group_id",
                principalTable: "item_group",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
