using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EFCoreAIGS.erp.Migrations
{
    /// <inheritdoc />
    public partial class initERPAudit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:pg_catalog.adminpack", ",,");

            migrationBuilder.CreateTable(
                name: "gender",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_by_id = table.Column<long>(type: "bigint", nullable: true),
                    date_created = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    status = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "true"),
                    last_updated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_by_id = table.Column<long>(type: "bigint", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true),
                    gender = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    base_custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    base_series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gender", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_by_id = table.Column<long>(type: "bigint", nullable: true),
                    date_created = table.Column<DateTime>(type: "timestamp(6) without time zone", nullable: true),
                    status = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "true"),
                    last_updated = table.Column<DateTime>(type: "timestamp(6) without time zone", nullable: true),
                    updated_by_id = table.Column<long>(type: "bigint", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    role_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    base_custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    base_series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_by_id = table.Column<long>(type: "bigint", nullable: true),
                    date_created = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    status = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "true"),
                    last_updated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updated_by_id = table.Column<long>(type: "bigint", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true),
                    is_admin = table.Column<bool>(type: "boolean", nullable: false),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    image_path = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    password = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    phone = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    username = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    branch_id = table.Column<long>(type: "bigint", nullable: true),
                    base_custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    base_series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_role",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_by_id = table.Column<long>(type: "bigint", nullable: true),
                    date_created = table.Column<DateTime>(type: "timestamp(6) without time zone", nullable: true),
                    status = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "true"),
                    last_updated = table.Column<DateTime>(type: "timestamp(6) without time zone", nullable: true),
                    updated_by_id = table.Column<long>(type: "bigint", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true),
                    role_id = table.Column<long>(type: "bigint", nullable: false),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    base_custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    base_series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "fka68196081fvovjhkek5m97n3y",
                        column: x => x.role_id,
                        principalTable: "role",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkj345gk1bovqvfame88rcx7yyx",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_user_role_role_id",
                table: "user_role",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_role_user_id",
                table: "user_role",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gender");

            migrationBuilder.DropTable(
                name: "user_role");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
