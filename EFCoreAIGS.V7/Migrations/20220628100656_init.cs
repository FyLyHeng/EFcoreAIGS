using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAIGS.V7.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "TEST UUID"),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "Item TEST"),
                    ItemGroupId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_ItemGroup_ItemGroupId",
                        column: x => x.ItemGroupId,
                        principalTable: "ItemGroup",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ItemGroup",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"), "Drink" });

            migrationBuilder.InsertData(
                table: "ItemGroup",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d2"), "TEST-1" });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "ItemGroupId", "Name" },
                values: new object[] { new Guid("95254799-131c-43a9-88c8-39865a39e61c"), new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"), "Milk tea" });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "ItemGroupId", "Name" },
                values: new object[] { new Guid("b2cc35e8-ed6e-4b24-a793-726844cf52d7"), new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"), "Ice Coffee" });

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemGroupId",
                table: "Item",
                column: "ItemGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "ItemGroup");
        }
    }
}
