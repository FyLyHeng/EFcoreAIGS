using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.AIGS.UUID.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "item_group",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    name = table.Column<string>(type: "text", nullable: false, defaultValue: "TEST UUID"),
                    status = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_item_group", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "item",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    name = table.Column<string>(type: "text", nullable: false, defaultValue: "Item TEST"),
                    item_group_id = table.Column<Guid>(type: "uuid", nullable: true),
                    status = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
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
