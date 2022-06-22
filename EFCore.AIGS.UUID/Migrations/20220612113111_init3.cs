using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCore.AIGS.UUID.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_item_item_group_item_group_id",
                table: "item");

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("9747ba54-88fe-46ed-bcaa-f874ff7af56d"));

            migrationBuilder.InsertData(
                table: "item",
                columns: new[] { "id", "item_group_id", "name" },
                values: new object[,]
                {
                    { new Guid("585d99d4-a9b5-4e0a-b271-5d28854879a8"), new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d3"), "HBD cake" },
                    { new Guid("93f4d1c9-8c0f-406a-8b8c-40ef15178e8b"), new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d3"), "Broken cake" }
                });

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

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("585d99d4-a9b5-4e0a-b271-5d28854879a8"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("93f4d1c9-8c0f-406a-8b8c-40ef15178e8b"));

            migrationBuilder.InsertData(
                table: "item",
                columns: new[] { "id", "item_group_id", "name", "status" },
                values: new object[] { new Guid("9747ba54-88fe-46ed-bcaa-f874ff7af56d"), new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d3"), "HDB cake", false });

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
