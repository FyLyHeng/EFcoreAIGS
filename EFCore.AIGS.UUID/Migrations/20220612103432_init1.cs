using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCore.AIGS.UUID.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("02a921d2-2187-4878-ac8a-4215a80260f7"), new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"), "Ice Coffee" },
                    { new Guid("d37960c4-b81f-4bdb-9162-4a2620842569"), new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"), "Milk tea" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("02a921d2-2187-4878-ac8a-4215a80260f7"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("d37960c4-b81f-4bdb-9162-4a2620842569"));

            migrationBuilder.DeleteData(
                table: "item_group",
                keyColumn: "id",
                keyValue: new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d2"));

            migrationBuilder.DeleteData(
                table: "item_group",
                keyColumn: "id",
                keyValue: new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"));
        }
    }
}
