using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCore.AIGS.UUID.Migrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
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
                keyValue: new Guid("585d99d4-a9b5-4e0a-b271-5d28854879a8"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("93f4d1c9-8c0f-406a-8b8c-40ef15178e8b"));

            migrationBuilder.DeleteData(
                table: "item_group",
                keyColumn: "id",
                keyValue: new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d3"));

            migrationBuilder.InsertData(
                table: "item_group",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"), "Drink" },
                    { new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d2"), "TEST-1" }
                });

            migrationBuilder.InsertData(
                table: "item",
                columns: new[] { "id", "item_group_id", "name" },
                values: new object[,]
                {
                    { new Guid("95254799-131c-43a9-88c8-39865a39e61c"), new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"), "Milk tea" },
                    { new Guid("b2cc35e8-ed6e-4b24-a793-726844cf52d7"), new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"), "Ice Coffee" }
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
                keyValue: new Guid("95254799-131c-43a9-88c8-39865a39e61c"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("b2cc35e8-ed6e-4b24-a793-726844cf52d7"));

            migrationBuilder.DeleteData(
                table: "item_group",
                keyColumn: "id",
                keyValue: new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d2"));

            migrationBuilder.DeleteData(
                table: "item_group",
                keyColumn: "id",
                keyValue: new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"));

            migrationBuilder.InsertData(
                table: "item_group",
                columns: new[] { "id", "name", "status" },
                values: new object[] { new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d3"), "Cake", false });

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
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
