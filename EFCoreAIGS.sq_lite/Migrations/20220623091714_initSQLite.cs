using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCore.AIGS.SQLITE.Migrations
{
    /// <inheritdoc />
    public partial class initSQLite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "item_group",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    name = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "TEST UUID"),
                    status = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_item_group", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "item",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    name = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "Item TEST"),
                    item_group_id = table.Column<Guid>(type: "TEXT", nullable: true),
                    status = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_item", x => x.id);
                    table.ForeignKey(
                        name: "fk_item_item_group_item_group_id",
                        column: x => x.item_group_id,
                        principalTable: "item_group",
                        principalColumn: "id");
                });

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

            migrationBuilder.CreateIndex(
                name: "ix_item_item_group_id",
                table: "item",
                column: "item_group_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "item");

            migrationBuilder.DropTable(
                name: "item_group");
        }
    }
}
