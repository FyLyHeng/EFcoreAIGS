using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCore.AIGS.UUID.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "item_group",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d3"), "Cake" });

            migrationBuilder.InsertData(
                table: "item",
                columns: new[] { "id", "item_group_id", "name" },
                values: new object[] { new Guid("9747ba54-88fe-46ed-bcaa-f874ff7af56d"), new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d3"), "HDB cake" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "id",
                keyValue: new Guid("9747ba54-88fe-46ed-bcaa-f874ff7af56d"));

            migrationBuilder.DeleteData(
                table: "item_group",
                keyColumn: "id",
                keyValue: new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d3"));

            migrationBuilder.InsertData(
                table: "item_group",
                columns: new[] { "id", "name", "status" },
                values: new object[,]
                {
                    { new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"), "Drink", false },
                    { new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d2"), "TEST-1", false }
                });

            migrationBuilder.InsertData(
                table: "item",
                columns: new[] { "id", "item_group_id", "name", "status" },
                values: new object[,]
                {
                    { new Guid("02a921d2-2187-4878-ac8a-4215a80260f7"), new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"), "Ice Coffee", false },
                    { new Guid("d37960c4-b81f-4bdb-9162-4a2620842569"), new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"), "Milk tea", false }
                });
        }
    }
}
