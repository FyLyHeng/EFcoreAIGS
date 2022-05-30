using System;
using System.Collections;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EFCoreAIGS.EF_ERP.Migrations
{
    /// <inheritdoc />
    public partial class initMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "account_setup_payable",
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
                    gl_account_payable = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account_setup_payable", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "account_type",
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
                    account_type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "address_type",
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
                    type = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "balance",
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
                    balance_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_balance", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "balance_side",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_balance_side", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "barcode_type",
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
                    barcode_type_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_barcode_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "branch",
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
                    abbr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    branch_code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    branch_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    branch_name_kh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    city_province = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    phone = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branch", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "city",
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
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "country",
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
                    country_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "currency",
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
                    currency = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    currency_code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    is_used = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_currency", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "data_source_config",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    value = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    is_active = table.Column<BitArray>(type: "bit(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data_source_config", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "delivery_type",
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
                    description = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_delivery_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "document_setting",
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
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    is_different_prefix = table.Column<bool>(type: "boolean", nullable: true),
                    is_different_sequence = table.Column<bool>(type: "boolean", nullable: true),
                    last_code = table.Column<int>(type: "integer", nullable: true),
                    length = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    non_vat_last_code = table.Column<int>(type: "integer", nullable: true),
                    non_vat_prefix = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    non_vat_suffix = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    prefix = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    suffix = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_document_setting", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "domain",
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
                    domain = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_domain", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "driver_status",
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
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_driver_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "employee_type",
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
                    employee_type = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "expanse_category",
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
                    description = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_expanse_category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "feature",
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
                    feature_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    feature_order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feature", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "finance_book",
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
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_finance_book", x => x.id);
                });

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
                    gender = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gender", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "global_search",
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
                    description = table.Column<string>(type: "text", nullable: true),
                    doc_type = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    routing = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    target_id = table.Column<long>(type: "bigint", nullable: true),
                    title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_global_search", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "health_insurance",
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
                    health_insurance_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_health_insurance", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "holiday",
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
                    holiday_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    holiday_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_holiday", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "item_attribute",
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
                    attribute_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_attribute", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "item_brand",
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
                    brand_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_brand", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "item_group",
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
                    is_group = table.Column<bool>(type: "boolean", nullable: true),
                    group_name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    parent_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_group", x => x.id);
                    table.ForeignKey(
                        name: "fkh0gygywjj17k1o53qhp4xf30r",
                        column: x => x.parent_id,
                        principalTable: "item_group",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "letter_head",
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
                    letter_head_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_letter_head", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "material_request_type",
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
                    type_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_material_request_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "menu_item",
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
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    is_disable = table.Column<bool>(type: "boolean", nullable: false),
                    is_group_title = table.Column<bool>(type: "boolean", nullable: false),
                    closable = table.Column<bool>(type: "boolean", nullable: true),
                    color = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    external_link = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    icon_class = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    icon_bg = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    icon_color = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    menu_order = table.Column<int>(type: "integer", nullable: true),
                    parent_id = table.Column<long>(type: "bigint", nullable: true),
                    routing = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    selected = table.Column<bool>(type: "boolean", nullable: true),
                    title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu_item", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "miscellaneous",
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
                    code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    is_default = table.Column<bool>(type: "boolean", nullable: false),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    type = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_miscellaneous", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "payment_method",
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
                    method = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment_method", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "province",
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
                    province = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    provid = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    province_kh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_province", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "purchase_hold_invoice",
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
                    reason = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    release_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_hold_invoice", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "role",
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
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    role_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sale_tax_type",
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
                    type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sale_tax_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "supplier_group",
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
                    is_group = table.Column<bool>(type: "boolean", nullable: true),
                    group_name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    parent_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplier_group", x => x.id);
                    table.ForeignKey(
                        name: "fk7n6ugl6r3fnvug1li4j75yiai",
                        column: x => x.parent_id,
                        principalTable: "supplier_group",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "supplier_type",
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
                    type = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplier_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "term_condition",
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
                    is_disable = table.Column<bool>(type: "boolean", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_term_condition", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "territory",
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
                    is_group = table.Column<bool>(type: "boolean", nullable: true),
                    territory_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    parent_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_territory", x => x.id);
                    table.ForeignKey(
                        name: "fk7nloh1mltgwne5y78ttnr31s1",
                        column: x => x.parent_id,
                        principalTable: "territory",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "transaction_type",
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
                    code = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true),
                    trxn_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "uom",
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
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    is_used = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uom", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "valuation_method",
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
                    method_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_valuation_method", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "account_class",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    class_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    balance_side_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account_class", x => x.id);
                    table.ForeignKey(
                        name: "fk5vw2hd45fnso4weofdq950s1l",
                        column: x => x.balance_side_id,
                        principalTable: "balance_side",
                        principalColumn: "id");
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
                    branch_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                    table.ForeignKey(
                        name: "fkixo09sv3j1j6hfox3cx6d2ggg",
                        column: x => x.branch_id,
                        principalTable: "branch",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "price_list",
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
                    is_buying = table.Column<bool>(type: "boolean", nullable: true),
                    enable = table.Column<bool>(type: "boolean", nullable: true),
                    is_selling = table.Column<bool>(type: "boolean", nullable: true),
                    price_list_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    currency_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_price_list", x => x.id);
                    table.ForeignKey(
                        name: "fkc06v5ro9p64ywvhc589nhaygn",
                        column: x => x.currency_id,
                        principalTable: "currency",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "permission",
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
                    function_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    function_order = table.Column<int>(type: "integer", nullable: false),
                    feature_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permission", x => x.id);
                    table.ForeignKey(
                        name: "fkjgkobdkd3ujnxlvrtpf19x68j",
                        column: x => x.feature_id,
                        principalTable: "feature",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "salutation",
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
                    salutation = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    gender_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salutation", x => x.id);
                    table.ForeignKey(
                        name: "fk1vf62tr3xbb80r9r7wvnacqts",
                        column: x => x.gender_id,
                        principalTable: "gender",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "item_attribute_detail",
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
                    abbreviation = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    attribute_value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    item_attribute_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_attribute_detail", x => x.id);
                    table.ForeignKey(
                        name: "fkceojhsp72n0ex7mpjx0k6074",
                        column: x => x.item_attribute_id,
                        principalTable: "item_attribute",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "district",
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
                    district = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    distid = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    district_kh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    province_code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    province_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_district", x => x.id);
                    table.ForeignKey(
                        name: "fk276utu38g5lgqeth6pwfm3rw2",
                        column: x => x.province_id,
                        principalTable: "province",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "role_menu",
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
                    menu_item_id = table.Column<long>(type: "bigint", nullable: false),
                    role_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role_menu", x => x.id);
                    table.ForeignKey(
                        name: "fk6829se8jshcx4di58icvqvh9q",
                        column: x => x.menu_item_id,
                        principalTable: "menu_item",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkqyvxw2gg2qk0wld3bqfcb58vq",
                        column: x => x.role_id,
                        principalTable: "role",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "supplier",
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
                    address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    contact_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    contact_phone = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    prepayment_balance = table.Column<double>(type: "double precision", nullable: true),
                    supplier_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    vat = table.Column<int>(type: "integer", nullable: true),
                    supplier_group_id = table.Column<long>(type: "bigint", nullable: true),
                    supplier_type_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplier", x => x.id);
                    table.ForeignKey(
                        name: "fkesu19c23q6lq24pou4hk02fxl",
                        column: x => x.supplier_group_id,
                        principalTable: "supplier_group",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fki8frtsnt5d9v8bljvk9ce7e49",
                        column: x => x.supplier_type_id,
                        principalTable: "supplier_type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "journal_entry",
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
                    adjusting = table.Column<bool>(type: "boolean", nullable: true),
                    b_status = table.Column<int>(type: "integer", nullable: true),
                    can_reverse = table.Column<bool>(type: "boolean", nullable: true),
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    entry_no = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    journal_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    journal_type = table.Column<int>(type: "integer", nullable: true),
                    total_credit = table.Column<double>(type: "double precision", nullable: true),
                    total_debit = table.Column<double>(type: "double precision", nullable: true),
                    branch_id = table.Column<long>(type: "bigint", nullable: true),
                    currency_id = table.Column<long>(type: "bigint", nullable: true),
                    trxn_type_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_journal_entry", x => x.id);
                    table.ForeignKey(
                        name: "fk9vvudw1ifwc61ur2wq6sg8kso",
                        column: x => x.currency_id,
                        principalTable: "currency",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkbnb3pu15kojh5fnvt4sg1h6xs",
                        column: x => x.branch_id,
                        principalTable: "branch",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkcfyxo2h09ja6mfhua00pxu47i",
                        column: x => x.trxn_type_id,
                        principalTable: "transaction_type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "item",
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
                    has_batch_no = table.Column<bool>(type: "boolean", nullable: true),
                    has_serial_no = table.Column<bool>(type: "boolean", nullable: true),
                    barcode = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    cost = table.Column<double>(type: "double precision", nullable: true),
                    delivery_fee = table.Column<double>(type: "double precision", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    end_of_life = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    is_disable = table.Column<bool>(type: "boolean", nullable: true),
                    is_fix_asset = table.Column<bool>(type: "boolean", nullable: true),
                    is_maintain_stock = table.Column<bool>(type: "boolean", nullable: true),
                    is_sale_item = table.Column<bool>(type: "boolean", nullable: true),
                    is_used = table.Column<bool>(type: "boolean", nullable: true),
                    item_code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    item_image_url = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    item_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    last_purchase_rate = table.Column<double>(type: "double precision", nullable: true),
                    manufacture_part_number = table.Column<int>(type: "integer", nullable: true),
                    max_discount = table.Column<double>(type: "double precision", nullable: true),
                    opening_stock = table.Column<int>(type: "integer", nullable: false),
                    sale_unit_of_measure = table.Column<int>(type: "integer", nullable: true),
                    self_life_in_day = table.Column<long>(type: "bigint", nullable: true),
                    standard_buying_rate = table.Column<double>(type: "double precision", nullable: false),
                    standard_selling_rate = table.Column<double>(type: "double precision", nullable: false),
                    valuation_rate = table.Column<double>(type: "double precision", nullable: true),
                    warranty_period = table.Column<long>(type: "bigint", nullable: true),
                    weight_per_unit = table.Column<double>(type: "double precision", nullable: true),
                    weight_uom = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    weight_uom_id = table.Column<long>(type: "bigint", nullable: true),
                    item_brand_id = table.Column<long>(type: "bigint", nullable: true),
                    item_group_id = table.Column<long>(type: "bigint", nullable: true),
                    uom_id = table.Column<long>(type: "bigint", nullable: false),
                    valuation_method_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item", x => x.id);
                    table.ForeignKey(
                        name: "fk5aoeq4pcgvoaqjlyhbokvkg8v",
                        column: x => x.uom_id,
                        principalTable: "uom",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkk5mprfnrchdrqapx2sjpydncx",
                        column: x => x.item_brand_id,
                        principalTable: "item_brand",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkr4fbv7293k0b5v1qjk5lm6md",
                        column: x => x.item_group_id,
                        principalTable: "item_group",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkryv8p97mmc5q7dcbupht6w480",
                        column: x => x.valuation_method_id,
                        principalTable: "valuation_method",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "account_sub_class",
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
                    sub_class_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    account_class_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account_sub_class", x => x.id);
                    table.ForeignKey(
                        name: "fk6fwg2pv06thu73nu3wam9s6qo",
                        column: x => x.account_class_id,
                        principalTable: "account_class",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "user_role",
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
                    role_id = table.Column<long>(type: "bigint", nullable: false),
                    user_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_role", x => x.id);
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

            migrationBuilder.CreateTable(
                name: "customer_group",
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
                    is_group = table.Column<bool>(type: "boolean", nullable: true),
                    credit_limit = table.Column<double>(type: "double precision", nullable: true),
                    group_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    parent_id = table.Column<long>(type: "bigint", nullable: true),
                    price_list_id = table.Column<long>(type: "bigint", nullable: true),
                    term_condition_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_group", x => x.id);
                    table.ForeignKey(
                        name: "fk2cwn4lsofnxxbj1b46lrlpwqx",
                        column: x => x.term_condition_id,
                        principalTable: "term_condition",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk8s2k6mrko7c9ejj19f6ld47gd",
                        column: x => x.price_list_id,
                        principalTable: "price_list",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkcpbibhc11a9caqc66e8vl4ka8",
                        column: x => x.parent_id,
                        principalTable: "customer_group",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "role_permission",
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
                    permission_id = table.Column<long>(type: "bigint", nullable: false),
                    role_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role_permission", x => x.id);
                    table.ForeignKey(
                        name: "fka6jx8n8xkesmjmv6jqug6bg68",
                        column: x => x.role_id,
                        principalTable: "role",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkf8yllw1ecvwqy3ehyxawqa1qp",
                        column: x => x.permission_id,
                        principalTable: "permission",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "contact",
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
                    email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    first_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    last_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    mobile_no = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    shipping_address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    supplier_address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    gender_id = table.Column<long>(type: "bigint", nullable: true),
                    salutation_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact", x => x.id);
                    table.ForeignKey(
                        name: "fk2acklccxwjo1rgr6is2ih6ig6",
                        column: x => x.salutation_id,
                        principalTable: "salutation",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkgmv5ta5o5sa1hcsjgjkm8r3c6",
                        column: x => x.gender_id,
                        principalTable: "gender",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "commune",
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
                    commune = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    commid = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    commune_kh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    district_code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    district_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commune", x => x.id);
                    table.ForeignKey(
                        name: "fkjhf1rxvyl4a736j0xjyuqywdr",
                        column: x => x.district_id,
                        principalTable: "district",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "barcode_item",
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
                    barcode = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    barcode_type_id = table.Column<long>(type: "bigint", nullable: false),
                    item_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_barcode_item", x => x.id);
                    table.ForeignKey(
                        name: "fkag1r3x54g4011fd73rsse0hp4",
                        column: x => x.barcode_type_id,
                        principalTable: "barcode_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkguxlr06grt0vq0kxe00w7q9v8",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "item_image",
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
                    item_image_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    item_image_path = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_image", x => x.id);
                    table.ForeignKey(
                        name: "fkta6kqet3u8mv95y7jwtgwqpys",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "item_inventory",
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
                    end_of_life = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    self_life_in_day = table.Column<long>(type: "bigint", nullable: true),
                    warranty_period = table.Column<long>(type: "bigint", nullable: true),
                    weight_per_unit = table.Column<double>(type: "double precision", nullable: true),
                    weight_uom = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: true),
                    material_request_type_id = table.Column<long>(type: "bigint", nullable: true),
                    uom_id = table.Column<long>(type: "bigint", nullable: true),
                    valuation_method_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_inventory", x => x.id);
                    table.ForeignKey(
                        name: "fk6oelp1ry3gkt32xvtqexgxuvp",
                        column: x => x.uom_id,
                        principalTable: "uom",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkdiceow5ur2ts2ltn134gx1wmu",
                        column: x => x.valuation_method_id,
                        principalTable: "valuation_method",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkis34mg9pc892kd0968g1rb9pt",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkj76kdqef8gk747i5cfbedl6ws",
                        column: x => x.material_request_type_id,
                        principalTable: "material_request_type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "item_items",
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
                    barcode = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    extra_cost = table.Column<double>(type: "double precision", nullable: true),
                    extra_price = table.Column<double>(type: "double precision", nullable: true),
                    extra_price_list = table.Column<double>(type: "double precision", nullable: true),
                    item_qty_forecast = table.Column<int>(type: "integer", nullable: true),
                    item_qty_on_hand = table.Column<int>(type: "integer", nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_items", x => x.id);
                    table.ForeignKey(
                        name: "fkff1l0bmjpu0195wgbbvxpuxl1",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "item_price",
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
                    is_buying = table.Column<bool>(type: "boolean", nullable: true),
                    is_selling = table.Column<bool>(type: "boolean", nullable: true),
                    minimum_qty = table.Column<int>(type: "integer", nullable: true),
                    note = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    rate = table.Column<double>(type: "double precision", nullable: true),
                    standard_buying = table.Column<double>(type: "double precision", nullable: true),
                    standard_selling = table.Column<double>(type: "double precision", nullable: true),
                    currency_id = table.Column<long>(type: "bigint", nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: false),
                    price_list_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_price", x => x.id);
                    table.ForeignKey(
                        name: "fk4p9i8tsrcavtdhnwekx7pghxn",
                        column: x => x.currency_id,
                        principalTable: "currency",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fke6ivp7ms01x65oq2amsv5hrl0",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkj0rvvgppk8fl8iqyoaw2kgwcr",
                        column: x => x.price_list_id,
                        principalTable: "price_list",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "item_varrant_uom",
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
                    conversion_factor = table.Column<float>(type: "real", nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: true),
                    uom_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_varrant_uom", x => x.id);
                    table.ForeignKey(
                        name: "fkhkhuhqacy55nhm70lfwv12x95",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkji7fvit04ksijrmfcdnln04hw",
                        column: x => x.uom_id,
                        principalTable: "uom",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "purchase_item",
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
                    is_purchase_item = table.Column<bool>(type: "boolean", nullable: true),
                    lead_time_in_day = table.Column<int>(type: "integer", nullable: true),
                    minimum_order_qty = table.Column<int>(type: "integer", nullable: true),
                    safety_stock = table.Column<int>(type: "integer", nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: true),
                    uom_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_item", x => x.id);
                    table.ForeignKey(
                        name: "fk4voj5rjjn6ofwsp9qk70w2tga",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk9cikvj5nf90g3t18gkt7r7jju",
                        column: x => x.uom_id,
                        principalTable: "uom",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "chart_of_account",
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
                    allow_negative = table.Column<bool>(type: "boolean", nullable: true),
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    gl_code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    leaf_account = table.Column<bool>(type: "boolean", nullable: true),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    account_class_id = table.Column<long>(type: "bigint", nullable: true),
                    account_sub_class_id = table.Column<long>(type: "bigint", nullable: true),
                    parent_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chart_of_account", x => x.id);
                    table.ForeignKey(
                        name: "fkchnxkh169tc4p2mvgjwk6wem0",
                        column: x => x.account_class_id,
                        principalTable: "account_class",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkdq4k1slnqurdocfji02kjx9xl",
                        column: x => x.account_sub_class_id,
                        principalTable: "account_sub_class",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fki15llbslked3px8fhpu9wmeyv",
                        column: x => x.parent_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "village",
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
                    commune_code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    village = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    villid = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    village_kh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    commune_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_village", x => x.id);
                    table.ForeignKey(
                        name: "fkcrrurypoayljvp4qlwqxkivvl",
                        column: x => x.commune_id,
                        principalTable: "commune",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "item_attribute_value",
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
                    item_attribute_id = table.Column<long>(type: "bigint", nullable: false),
                    item_attribute_detail_id = table.Column<long>(type: "bigint", nullable: false),
                    item_item_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_attribute_value", x => x.id);
                    table.ForeignKey(
                        name: "fkc3m663h01tr58i97ageb3q1b2",
                        column: x => x.item_attribute_id,
                        principalTable: "item_attribute",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkp1k0ionspjil7j8ba6xti00op",
                        column: x => x.item_item_id,
                        principalTable: "item_items",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkt9b6s94x0po7n5elu68pt02il",
                        column: x => x.item_attribute_detail_id,
                        principalTable: "item_attribute_detail",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "account_mapping",
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
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    chart_of_acc_id = table.Column<long>(type: "bigint", nullable: true),
                    trxn_type_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account_mapping", x => x.id);
                    table.ForeignKey(
                        name: "fkjv10nysl8rtcd011k6shm644p",
                        column: x => x.chart_of_acc_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkon5k51nce6l8bkuxdo1xmqrlm",
                        column: x => x.trxn_type_id,
                        principalTable: "transaction_type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "asset_category",
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
                    abbr = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    depre_method = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    gl_depre_rate = table.Column<double>(type: "double precision", nullable: true),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    gl_accu_depre_id = table.Column<long>(type: "bigint", nullable: false),
                    gl_cost_id = table.Column<long>(type: "bigint", nullable: false),
                    gl_depre_exp_id = table.Column<long>(type: "bigint", nullable: false),
                    gl_gain_id = table.Column<long>(type: "bigint", nullable: false),
                    gl_loss_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_category", x => x.id);
                    table.ForeignKey(
                        name: "fk8bso12kxoyruf5d3e99kmcq4t",
                        column: x => x.gl_loss_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkgipci61w74vdt6mhvmpefsdh6",
                        column: x => x.gl_cost_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkitvmc8cb391xfpr5k76n55640",
                        column: x => x.gl_accu_depre_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkmu8qlkcx64ql2g9fsi84c79f3",
                        column: x => x.gl_gain_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkt4wvplrq32ma9rplku5y2qleg",
                        column: x => x.gl_depre_exp_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "clear_bill",
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
                    bill_clear_status = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    bill_ref = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    checks = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    clear_amount = table.Column<double>(type: "double precision", nullable: true),
                    clear_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    clear_ref = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    journal_entry_id = table.Column<long>(type: "bigint", nullable: true),
                    branch_id = table.Column<long>(type: "bigint", nullable: true),
                    chart_of_account_id = table.Column<long>(type: "bigint", nullable: true),
                    currency_id = table.Column<long>(type: "bigint", nullable: true),
                    payment_method_id = table.Column<long>(type: "bigint", nullable: true),
                    transaction_type_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clear_bill", x => x.id);
                    table.ForeignKey(
                        name: "fk8pj436wro0loy9unwj652sfup",
                        column: x => x.chart_of_account_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk9t8ys3m5xd0c47r4jrim84jh0",
                        column: x => x.transaction_type_id,
                        principalTable: "transaction_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkcxv7b1s6vpgn18fjkq1dr9k8c",
                        column: x => x.branch_id,
                        principalTable: "branch",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkd5yjowqgyt5mkwg2gq22qu1v",
                        column: x => x.payment_method_id,
                        principalTable: "payment_method",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkr68himos2hsvmxa3ijrfqo42c",
                        column: x => x.currency_id,
                        principalTable: "currency",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "coa_balance",
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
                    balance = table.Column<double>(type: "double precision", nullable: true),
                    gl_code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    branch_id = table.Column<long>(type: "bigint", nullable: true),
                    chart_of_account_id = table.Column<long>(type: "bigint", nullable: true),
                    currency_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coa_balance", x => x.id);
                    table.ForeignKey(
                        name: "fkeloeomrdnfddh2ifk3c4lr8q7",
                        column: x => x.chart_of_account_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkgptqjaslktx3wlrqupc5cbsri",
                        column: x => x.currency_id,
                        principalTable: "currency",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkjxfa7dai3h6b325lv6lhi18c2",
                        column: x => x.branch_id,
                        principalTable: "branch",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "supplier_payment",
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
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    is_settle_credit = table.Column<bool>(type: "boolean", nullable: true),
                    paid_amount = table.Column<double>(type: "double precision", nullable: true),
                    payment_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    payment_option = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    payment_type = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ref_no = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    remark = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    settlement_amount = table.Column<double>(type: "double precision", nullable: true),
                    total_paid_amount = table.Column<double>(type: "double precision", nullable: true),
                    gl_account_id = table.Column<long>(type: "bigint", nullable: true),
                    supplier_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplier_payment", x => x.id);
                    table.ForeignKey(
                        name: "fk37powsao54q2lixsdroi931s2",
                        column: x => x.gl_account_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkqy7og5c3psvi8j5yn2lmrki7x",
                        column: x => x.supplier_id,
                        principalTable: "supplier",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "transaction_journal",
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
                    b_status = table.Column<int>(type: "integer", nullable: true),
                    credit = table.Column<double>(type: "double precision", nullable: true),
                    debit = table.Column<double>(type: "double precision", nullable: true),
                    gl_code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    @ref = table.Column<string>(name: "ref", type: "character varying(255)", maxLength: 255, nullable: true),
                    chart_of_acc_id = table.Column<long>(type: "bigint", nullable: true),
                    journal_entry_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_journal", x => x.id);
                    table.ForeignKey(
                        name: "fk6ii7t9iwrqgpvarphfooha64v",
                        column: x => x.journal_entry_id,
                        principalTable: "journal_entry",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fknnqnwmbgyqav3myhdcqs2pb0r",
                        column: x => x.chart_of_acc_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "account_bill",
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
                    bill_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    bill_ref = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    bill_status = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    due_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    journal_entry_id = table.Column<long>(type: "bigint", nullable: true),
                    total_bill_amount = table.Column<double>(type: "double precision", nullable: true),
                    chart_of_account_id = table.Column<long>(type: "bigint", nullable: true),
                    branch_id = table.Column<long>(type: "bigint", nullable: true),
                    currency_id = table.Column<long>(type: "bigint", nullable: true),
                    supplier_id = table.Column<long>(type: "bigint", nullable: true),
                    transaction_type_id = table.Column<long>(type: "bigint", nullable: true),
                    account_bill_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account_bill", x => x.id);
                    table.ForeignKey(
                        name: "fk934gx2tluclloegv07uscpwh4",
                        column: x => x.transaction_type_id,
                        principalTable: "transaction_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkbc9eca5khrmslb057wogk0at6",
                        column: x => x.currency_id,
                        principalTable: "currency",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkfr49i4ptk84ac9op8f1ib1vmy",
                        column: x => x.supplier_id,
                        principalTable: "supplier",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkhio30fgynlx7l0y2unnh32183",
                        column: x => x.account_bill_id,
                        principalTable: "clear_bill",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkrhj3j3h9htss5jb0sexiv62mx",
                        column: x => x.branch_id,
                        principalTable: "branch",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkscjv73cmmlbvws3syb0h2sy9i",
                        column: x => x.chart_of_account_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "supplier_payment_reference",
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
                    paid_amount = table.Column<double>(type: "double precision", nullable: true),
                    pi_amount = table.Column<double>(type: "double precision", nullable: true),
                    pi_no = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    po_amount = table.Column<double>(type: "double precision", nullable: true),
                    po_no = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    pre_paid_amount = table.Column<double>(type: "double precision", nullable: true),
                    prepayment_amount = table.Column<double>(type: "double precision", nullable: true),
                    purchase_invoice_id = table.Column<int>(type: "integer", nullable: true),
                    purchase_order_id = table.Column<int>(type: "integer", nullable: true),
                    unpaid_amount = table.Column<double>(type: "double precision", nullable: true),
                    supplier_payment_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplier_payment_reference", x => x.id);
                    table.ForeignKey(
                        name: "fk6d3jm63jygvlx10hevm5xt9h5",
                        column: x => x.supplier_payment_id,
                        principalTable: "supplier_payment",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "account_bill_item",
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
                    amount = table.Column<double>(type: "double precision", nullable: true),
                    @ref = table.Column<string>(name: "ref", type: "character varying(255)", maxLength: 255, nullable: true),
                    account_bill_id = table.Column<long>(type: "bigint", nullable: true),
                    chart_of_account_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account_bill_item", x => x.id);
                    table.ForeignKey(
                        name: "fk5xs5s5pn9w08ocie851r34qj9",
                        column: x => x.chart_of_account_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkhs2gbpt46mm38pn4hnwups77p",
                        column: x => x.account_bill_id,
                        principalTable: "account_bill",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "account",
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
                    is_group = table.Column<bool>(type: "boolean", nullable: true),
                    account_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    rate = table.Column<float>(type: "real", nullable: true),
                    account_type_id = table.Column<long>(type: "bigint", nullable: true),
                    balance_id = table.Column<long>(type: "bigint", nullable: true),
                    company_id = table.Column<long>(type: "bigint", nullable: true),
                    currency_id = table.Column<long>(type: "bigint", nullable: true),
                    parent_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account", x => x.id);
                    table.ForeignKey(
                        name: "fk316pn109iutn6yqoxrqp09cpc",
                        column: x => x.currency_id,
                        principalTable: "currency",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk6qc52gy2x227bjs1exltnye4i",
                        column: x => x.balance_id,
                        principalTable: "balance",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkef5lfvm7tliuagpl8wibmrqd0",
                        column: x => x.parent_id,
                        principalTable: "account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkgw84mgpacw9htdxcs2j1p7u6j",
                        column: x => x.account_type_id,
                        principalTable: "account_type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "item_tax",
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
                    tax_rate = table.Column<double>(type: "double precision", nullable: true),
                    account_id = table.Column<long>(type: "bigint", nullable: false),
                    item_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_tax", x => x.id);
                    table.ForeignKey(
                        name: "fkpcr0c4d5h8jy2wmulevnlfcj5",
                        column: x => x.account_id,
                        principalTable: "account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fksj5f0qcjcyy39lcqhrxw7ovd0",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "warehouse",
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
                    is_disable = table.Column<bool>(type: "boolean", nullable: true),
                    is_group = table.Column<bool>(type: "boolean", nullable: true),
                    address_line1 = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    address_line2 = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    city = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    phone = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    is_used = table.Column<bool>(type: "boolean", nullable: true),
                    warehouse_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    account_id = table.Column<long>(type: "bigint", nullable: true),
                    parent_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warehouse", x => x.id);
                    table.ForeignKey(
                        name: "fk70sqwlljiffsgp99br2hxtrkf",
                        column: x => x.account_id,
                        principalTable: "account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fklfiv9cjr48uvfjtw9knmnqpl0",
                        column: x => x.parent_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "company",
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
                    abbr = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    address_kh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    company_desc = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    company_logo = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    company_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    company_name_kh = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    date_of_establishment = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    deduct_stock_setting = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    is_group = table.Column<bool>(type: "boolean", nullable: false),
                    phone = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    tax_id = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    vat_in = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    country_id = table.Column<long>(type: "bigint", nullable: true),
                    currency_id = table.Column<long>(type: "bigint", nullable: true),
                    domain_id = table.Column<long>(type: "bigint", nullable: true),
                    finance_book_id = table.Column<long>(type: "bigint", nullable: true),
                    letter_head_id = table.Column<long>(type: "bigint", nullable: true),
                    parent_id = table.Column<long>(type: "bigint", nullable: true),
                    term_condition_id = table.Column<long>(type: "bigint", nullable: true),
                    warehouse_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.id);
                    table.ForeignKey(
                        name: "fk44tv95tmlycg04ocoab73f8gy",
                        column: x => x.term_condition_id,
                        principalTable: "term_condition",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk6ukoma5ydy94w070ewmn7udfy",
                        column: x => x.currency_id,
                        principalTable: "currency",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkaa85rotlnir4w4xlj1nkilnws",
                        column: x => x.country_id,
                        principalTable: "country",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkb6r1lhl3xmxagt26dpo5rta",
                        column: x => x.warehouse_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkejx9exwuci0durwyeu04e3rw5",
                        column: x => x.finance_book_id,
                        principalTable: "finance_book",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkgsxt4pb7gewmc5v44h53lu1bn",
                        column: x => x.parent_id,
                        principalTable: "company",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkq0oaas2qxv289cnkadhq1b6y8",
                        column: x => x.letter_head_id,
                        principalTable: "letter_head",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkrxopcubjl5kvrx8fwf9vv9mom",
                        column: x => x.domain_id,
                        principalTable: "domain",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "purchase_order",
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
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    discount_amount = table.Column<double>(type: "double precision", nullable: true),
                    discount_percent = table.Column<double>(type: "double precision", nullable: true),
                    grand_total = table.Column<double>(type: "double precision", nullable: false),
                    outstanding_amount = table.Column<double>(type: "double precision", nullable: false),
                    pre_paid_amount = table.Column<double>(type: "double precision", nullable: false),
                    required_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    total_amount = table.Column<double>(type: "double precision", nullable: false),
                    total_charge = table.Column<double>(type: "double precision", nullable: true),
                    total_prepayment = table.Column<double>(type: "double precision", nullable: false),
                    total_qty = table.Column<double>(type: "double precision", nullable: true),
                    total_weight = table.Column<double>(type: "double precision", nullable: true),
                    contact_id = table.Column<long>(type: "bigint", nullable: true),
                    currency_id = table.Column<long>(type: "bigint", nullable: true),
                    price_list_id = table.Column<long>(type: "bigint", nullable: true),
                    supplier_id = table.Column<long>(type: "bigint", nullable: true),
                    warehouse_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_order", x => x.id);
                    table.ForeignKey(
                        name: "fk4traogu3jriq9u7e8rvm86k7i",
                        column: x => x.supplier_id,
                        principalTable: "supplier",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkfn0kri8xb0mi8bkb2swlnv581",
                        column: x => x.warehouse_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkijpaw9ak0pnsorfdl9dej85kx",
                        column: x => x.currency_id,
                        principalTable: "currency",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkil76wgv3woyccv917kxd0yakh",
                        column: x => x.price_list_id,
                        principalTable: "price_list",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkkqescxsvxsm2o454b36rlmdax",
                        column: x => x.contact_id,
                        principalTable: "contact",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "purchase_return",
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
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    discount_amount = table.Column<double>(type: "double precision", nullable: true),
                    discount_percent = table.Column<double>(type: "double precision", nullable: true),
                    remark = table.Column<string>(type: "text", nullable: true),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    sub_total = table.Column<double>(type: "double precision", nullable: true),
                    total = table.Column<double>(type: "double precision", nullable: true),
                    vat_amount = table.Column<double>(type: "double precision", nullable: true),
                    vat_percent = table.Column<double>(type: "double precision", nullable: true),
                    supplier_id = table.Column<long>(type: "bigint", nullable: true),
                    warehouse_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_return", x => x.id);
                    table.ForeignKey(
                        name: "fk9w5jqdyl12gvwaxagisj6u3gk",
                        column: x => x.supplier_id,
                        principalTable: "supplier",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkt2k98i6ounmgnvoexk2rlpugp",
                        column: x => x.warehouse_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "stock_ledger_entry",
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
                    actual_qty = table.Column<float>(type: "real", nullable: true),
                    qty_after_tranx = table.Column<float>(type: "real", nullable: true),
                    serial_no = table.Column<string>(type: "text", nullable: true),
                    valuation_rate = table.Column<float>(type: "real", nullable: true),
                    voucher_no = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    voucher_type = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: true),
                    uom_id = table.Column<long>(type: "bigint", nullable: true),
                    warehouse_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stock_ledger_entry", x => x.id);
                    table.ForeignKey(
                        name: "fk1xb8wim7g2yis2kfet61xewm4",
                        column: x => x.uom_id,
                        principalTable: "uom",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk92dind6o2qd7h1gvpbhe43dv7",
                        column: x => x.warehouse_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkgd0tsaayq87j3kc1fkxyf4826",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "stock_move",
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
                    is_refund = table.Column<bool>(type: "boolean", nullable: true),
                    item_qty = table.Column<float>(type: "real", nullable: true),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    note = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    state_stock_move = table.Column<int>(type: "integer", nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: true),
                    warehouse_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stock_move", x => x.id);
                    table.ForeignKey(
                        name: "fka1n7nvnm1y225ioj500iu0jgp",
                        column: x => x.warehouse_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkod2pcvaos1am5wtio2rapiuxa",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "employee",
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
                    data_of_joining = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    dob = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    first_name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    last_name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    middle_name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    phone = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    series = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    company_id = table.Column<long>(type: "bigint", nullable: true),
                    employee_type_id = table.Column<long>(type: "bigint", nullable: true),
                    gender_id = table.Column<long>(type: "bigint", nullable: true),
                    health_insurance_id = table.Column<long>(type: "bigint", nullable: true),
                    salutation_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.id);
                    table.ForeignKey(
                        name: "fk4ndp9leoqaddrmvfl6w90oefe",
                        column: x => x.health_insurance_id,
                        principalTable: "health_insurance",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk5v50ed2bjh60n1gc7ifuxmgf4",
                        column: x => x.company_id,
                        principalTable: "company",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fke0w26qjedr99vwno4pqauw9i9",
                        column: x => x.gender_id,
                        principalTable: "gender",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkks0jnjwhw9tjwa2b1l0klv1fb",
                        column: x => x.employee_type_id,
                        principalTable: "employee_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fks2cicw7ryjpxendgeb5bxqhld",
                        column: x => x.salutation_id,
                        principalTable: "salutation",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "item_warehouse",
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
                    company_id = table.Column<long>(type: "bigint", nullable: false),
                    item_id = table.Column<long>(type: "bigint", nullable: false),
                    price_list_id = table.Column<long>(type: "bigint", nullable: true),
                    warehouse_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_warehouse", x => x.id);
                    table.ForeignKey(
                        name: "fk68qrrw32tlahocw3luuxmo9lt",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkbytqw7u56ln8ib2g0wymfrwa0",
                        column: x => x.company_id,
                        principalTable: "company",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkc4ouc0dxe9v9c157njyn4782u",
                        column: x => x.price_list_id,
                        principalTable: "price_list",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fktb7uwg7judhe1j4kcw9hpgqcd",
                        column: x => x.warehouse_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "sale_tax_charge",
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
                    disable = table.Column<bool>(type: "boolean", nullable: true),
                    title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    company_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sale_tax_charge", x => x.id);
                    table.ForeignKey(
                        name: "fkbt8g92toapbsl1elxgjt77fqf",
                        column: x => x.company_id,
                        principalTable: "company",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "stock_balance",
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
                    is_absolute_value = table.Column<bool>(type: "boolean", nullable: true),
                    balance_qty = table.Column<float>(type: "real", nullable: false),
                    balance_value = table.Column<double>(type: "double precision", nullable: false),
                    cogs = table.Column<double>(type: "double precision", nullable: false),
                    in_qty = table.Column<float>(type: "real", nullable: false),
                    in_value = table.Column<double>(type: "double precision", nullable: false),
                    out_qty = table.Column<float>(type: "real", nullable: false),
                    out_value = table.Column<float>(type: "real", nullable: false),
                    reserved_qty = table.Column<float>(type: "real", nullable: false),
                    valuation_rate = table.Column<double>(type: "double precision", nullable: false),
                    waiting_qty = table.Column<float>(type: "real", nullable: false),
                    company_id = table.Column<long>(type: "bigint", nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: true),
                    item_brand_id = table.Column<long>(type: "bigint", nullable: true),
                    item_group_id = table.Column<long>(type: "bigint", nullable: true),
                    uom_id = table.Column<long>(type: "bigint", nullable: true),
                    warehouse_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stock_balance", x => x.id);
                    table.ForeignKey(
                        name: "fk6rl1ityt6rj170agffi8y1s0w",
                        column: x => x.item_brand_id,
                        principalTable: "item_brand",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk8r5c5n53qfm24rbnloy0352fx",
                        column: x => x.warehouse_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkkx446h9kl3uhwk4aik8mf7txy",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkt3lfdsnlyvsmvricin7gq4weu",
                        column: x => x.item_group_id,
                        principalTable: "item_group",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fktgjh58semjd1j5or2c2wwwsbb",
                        column: x => x.company_id,
                        principalTable: "company",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fktncstwbue2v1tk2uu8dhv1mly",
                        column: x => x.uom_id,
                        principalTable: "uom",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "purchase_order_detail",
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
                    actual_qty = table.Column<double>(type: "double precision", nullable: false),
                    amount = table.Column<double>(type: "double precision", nullable: true),
                    conversion_factor = table.Column<float>(type: "real", nullable: true),
                    discount_amount = table.Column<double>(type: "double precision", nullable: true),
                    discount_percent = table.Column<double>(type: "double precision", nullable: true),
                    last_purchase_rate = table.Column<double>(type: "double precision", nullable: true),
                    qty = table.Column<float>(type: "real", nullable: false),
                    rate = table.Column<double>(type: "double precision", nullable: false),
                    received_qty = table.Column<double>(type: "double precision", nullable: false),
                    required_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    stock_qty = table.Column<double>(type: "double precision", nullable: false),
                    weight_uom = table.Column<double>(type: "double precision", nullable: false),
                    item_id = table.Column<long>(type: "bigint", nullable: true),
                    item_variant_uom__id = table.Column<long>(type: "bigint", nullable: true),
                    purchase_order_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_order_detail", x => x.id);
                    table.ForeignKey(
                        name: "fki6xlnsg9o9ght6xcwl51ooa4k",
                        column: x => x.purchase_order_id,
                        principalTable: "purchase_order",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkkl3w9bo79qh9eat9qyxkvvchs",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkmwllceinbhnwsao7ggvu95ju",
                        column: x => x.item_variant_uom__id,
                        principalTable: "item_varrant_uom",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "purchase_receipt",
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
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    date_done = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    discount_amount = table.Column<double>(type: "double precision", nullable: true),
                    discount_percent = table.Column<double>(type: "double precision", nullable: true),
                    grand_total = table.Column<double>(type: "double precision", nullable: false),
                    is_return = table.Column<bool>(type: "boolean", nullable: true),
                    noted = table.Column<string>(type: "text", nullable: true),
                    prorate_by = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    prorate_by_id = table.Column<long>(type: "bigint", nullable: true),
                    purchase_order_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    purchase_order_series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    raw_material = table.Column<bool>(type: "boolean", nullable: true),
                    required_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    shipping_address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    supplier_address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    total_additional_amount = table.Column<double>(type: "double precision", nullable: false),
                    total_amount = table.Column<double>(type: "double precision", nullable: true),
                    total_charge = table.Column<double>(type: "double precision", nullable: true),
                    total_qty = table.Column<double>(type: "double precision", nullable: true),
                    total_weight = table.Column<double>(type: "double precision", nullable: true),
                    contact_id = table.Column<long>(type: "bigint", nullable: true),
                    currency_id = table.Column<long>(type: "bigint", nullable: true),
                    price_list_id = table.Column<long>(type: "bigint", nullable: true),
                    purchase_order_id = table.Column<long>(type: "bigint", nullable: true),
                    supplier_id = table.Column<long>(type: "bigint", nullable: true),
                    warehouse_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_receipt", x => x.id);
                    table.ForeignKey(
                        name: "fk1i0giyt54cl1nege2tj2f3nlu",
                        column: x => x.supplier_id,
                        principalTable: "supplier",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk2c6a1tn7eyhgxc5wxfy1s3co5",
                        column: x => x.contact_id,
                        principalTable: "contact",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkay0iqp4vpc99mulfa52pecte8",
                        column: x => x.currency_id,
                        principalTable: "currency",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkfmwniv5hy3skbyhslnff7o0bj",
                        column: x => x.purchase_order_id,
                        principalTable: "purchase_order",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fknljtk7avkhubpn0rhctnbu971",
                        column: x => x.price_list_id,
                        principalTable: "price_list",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkp6wbcrpolpl8r94tupe2doi70",
                        column: x => x.warehouse_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "debit_note",
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
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    discount_amount = table.Column<double>(type: "double precision", nullable: true),
                    discount_percentage = table.Column<double>(type: "double precision", nullable: true),
                    grand_total = table.Column<double>(type: "double precision", nullable: true),
                    is_include_vat = table.Column<bool>(type: "boolean", nullable: true),
                    remark = table.Column<string>(type: "text", nullable: true),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    sub_total = table.Column<double>(type: "double precision", nullable: true),
                    vat_amount = table.Column<double>(type: "double precision", nullable: true),
                    vat_percentage = table.Column<double>(type: "double precision", nullable: true),
                    purchase_return_id = table.Column<long>(type: "bigint", nullable: true),
                    supplier_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debit_note", x => x.id);
                    table.ForeignKey(
                        name: "fkfugvyrn4myafsc8akbdqakt6r",
                        column: x => x.purchase_return_id,
                        principalTable: "purchase_return",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkqxg5f0dimqahtdr2oncw9c1t",
                        column: x => x.supplier_id,
                        principalTable: "supplier",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "purchase_return_detail",
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
                    amount = table.Column<double>(type: "double precision", nullable: true),
                    discount = table.Column<float>(type: "real", nullable: true),
                    discount_percent = table.Column<float>(type: "real", nullable: true),
                    qty = table.Column<float>(type: "real", nullable: true),
                    rate = table.Column<double>(type: "double precision", nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: true),
                    item_variant_uom_id = table.Column<long>(type: "bigint", nullable: true),
                    purchase_return_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_return_detail", x => x.id);
                    table.ForeignKey(
                        name: "fkey1pgajbkxxdumqifvfpu3x55",
                        column: x => x.purchase_return_id,
                        principalTable: "purchase_return",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkios10qt5oav8wfckvrk4b9qn1",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkpqo3sxgfygnr4ptgo1qp0xdpf",
                        column: x => x.item_variant_uom_id,
                        principalTable: "item_varrant_uom",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "drivers",
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
                    cellphone_number = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    driver_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    expiry_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    issuing_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    license_number = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    series = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    driver_status_id = table.Column<long>(type: "bigint", nullable: true),
                    employee_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drivers", x => x.id);
                    table.ForeignKey(
                        name: "fk90r4l5ytsw0lku0pyj5m9k1nc",
                        column: x => x.driver_status_id,
                        principalTable: "driver_status",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkq2af0erpwyy7ubrwn7hoo23t",
                        column: x => x.employee_id,
                        principalTable: "employee",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "sale_person",
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
                    enabled = table.Column<bool>(type: "boolean", nullable: true),
                    is_group = table.Column<bool>(type: "boolean", nullable: true),
                    commission_rate = table.Column<float>(type: "real", nullable: true),
                    sale_person_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    employee_id = table.Column<long>(type: "bigint", nullable: true),
                    parent_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sale_person", x => x.id);
                    table.ForeignKey(
                        name: "fke1u58xw55ol3s4rc87svsfe8q",
                        column: x => x.employee_id,
                        principalTable: "employee",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkflejc15b52ujrc08i883407cg",
                        column: x => x.parent_id,
                        principalTable: "sale_person",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "sale_tax_detail",
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
                    amount = table.Column<float>(type: "real", nullable: true),
                    rate = table.Column<float>(type: "real", nullable: true),
                    total = table.Column<float>(type: "real", nullable: true),
                    account_id = table.Column<long>(type: "bigint", nullable: true),
                    sale_tax_charge_id = table.Column<long>(type: "bigint", nullable: true),
                    sale_tax_type_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sale_tax_detail", x => x.id);
                    table.ForeignKey(
                        name: "fka7i73g2fd1adm4pla4w0lxif5",
                        column: x => x.sale_tax_type_id,
                        principalTable: "sale_tax_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkby4kj0dhqm4f2kntq6ieo8mao",
                        column: x => x.sale_tax_charge_id,
                        principalTable: "sale_tax_charge",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkkqgdffk6oaepnpjsden2u5bm6",
                        column: x => x.account_id,
                        principalTable: "account",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "purchase_invoice",
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
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    date_done = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    discount_amount = table.Column<double>(type: "double precision", nullable: false),
                    discount_percent = table.Column<double>(type: "double precision", nullable: false),
                    grand_total = table.Column<double>(type: "double precision", nullable: false),
                    is_paid = table.Column<bool>(type: "boolean", nullable: false),
                    is_raw_material = table.Column<bool>(type: "boolean", nullable: false),
                    is_return = table.Column<bool>(type: "boolean", nullable: false),
                    noted = table.Column<string>(type: "text", nullable: true),
                    outstanding_amount = table.Column<double>(type: "double precision", nullable: false),
                    prepaid_amount = table.Column<double>(type: "double precision", nullable: false),
                    prepayment_amount = table.Column<double>(type: "double precision", nullable: false),
                    purchase_order_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    purchase_order_series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    purchase_receipt_series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    supplier_address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    supplier_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    total_amount = table.Column<double>(type: "double precision", nullable: false),
                    total_qty = table.Column<double>(type: "double precision", nullable: false),
                    total_weight = table.Column<double>(type: "double precision", nullable: true),
                    currency_id = table.Column<long>(type: "bigint", nullable: true),
                    purchase_order_id = table.Column<long>(type: "bigint", nullable: true),
                    purchase_receipt_id = table.Column<long>(type: "bigint", nullable: true),
                    supplier_id = table.Column<long>(type: "bigint", nullable: true),
                    warehouse_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_invoice", x => x.id);
                    table.ForeignKey(
                        name: "fkcakafkke1058qmmjpqlpvrajn",
                        column: x => x.purchase_receipt_id,
                        principalTable: "purchase_receipt",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fknq1hm13475eygvfhocnu7gubi",
                        column: x => x.currency_id,
                        principalTable: "currency",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkqtx4kjstn77n9v4wowt0mlxkx",
                        column: x => x.supplier_id,
                        principalTable: "supplier",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkqv5xl4xgrxpd7fk8kjhlj3wo0",
                        column: x => x.purchase_order_id,
                        principalTable: "purchase_order",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fktmqydvbl95w50omj8h8fe3xge",
                        column: x => x.warehouse_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "purchase_receipt_detail",
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
                    actual_qty = table.Column<double>(type: "double precision", nullable: true),
                    amount = table.Column<double>(type: "double precision", nullable: true),
                    batch_no = table.Column<string>(type: "text", nullable: true),
                    conversion_factor = table.Column<float>(type: "real", nullable: true),
                    discount_amount = table.Column<double>(type: "double precision", nullable: true),
                    discount_percent = table.Column<double>(type: "double precision", nullable: true),
                    item_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    last_purchase_rate = table.Column<double>(type: "double precision", nullable: true),
                    qty = table.Column<float>(type: "real", nullable: false),
                    rate = table.Column<double>(type: "double precision", nullable: false),
                    received_qty = table.Column<float>(type: "real", nullable: true),
                    serial_no = table.Column<string>(type: "text", nullable: true),
                    stock_qty = table.Column<double>(type: "double precision", nullable: true),
                    weight = table.Column<float>(type: "real", nullable: true),
                    weight_uom = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    weight_uom_id = table.Column<long>(type: "bigint", nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: true),
                    item_variant_uom__id = table.Column<long>(type: "bigint", nullable: true),
                    purchase_receipt_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_receipt_detail", x => x.id);
                    table.ForeignKey(
                        name: "fk61w97fs23xjv2jnhtwsjsuj4t",
                        column: x => x.item_variant_uom__id,
                        principalTable: "item_varrant_uom",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk94l1gahvt7cxj9ydlakm1dh83",
                        column: x => x.purchase_receipt_id,
                        principalTable: "purchase_receipt",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkutom30tugx82jmgrw8d953q0",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "purchase_receipt_expanse",
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
                    amount = table.Column<double>(type: "double precision", nullable: true),
                    remark = table.Column<string>(type: "text", nullable: true),
                    expanse_category_id = table.Column<long>(type: "bigint", nullable: true),
                    purchase_receipt_id = table.Column<long>(type: "bigint", nullable: true),
                    supplier_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_receipt_expanse", x => x.id);
                    table.ForeignKey(
                        name: "fk7g5xfebu7c91mmkmhpgst18ml",
                        column: x => x.supplier_id,
                        principalTable: "supplier",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkh0gj7cyw3k5s97i7gqouunkbo",
                        column: x => x.expanse_category_id,
                        principalTable: "expanse_category",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkikgyhuxjxb5h9jpifv3inoipa",
                        column: x => x.purchase_receipt_id,
                        principalTable: "purchase_receipt",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "purchase_refund",
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
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    debit_note_amount = table.Column<double>(type: "double precision", nullable: true),
                    payment_option = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    reference_no = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    refund_amount = table.Column<double>(type: "double precision", nullable: true),
                    remark = table.Column<string>(type: "text", nullable: true),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    debit_note_id = table.Column<long>(type: "bigint", nullable: true),
                    gl_account_id = table.Column<long>(type: "bigint", nullable: true),
                    supplier_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_refund", x => x.id);
                    table.ForeignKey(
                        name: "fkb5qwcr5so9wu5ht0sll55gvj2",
                        column: x => x.gl_account_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkkckiis3148kh5byh03ox71ckp",
                        column: x => x.debit_note_id,
                        principalTable: "debit_note",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkqfd8ae7ltgilf1p828iln5170",
                        column: x => x.supplier_id,
                        principalTable: "supplier",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "customer",
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
                    address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    contact = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    credit_length = table.Column<int>(type: "integer", nullable: true),
                    credit_limit = table.Column<double>(type: "double precision", nullable: true),
                    customer_type = table.Column<int>(type: "integer", nullable: true),
                    disable = table.Column<bool>(type: "boolean", nullable: false),
                    id_card = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    is_internal_customer = table.Column<bool>(type: "boolean", nullable: true),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    name_kh = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    is_pass_credit_limit = table.Column<bool>(type: "boolean", nullable: true),
                    payment_term = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    series = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    tax_id = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    vat_in = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    currency_id = table.Column<long>(type: "bigint", nullable: true),
                    customer_group_id = table.Column<long>(type: "bigint", nullable: false),
                    gender_id = table.Column<long>(type: "bigint", nullable: true),
                    price_list_id = table.Column<long>(type: "bigint", nullable: true),
                    sale_person_id = table.Column<long>(type: "bigint", nullable: true),
                    salutation_id = table.Column<long>(type: "bigint", nullable: true),
                    territory_id = table.Column<long>(type: "bigint", nullable: true),
                    warehouse_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.id);
                    table.ForeignKey(
                        name: "fk1lt23ie2trgs1r42hqyhliedv",
                        column: x => x.gender_id,
                        principalTable: "gender",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk3fqcpx7dko5slv9s6m31cm4g1",
                        column: x => x.currency_id,
                        principalTable: "currency",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk9ogndo8hll7edx5iloyu2uegy",
                        column: x => x.customer_group_id,
                        principalTable: "customer_group",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkaamb70smwnslvwf80j4bc50c4",
                        column: x => x.territory_id,
                        principalTable: "territory",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkdy9yo0g543vri6m5ev1aj2d5",
                        column: x => x.price_list_id,
                        principalTable: "price_list",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkhmrknj1oisejx0n7kqagqnesc",
                        column: x => x.sale_person_id,
                        principalTable: "sale_person",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fki95uujr0h5h486a8pbshc7vmw",
                        column: x => x.warehouse_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fknax78wl40ln4p5jm32scouq0w",
                        column: x => x.salutation_id,
                        principalTable: "salutation",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "purchase_invoice_detail",
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
                    actual_qty = table.Column<double>(type: "double precision", nullable: true),
                    amount = table.Column<double>(type: "double precision", nullable: true),
                    conversion_factor = table.Column<float>(type: "real", nullable: true),
                    discount_amount = table.Column<double>(type: "double precision", nullable: true),
                    discount_percent = table.Column<double>(type: "double precision", nullable: true),
                    item_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    last_purchase_rate = table.Column<double>(type: "double precision", nullable: true),
                    qty = table.Column<float>(type: "real", nullable: true),
                    rate = table.Column<double>(type: "double precision", nullable: true),
                    received_qty = table.Column<float>(type: "real", nullable: true),
                    stock_qty = table.Column<double>(type: "double precision", nullable: true),
                    weight_uom = table.Column<double>(type: "double precision", nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: true),
                    item_variant_uom__id = table.Column<long>(type: "bigint", nullable: true),
                    purchase_invoice_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_invoice_detail", x => x.id);
                    table.ForeignKey(
                        name: "fk4yll33q6jlrhfi6fykxer4qrv",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkdc7bo3dg79p1cmcr0vwf3kxsy",
                        column: x => x.purchase_invoice_id,
                        principalTable: "purchase_invoice",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fknutdjywmxf8dtyfjfm5fd9bbq",
                        column: x => x.item_variant_uom__id,
                        principalTable: "item_varrant_uom",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "customer_balance",
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
                    total_amountar = table.Column<double>(type: "double precision", nullable: false),
                    total_balancear = table.Column<double>(type: "double precision", nullable: false),
                    total_prepayment = table.Column<double>(type: "double precision", nullable: false),
                    customer_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_balance", x => x.id);
                    table.ForeignKey(
                        name: "fkf9n8fwyfughgs7taql4xunicf",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "customer_payment_entry",
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
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    pay_by = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    payment_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ref_no = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    remark = table.Column<string>(type: "text", nullable: true),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    total_amount = table.Column<double>(type: "double precision", nullable: true),
                    total_prepayment = table.Column<double>(type: "double precision", nullable: true),
                    total_receive = table.Column<double>(type: "double precision", nullable: true),
                    customer_id = table.Column<long>(type: "bigint", nullable: true),
                    gl_account_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_payment_entry", x => x.id);
                    table.ForeignKey(
                        name: "fk57sy5m9sf7dd7yaf3gf16atr2",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkh22nmln0o6nj96uc5xpevh79q",
                        column: x => x.gl_account_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "customer_pre_payment",
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
                    amount = table.Column<double>(type: "double precision", nullable: true),
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    is_byso = table.Column<bool>(type: "boolean", nullable: true),
                    last_prepayment_balance = table.Column<double>(type: "double precision", nullable: true),
                    pay_by = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    payment_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    payment_option = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ref_no = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    remark = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    customer_id = table.Column<long>(type: "bigint", nullable: true),
                    gl_account_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_pre_payment", x => x.id);
                    table.ForeignKey(
                        name: "fk5do5kmq9ptjkx0gfhh9925gtr",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk8e4mhvbv2tkwp6m8vhxexa8aj",
                        column: x => x.gl_account_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "glentry",
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
                    credit = table.Column<double>(type: "double precision", nullable: true),
                    debit = table.Column<double>(type: "double precision", nullable: true),
                    posting_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    remark = table.Column<string>(type: "text", nullable: true),
                    voucher_no = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    voucher_type = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    chart_of_acc_id = table.Column<long>(type: "bigint", nullable: true),
                    company_id = table.Column<long>(type: "bigint", nullable: true),
                    customer_id = table.Column<long>(type: "bigint", nullable: true),
                    supplier_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_glentry", x => x.id);
                    table.ForeignKey(
                        name: "fkddkiafnm6b7943wkm27ga05cp",
                        column: x => x.supplier_id,
                        principalTable: "supplier",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkgaus8fntma0p3c8qbhut19hrq",
                        column: x => x.chart_of_acc_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkqyejgrlqjbvb5i6s9pcif0a1l",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkrwsauigc92o8nmet06v3tdahx",
                        column: x => x.company_id,
                        principalTable: "company",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "serial_no",
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
                    asset = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    asset_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    batch_no = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    delivery_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    delivery_series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    employee = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    maintenance_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    purchase_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    purchase_series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    serial_no = table.Column<string>(type: "text", nullable: true),
                    serial_no_detail = table.Column<string>(type: "text", nullable: true),
                    warranty_expire_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    warranty_period = table.Column<float>(type: "real", nullable: true),
                    customer_id = table.Column<long>(type: "bigint", nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: true),
                    supplier_id = table.Column<long>(type: "bigint", nullable: true),
                    warehouse_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serial_no", x => x.id);
                    table.ForeignKey(
                        name: "fk12whkb1ay28e7tb5gtyrvf7al",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk6lj6wh3asrk2hko0svbdt35rl",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk82emfq13asu8nd6f6k38vc3d9",
                        column: x => x.warehouse_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkrq4108andi458n7l5m2scxjj7",
                        column: x => x.supplier_id,
                        principalTable: "supplier",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "purchase_invoice_purchase_invoice_detail",
                columns: table => new
                {
                    purchase_invoice_id = table.Column<long>(type: "bigint", nullable: false),
                    purchase_invoice_detail_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "fkama1ihgl41btxcmihmo9to459",
                        column: x => x.purchase_invoice_detail_id,
                        principalTable: "purchase_invoice_detail",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkrbcchir06n1vkv4shy0ep16bj",
                        column: x => x.purchase_invoice_id,
                        principalTable: "purchase_invoice",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "customer_payment_entry_reference",
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
                    invamount = table.Column<double>(type: "double precision", nullable: true),
                    invid = table.Column<int>(type: "integer", nullable: true),
                    invoutstanding = table.Column<double>(type: "double precision", nullable: true),
                    invseries = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    soid = table.Column<int>(type: "integer", nullable: true),
                    soseries = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    amount_to_receive = table.Column<double>(type: "double precision", nullable: true),
                    apply_prepayment = table.Column<double>(type: "double precision", nullable: true),
                    balance = table.Column<double>(type: "double precision", nullable: true),
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    customer_payment_entry_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_payment_entry_reference", x => x.id);
                    table.ForeignKey(
                        name: "fks7foprukq05ox9qs8iu7rvvo",
                        column: x => x.customer_payment_entry_id,
                        principalTable: "customer_payment_entry",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "address",
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
                    is_billing_address = table.Column<bool>(type: "boolean", nullable: true),
                    is_shipping_address = table.Column<bool>(type: "boolean", nullable: true),
                    address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    house_no = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    is_default_billing_add = table.Column<bool>(type: "boolean", nullable: true),
                    is_default_shipping_add = table.Column<bool>(type: "boolean", nullable: true),
                    phone = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    postal_code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    street_no = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    address_type_id = table.Column<long>(type: "bigint", nullable: true),
                    billing_address_id = table.Column<long>(type: "bigint", nullable: true),
                    city_id = table.Column<long>(type: "bigint", nullable: true),
                    commune_id = table.Column<long>(type: "bigint", nullable: true),
                    country_id = table.Column<long>(type: "bigint", nullable: true),
                    customer_id = table.Column<long>(type: "bigint", nullable: true),
                    district_id = table.Column<long>(type: "bigint", nullable: true),
                    province_id = table.Column<long>(type: "bigint", nullable: true),
                    shipping_address_id = table.Column<long>(type: "bigint", nullable: true),
                    village_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address", x => x.id);
                    table.ForeignKey(
                        name: "fk93c3js0e22ll1xlu21nvrhqgg",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fke54x81nmccsk5569hsjg1a6ka",
                        column: x => x.country_id,
                        principalTable: "country",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkf8x0jfwoo94op8u88og1ohdcn",
                        column: x => x.province_id,
                        principalTable: "province",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkgufu9edl0iiai9gwjs84iwmgb",
                        column: x => x.village_id,
                        principalTable: "village",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkkkjn52mg1vha4yjpm0douso7f",
                        column: x => x.address_type_id,
                        principalTable: "address_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkpo044ng5x4gynb291cv24vtea",
                        column: x => x.city_id,
                        principalTable: "city",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkqbjwfi50pdenou8j14knnffrh",
                        column: x => x.district_id,
                        principalTable: "district",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkrgjcv55f47qp01ul9ilqpp1jm",
                        column: x => x.commune_id,
                        principalTable: "commune",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "credit_note",
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
                    credit_note_amount = table.Column<double>(type: "double precision", nullable: true),
                    custom_status = table.Column<string>(type: "text", nullable: true),
                    date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    invoice_amount = table.Column<double>(type: "double precision", nullable: true),
                    is_include_vat = table.Column<bool>(type: "boolean", nullable: true),
                    remark = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    customer_id = table.Column<long>(type: "bigint", nullable: true),
                    invoice_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_credit_note", x => x.id);
                    table.ForeignKey(
                        name: "fkjnm35f89ygl7dry1owswglhqm",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "customer_pre_payment_reference",
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
                    soid = table.Column<long>(type: "bigint", nullable: true),
                    sooutstanding_amount = table.Column<double>(type: "double precision", nullable: true),
                    soprepayment_amount = table.Column<double>(type: "double precision", nullable: true),
                    soseries = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    sototal_amount = table.Column<double>(type: "double precision", nullable: true),
                    amount = table.Column<double>(type: "double precision", nullable: true),
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    customer_pre_payment_id = table.Column<long>(type: "bigint", nullable: true),
                    sale_order_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_pre_payment_reference", x => x.id);
                    table.ForeignKey(
                        name: "fk4a13ldm66l93qnhp6qktcwev5",
                        column: x => x.customer_pre_payment_id,
                        principalTable: "customer_pre_payment",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "delivery_note",
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
                    additional_dis_amount = table.Column<double>(type: "double precision", nullable: true),
                    additional_dis_per = table.Column<float>(type: "real", nullable: true),
                    billing_address = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    billing_address_id = table.Column<int>(type: "integer", nullable: true),
                    billing_title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    date_done = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    grand_total = table.Column<double>(type: "double precision", nullable: true),
                    immediate_transfer = table.Column<bool>(type: "boolean", nullable: true),
                    note = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    priority = table.Column<int>(type: "integer", nullable: true),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    shipping_address = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    shipping_address_id = table.Column<int>(type: "integer", nullable: true),
                    shipping_title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    total = table.Column<double>(type: "double precision", nullable: true),
                    total_qty = table.Column<int>(type: "integer", nullable: true),
                    vat_amount = table.Column<double>(type: "double precision", nullable: true),
                    vat_per = table.Column<float>(type: "real", nullable: true),
                    warehouse_address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    customer_id = table.Column<long>(type: "bigint", nullable: true),
                    delivery_type_id = table.Column<long>(type: "bigint", nullable: true),
                    driver_id = table.Column<long>(type: "bigint", nullable: true),
                    sale_order_id = table.Column<long>(type: "bigint", nullable: true),
                    warehouse_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_delivery_note", x => x.id);
                    table.ForeignKey(
                        name: "fk17mxrj7yugeib8lnlqhc8cd9w",
                        column: x => x.driver_id,
                        principalTable: "drivers",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkaiucygc91ane0529jku2xmf1d",
                        column: x => x.delivery_type_id,
                        principalTable: "delivery_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkkwdm71exscpr91q9nij9ldfnb",
                        column: x => x.warehouse_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkseacucm0oxv4jc7r2gnyumn63",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "delivery_note_detail",
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
                    has_serial_no = table.Column<bool>(type: "boolean", nullable: false),
                    amount = table.Column<double>(type: "double precision", nullable: true),
                    conversion_factor = table.Column<float>(type: "real", nullable: true),
                    discount = table.Column<float>(type: "real", nullable: true),
                    discount_percent = table.Column<float>(type: "real", nullable: true),
                    qty = table.Column<float>(type: "real", nullable: true),
                    rate = table.Column<double>(type: "double precision", nullable: true),
                    serial_no = table.Column<string>(type: "text", nullable: true),
                    stock_qty = table.Column<float>(type: "real", nullable: true),
                    delivery_note_id = table.Column<long>(type: "bigint", nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: true),
                    item_variant_uom_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_delivery_note_detail", x => x.id);
                    table.ForeignKey(
                        name: "fk3i76varnkfb5q1dcslgrmw2ps",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk5yeex2kdj183yd3nx3sc2ayom",
                        column: x => x.item_variant_uom_id,
                        principalTable: "item_varrant_uom",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkblpd8dld5cwhkldgkadcmgmwf",
                        column: x => x.delivery_note_id,
                        principalTable: "delivery_note",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "invoice",
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
                    additional_dis_amount = table.Column<double>(type: "double precision", nullable: true),
                    additional_dis_per = table.Column<float>(type: "real", nullable: true),
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    due_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    grand_total = table.Column<float>(type: "real", nullable: true),
                    invoice_amount = table.Column<double>(type: "double precision", nullable: true),
                    invoice_per = table.Column<float>(type: "real", nullable: true),
                    is_include_vat = table.Column<bool>(type: "boolean", nullable: true),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    shipping_address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    total = table.Column<double>(type: "double precision", nullable: true),
                    total_cost = table.Column<double>(type: "double precision", nullable: true),
                    total_qty = table.Column<float>(type: "real", nullable: true),
                    unpaid_amount = table.Column<float>(type: "real", nullable: true),
                    vat_amount = table.Column<double>(type: "double precision", nullable: true),
                    vat_per = table.Column<float>(type: "real", nullable: true),
                    warehouse_address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    customer_id = table.Column<long>(type: "bigint", nullable: true),
                    delivery_note_id = table.Column<long>(type: "bigint", nullable: true),
                    sale_order_id = table.Column<long>(type: "bigint", nullable: true),
                    warehouse_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoice", x => x.id);
                    table.ForeignKey(
                        name: "fk5e32ukwo9uknwhylogvta4po6",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk6g33jwwe19ep5yl3p2cfpy40j",
                        column: x => x.delivery_note_id,
                        principalTable: "delivery_note",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk9ssjinbkdd04ccgtua4tjy5n9",
                        column: x => x.warehouse_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "invoice_detail",
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
                    amount = table.Column<double>(type: "double precision", nullable: true),
                    conversion_factor = table.Column<float>(type: "real", nullable: true),
                    cost = table.Column<double>(type: "double precision", nullable: true),
                    discount = table.Column<float>(type: "real", nullable: true),
                    discount_percent = table.Column<float>(type: "real", nullable: true),
                    qty = table.Column<int>(type: "integer", nullable: true),
                    rate = table.Column<double>(type: "double precision", nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: true),
                    item_variant_uom__id = table.Column<long>(type: "bigint", nullable: true),
                    sale_invoice_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoice_detail", x => x.id);
                    table.ForeignKey(
                        name: "fk3kqpm1vs7me9627k0v69yrhxf",
                        column: x => x.sale_invoice_id,
                        principalTable: "invoice",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk4kdkykjwo7h7hj6qgs8cxtf3b",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkqdciiqn3rbn01conu2cpcpo3k",
                        column: x => x.item_variant_uom__id,
                        principalTable: "item_varrant_uom",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "refund",
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
                    credit_noted_amount = table.Column<double>(type: "double precision", nullable: true),
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    invoice_amount = table.Column<double>(type: "double precision", nullable: true),
                    invoice_no = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    payment_option = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    reference_no = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    refund_amount = table.Column<double>(type: "double precision", nullable: true),
                    remark = table.Column<string>(type: "text", nullable: true),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    credit_note_id = table.Column<long>(type: "bigint", nullable: true),
                    customer_id = table.Column<long>(type: "bigint", nullable: true),
                    gl_account_id = table.Column<long>(type: "bigint", nullable: true),
                    invoice_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refund", x => x.id);
                    table.ForeignKey(
                        name: "fk4g7imna3evv9fxup6kdhbm5hu",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk4ny5ywx78sgoir4c4gifedx7e",
                        column: x => x.invoice_id,
                        principalTable: "invoice",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkhw0lummngd0f8k4qloc90rpxg",
                        column: x => x.gl_account_id,
                        principalTable: "chart_of_account",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkmj8r0hapy9gevko3ioskaolcl",
                        column: x => x.credit_note_id,
                        principalTable: "credit_note",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "quotation",
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
                    additional_dis_amount = table.Column<float>(type: "real", nullable: true),
                    additional_dis_per = table.Column<float>(type: "real", nullable: true),
                    additional_note = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    billing_address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    billing_address_id = table.Column<int>(type: "integer", nullable: true),
                    billing_title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    cus_purchase_order = table.Column<int>(type: "integer", nullable: true),
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    estimate_delivery_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    expired_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    grand_total = table.Column<float>(type: "real", nullable: true),
                    is_include_vat = table.Column<bool>(type: "boolean", nullable: true),
                    post_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    shipping_address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    shipping_address_id = table.Column<int>(type: "integer", nullable: true),
                    shipping_title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    total = table.Column<double>(type: "double precision", nullable: true),
                    total_cost = table.Column<float>(type: "real", nullable: true),
                    total_qty = table.Column<int>(type: "integer", nullable: true),
                    total_tax_charge = table.Column<float>(type: "real", nullable: true),
                    vat_amount = table.Column<float>(type: "real", nullable: true),
                    vat_per = table.Column<float>(type: "real", nullable: true),
                    currency_id = table.Column<long>(type: "bigint", nullable: true),
                    customer_id = table.Column<long>(type: "bigint", nullable: true),
                    price_list_id = table.Column<long>(type: "bigint", nullable: true),
                    sale_order_id = table.Column<long>(type: "bigint", nullable: true),
                    sale_person_id = table.Column<long>(type: "bigint", nullable: true),
                    term_condition_id = table.Column<long>(type: "bigint", nullable: true),
                    warehouse_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quotation", x => x.id);
                    table.ForeignKey(
                        name: "fk5n98enejkc4c61wvjendapyeb",
                        column: x => x.warehouse_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fklf5ti8fw77uew5ivt1rh1dlrd",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fknyfnm3d1yknkkxg43x23k96va",
                        column: x => x.term_condition_id,
                        principalTable: "term_condition",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkpjff3qs6do3e4423n7583n4oh",
                        column: x => x.sale_person_id,
                        principalTable: "sale_person",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkqw4us6raa0axrfll4utr2jyyh",
                        column: x => x.price_list_id,
                        principalTable: "price_list",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkriqr781i8uaks8kw4hipfejmu",
                        column: x => x.currency_id,
                        principalTable: "currency",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "quotation_detail",
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
                    amount = table.Column<double>(type: "double precision", nullable: true),
                    conversion_factor = table.Column<double>(type: "double precision", nullable: true),
                    cost = table.Column<double>(type: "double precision", nullable: true),
                    delivery_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    delivery_fee = table.Column<double>(type: "double precision", nullable: true),
                    discount = table.Column<float>(type: "real", nullable: true),
                    discount_percent = table.Column<float>(type: "real", nullable: true),
                    qty = table.Column<float>(type: "real", nullable: true),
                    rate = table.Column<double>(type: "double precision", nullable: true),
                    stock_qty = table.Column<double>(type: "double precision", nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: true),
                    item_variant_uom_id = table.Column<long>(type: "bigint", nullable: true),
                    quotation_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quotation_detail", x => x.id);
                    table.ForeignKey(
                        name: "fk35aokq9ogjh42ekkv5n6n78o",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk5uhuhl4i0dvr1lqwn3cv35wl",
                        column: x => x.quotation_id,
                        principalTable: "quotation",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkt222p3ii54d1qstkcymb0osch",
                        column: x => x.item_variant_uom_id,
                        principalTable: "item_varrant_uom",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "sale_order",
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
                    additional_dis_amount = table.Column<float>(type: "real", nullable: true),
                    additional_dis_per = table.Column<float>(type: "real", nullable: true),
                    additional_note = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    billed_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    billing_address = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    billing_address_id = table.Column<int>(type: "integer", nullable: true),
                    billing_title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    cus_purchase_order = table.Column<int>(type: "integer", nullable: true),
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    delivery_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    estimate_delivery_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    first_process_flow = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    grand_total = table.Column<float>(type: "real", nullable: true),
                    is_deposit = table.Column<bool>(type: "boolean", nullable: true),
                    is_include_vat = table.Column<bool>(type: "boolean", nullable: true),
                    per_billed = table.Column<float>(type: "real", nullable: true),
                    per_delivered = table.Column<float>(type: "real", nullable: true),
                    post_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    prepayment_amount = table.Column<double>(type: "double precision", nullable: true),
                    prepayment_balance = table.Column<double>(type: "double precision", nullable: true),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    shipping_address = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    shipping_address_id = table.Column<int>(type: "integer", nullable: true),
                    shipping_title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    total = table.Column<double>(type: "double precision", nullable: true),
                    total_cost = table.Column<double>(type: "double precision", nullable: true),
                    total_qty = table.Column<int>(type: "integer", nullable: true),
                    total_tax_charge = table.Column<float>(type: "real", nullable: true),
                    vat_amount = table.Column<double>(type: "double precision", nullable: true),
                    vat_per = table.Column<float>(type: "real", nullable: true),
                    currency_id = table.Column<long>(type: "bigint", nullable: true),
                    customer_id = table.Column<long>(type: "bigint", nullable: true),
                    price_list_id = table.Column<long>(type: "bigint", nullable: true),
                    quotation_id = table.Column<long>(type: "bigint", nullable: true),
                    sale_person_id = table.Column<long>(type: "bigint", nullable: true),
                    warehouse_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sale_order", x => x.id);
                    table.ForeignKey(
                        name: "fk66ivraj759yed1m8bow8o2q6l",
                        column: x => x.price_list_id,
                        principalTable: "price_list",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk6e9jxg1jpu3b8dro6diuphdn8",
                        column: x => x.currency_id,
                        principalTable: "currency",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk8bf2b8po4cpyc8jew5ve43ohm",
                        column: x => x.sale_person_id,
                        principalTable: "sale_person",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkfe1q5gxqihxkop8uycrfuxg5j",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkgk5vd2s6eqpcd2lxwu5miocao",
                        column: x => x.quotation_id,
                        principalTable: "quotation",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkntbtuvtqepg0h1tb05joy0l4s",
                        column: x => x.warehouse_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "sale_order_detail",
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
                    amount = table.Column<double>(type: "double precision", nullable: true),
                    conversion_factor = table.Column<float>(type: "real", nullable: true),
                    cost = table.Column<double>(type: "double precision", nullable: true),
                    delivery_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    delivery_qty = table.Column<float>(type: "real", nullable: true),
                    discount = table.Column<float>(type: "real", nullable: true),
                    discount_percent = table.Column<float>(type: "real", nullable: true),
                    has_serial_no = table.Column<bool>(type: "boolean", nullable: true),
                    qty = table.Column<float>(type: "real", nullable: false),
                    rate = table.Column<double>(type: "double precision", nullable: false),
                    remain_qty = table.Column<float>(type: "real", nullable: true),
                    serial_no = table.Column<string>(type: "text", nullable: true),
                    stock_qty = table.Column<float>(type: "real", nullable: true),
                    total_cost = table.Column<double>(type: "double precision", nullable: true),
                    valuation_rate = table.Column<double>(type: "double precision", nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: true),
                    item_variant_uom_id = table.Column<long>(type: "bigint", nullable: true),
                    sale_order_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sale_order_detail", x => x.id);
                    table.ForeignKey(
                        name: "fk1isrkdb4ekuoeo7dsbyw1s9u0",
                        column: x => x.sale_order_id,
                        principalTable: "sale_order",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk9anlq0du5k2322fcpofmsarvl",
                        column: x => x.item_variant_uom_id,
                        principalTable: "item_varrant_uom",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkeeka85wbcfp5b70e8479j8c4f",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "sale_return",
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
                    custom_status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    discount = table.Column<double>(type: "double precision", nullable: true),
                    grand_total = table.Column<double>(type: "double precision", nullable: true),
                    remark = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    return_from = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    series = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    total = table.Column<double>(type: "double precision", nullable: true),
                    total_qty = table.Column<double>(type: "double precision", nullable: true),
                    currency_id = table.Column<long>(type: "bigint", nullable: true),
                    customer_id = table.Column<long>(type: "bigint", nullable: true),
                    delivery_note_id = table.Column<long>(type: "bigint", nullable: true),
                    sale_order_id = table.Column<long>(type: "bigint", nullable: true),
                    warehouse_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sale_return", x => x.id);
                    table.ForeignKey(
                        name: "fk68j2wpxymba2ile9k5lq8x5cv",
                        column: x => x.currency_id,
                        principalTable: "currency",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk6tbidj5qv83lp9btbv15yf2mm",
                        column: x => x.delivery_note_id,
                        principalTable: "delivery_note",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk7bxrucp94ndc7snxo8dhav0ce",
                        column: x => x.sale_order_id,
                        principalTable: "sale_order",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fklysn5lt6og1g77kqw54sshy1s",
                        column: x => x.warehouse_id,
                        principalTable: "warehouse",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkra8c7dye3yyej114bpakbjk8n",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "sale_return_detail",
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
                    amount = table.Column<double>(type: "double precision", nullable: true),
                    discount = table.Column<float>(type: "real", nullable: true),
                    discount_percentage = table.Column<float>(type: "real", nullable: true),
                    qty = table.Column<float>(type: "real", nullable: true),
                    rate = table.Column<double>(type: "double precision", nullable: true),
                    item_id = table.Column<long>(type: "bigint", nullable: true),
                    item_variant_uom__id = table.Column<long>(type: "bigint", nullable: true),
                    sale_return_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sale_return_detail", x => x.id);
                    table.ForeignKey(
                        name: "fkfxgvy4ow09mqstbro5sax7g17",
                        column: x => x.item_id,
                        principalTable: "item",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkg35ss7j8mod4vc6w2hgpgooce",
                        column: x => x.sale_return_id,
                        principalTable: "sale_return",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fkpqhbwdicpcl4ag79s35ua001t",
                        column: x => x.item_variant_uom__id,
                        principalTable: "item_varrant_uom",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_account_account_type_id",
                table: "account",
                column: "account_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_account_balance_id",
                table: "account",
                column: "balance_id");

            migrationBuilder.CreateIndex(
                name: "IX_account_company_id",
                table: "account",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_account_currency_id",
                table: "account",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_account_parent_id",
                table: "account",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_account_bill_account_bill_id",
                table: "account_bill",
                column: "account_bill_id");

            migrationBuilder.CreateIndex(
                name: "IX_account_bill_branch_id",
                table: "account_bill",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_account_bill_chart_of_account_id",
                table: "account_bill",
                column: "chart_of_account_id");

            migrationBuilder.CreateIndex(
                name: "IX_account_bill_currency_id",
                table: "account_bill",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_account_bill_supplier_id",
                table: "account_bill",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_account_bill_transaction_type_id",
                table: "account_bill",
                column: "transaction_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_account_bill_item_account_bill_id",
                table: "account_bill_item",
                column: "account_bill_id");

            migrationBuilder.CreateIndex(
                name: "IX_account_bill_item_chart_of_account_id",
                table: "account_bill_item",
                column: "chart_of_account_id");

            migrationBuilder.CreateIndex(
                name: "IX_account_class_balance_side_id",
                table: "account_class",
                column: "balance_side_id");

            migrationBuilder.CreateIndex(
                name: "IX_account_mapping_chart_of_acc_id",
                table: "account_mapping",
                column: "chart_of_acc_id");

            migrationBuilder.CreateIndex(
                name: "IX_account_mapping_trxn_type_id",
                table: "account_mapping",
                column: "trxn_type_id");

            migrationBuilder.CreateIndex(
                name: "uk_2xqbaypwpr0ho131uh6me1st9",
                table: "account_mapping",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_account_sub_class_account_class_id",
                table: "account_sub_class",
                column: "account_class_id");

            migrationBuilder.CreateIndex(
                name: "IX_address_address_type_id",
                table: "address",
                column: "address_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_address_billing_address_id",
                table: "address",
                column: "billing_address_id");

            migrationBuilder.CreateIndex(
                name: "IX_address_city_id",
                table: "address",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "IX_address_commune_id",
                table: "address",
                column: "commune_id");

            migrationBuilder.CreateIndex(
                name: "IX_address_country_id",
                table: "address",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "IX_address_customer_id",
                table: "address",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_address_district_id",
                table: "address",
                column: "district_id");

            migrationBuilder.CreateIndex(
                name: "IX_address_province_id",
                table: "address",
                column: "province_id");

            migrationBuilder.CreateIndex(
                name: "IX_address_shipping_address_id",
                table: "address",
                column: "shipping_address_id");

            migrationBuilder.CreateIndex(
                name: "IX_address_village_id",
                table: "address",
                column: "village_id");

            migrationBuilder.CreateIndex(
                name: "IX_asset_category_gl_accu_depre_id",
                table: "asset_category",
                column: "gl_accu_depre_id");

            migrationBuilder.CreateIndex(
                name: "IX_asset_category_gl_cost_id",
                table: "asset_category",
                column: "gl_cost_id");

            migrationBuilder.CreateIndex(
                name: "IX_asset_category_gl_depre_exp_id",
                table: "asset_category",
                column: "gl_depre_exp_id");

            migrationBuilder.CreateIndex(
                name: "IX_asset_category_gl_gain_id",
                table: "asset_category",
                column: "gl_gain_id");

            migrationBuilder.CreateIndex(
                name: "IX_asset_category_gl_loss_id",
                table: "asset_category",
                column: "gl_loss_id");

            migrationBuilder.CreateIndex(
                name: "IX_barcode_item_barcode_type_id",
                table: "barcode_item",
                column: "barcode_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_barcode_item_item_id",
                table: "barcode_item",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_chart_of_account_account_class_id",
                table: "chart_of_account",
                column: "account_class_id");

            migrationBuilder.CreateIndex(
                name: "IX_chart_of_account_account_sub_class_id",
                table: "chart_of_account",
                column: "account_sub_class_id");

            migrationBuilder.CreateIndex(
                name: "IX_chart_of_account_parent_id",
                table: "chart_of_account",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_clear_bill_branch_id",
                table: "clear_bill",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_clear_bill_chart_of_account_id",
                table: "clear_bill",
                column: "chart_of_account_id");

            migrationBuilder.CreateIndex(
                name: "IX_clear_bill_currency_id",
                table: "clear_bill",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_clear_bill_payment_method_id",
                table: "clear_bill",
                column: "payment_method_id");

            migrationBuilder.CreateIndex(
                name: "IX_clear_bill_transaction_type_id",
                table: "clear_bill",
                column: "transaction_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_coa_balance_branch_id",
                table: "coa_balance",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_coa_balance_chart_of_account_id",
                table: "coa_balance",
                column: "chart_of_account_id");

            migrationBuilder.CreateIndex(
                name: "IX_coa_balance_currency_id",
                table: "coa_balance",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_commune_district_id",
                table: "commune",
                column: "district_id");

            migrationBuilder.CreateIndex(
                name: "IX_company_country_id",
                table: "company",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "IX_company_currency_id",
                table: "company",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_company_domain_id",
                table: "company",
                column: "domain_id");

            migrationBuilder.CreateIndex(
                name: "IX_company_finance_book_id",
                table: "company",
                column: "finance_book_id");

            migrationBuilder.CreateIndex(
                name: "IX_company_letter_head_id",
                table: "company",
                column: "letter_head_id");

            migrationBuilder.CreateIndex(
                name: "IX_company_parent_id",
                table: "company",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_company_term_condition_id",
                table: "company",
                column: "term_condition_id");

            migrationBuilder.CreateIndex(
                name: "IX_company_warehouse_id",
                table: "company",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_contact_gender_id",
                table: "contact",
                column: "gender_id");

            migrationBuilder.CreateIndex(
                name: "IX_contact_salutation_id",
                table: "contact",
                column: "salutation_id");

            migrationBuilder.CreateIndex(
                name: "idx1i51elups6i8kk8ht3kgyr5cb",
                table: "credit_note",
                column: "series");

            migrationBuilder.CreateIndex(
                name: "IX_credit_note_customer_id",
                table: "credit_note",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_credit_note_invoice_id",
                table: "credit_note",
                column: "invoice_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_currency_id",
                table: "customer",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_customer_group_id",
                table: "customer",
                column: "customer_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_gender_id",
                table: "customer",
                column: "gender_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_price_list_id",
                table: "customer",
                column: "price_list_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_sale_person_id",
                table: "customer",
                column: "sale_person_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_salutation_id",
                table: "customer",
                column: "salutation_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_territory_id",
                table: "customer",
                column: "territory_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_warehouse_id",
                table: "customer",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_balance_customer_id",
                table: "customer_balance",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_group_parent_id",
                table: "customer_group",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_group_price_list_id",
                table: "customer_group",
                column: "price_list_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_group_term_condition_id",
                table: "customer_group",
                column: "term_condition_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_payment_entry_customer_id",
                table: "customer_payment_entry",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_payment_entry_gl_account_id",
                table: "customer_payment_entry",
                column: "gl_account_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_payment_entry_reference_customer_payment_entry_id",
                table: "customer_payment_entry_reference",
                column: "customer_payment_entry_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_pre_payment_customer_id",
                table: "customer_pre_payment",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_pre_payment_gl_account_id",
                table: "customer_pre_payment",
                column: "gl_account_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_pre_payment_reference_customer_pre_payment_id",
                table: "customer_pre_payment_reference",
                column: "customer_pre_payment_id");

            migrationBuilder.CreateIndex(
                name: "IX_customer_pre_payment_reference_sale_order_id",
                table: "customer_pre_payment_reference",
                column: "sale_order_id");

            migrationBuilder.CreateIndex(
                name: "idxl8yek74ethrix13a64pt5y7tt",
                table: "debit_note",
                column: "series");

            migrationBuilder.CreateIndex(
                name: "IX_debit_note_purchase_return_id",
                table: "debit_note",
                column: "purchase_return_id");

            migrationBuilder.CreateIndex(
                name: "IX_debit_note_supplier_id",
                table: "debit_note",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "idxeu5ex12ndxk13mda3sq5dfe34",
                table: "delivery_note",
                column: "series");

            migrationBuilder.CreateIndex(
                name: "IX_delivery_note_customer_id",
                table: "delivery_note",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_delivery_note_delivery_type_id",
                table: "delivery_note",
                column: "delivery_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_delivery_note_driver_id",
                table: "delivery_note",
                column: "driver_id");

            migrationBuilder.CreateIndex(
                name: "IX_delivery_note_sale_order_id",
                table: "delivery_note",
                column: "sale_order_id");

            migrationBuilder.CreateIndex(
                name: "IX_delivery_note_warehouse_id",
                table: "delivery_note",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_delivery_note_detail_delivery_note_id",
                table: "delivery_note_detail",
                column: "delivery_note_id");

            migrationBuilder.CreateIndex(
                name: "IX_delivery_note_detail_item_id",
                table: "delivery_note_detail",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_delivery_note_detail_item_variant_uom_id",
                table: "delivery_note_detail",
                column: "item_variant_uom_id");

            migrationBuilder.CreateIndex(
                name: "IX_district_province_id",
                table: "district",
                column: "province_id");

            migrationBuilder.CreateIndex(
                name: "idx8vql0es88p6virsa77nqnot1y",
                table: "document_setting",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "uk_34ksnj6rogabks5ux36aexjfv",
                table: "document_setting",
                column: "non_vat_prefix",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "uk_59vl05p8a1g8vknuiv7jobj8c",
                table: "document_setting",
                column: "prefix",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "uk_8vql0es88p6virsa77nqnot1y",
                table: "document_setting",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idxm51sy2i8dqhonkl6sixli37he",
                table: "drivers",
                column: "series");

            migrationBuilder.CreateIndex(
                name: "IX_drivers_driver_status_id",
                table: "drivers",
                column: "driver_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_drivers_employee_id",
                table: "drivers",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_employee_company_id",
                table: "employee",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_employee_employee_type_id",
                table: "employee",
                column: "employee_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_employee_gender_id",
                table: "employee",
                column: "gender_id");

            migrationBuilder.CreateIndex(
                name: "IX_employee_health_insurance_id",
                table: "employee",
                column: "health_insurance_id");

            migrationBuilder.CreateIndex(
                name: "IX_employee_salutation_id",
                table: "employee",
                column: "salutation_id");

            migrationBuilder.CreateIndex(
                name: "idx1drhu9i7fqp05eg7bh43lndep",
                table: "glentry",
                column: "posting_date");

            migrationBuilder.CreateIndex(
                name: "idxpvlt0snlbaku13ra2tt5i256y",
                table: "glentry",
                column: "voucher_no");

            migrationBuilder.CreateIndex(
                name: "IX_glentry_chart_of_acc_id",
                table: "glentry",
                column: "chart_of_acc_id");

            migrationBuilder.CreateIndex(
                name: "IX_glentry_company_id",
                table: "glentry",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_glentry_customer_id",
                table: "glentry",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_glentry_supplier_id",
                table: "glentry",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "idxr8y2erlq5c9s7pkspmg3ebpdc",
                table: "global_search",
                column: "title");

            migrationBuilder.CreateIndex(
                name: "idxc3ftrohmw09g5yfr4liliy02v",
                table: "invoice",
                column: "series");

            migrationBuilder.CreateIndex(
                name: "IX_invoice_customer_id",
                table: "invoice",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_invoice_delivery_note_id",
                table: "invoice",
                column: "delivery_note_id");

            migrationBuilder.CreateIndex(
                name: "IX_invoice_sale_order_id",
                table: "invoice",
                column: "sale_order_id");

            migrationBuilder.CreateIndex(
                name: "IX_invoice_warehouse_id",
                table: "invoice",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_invoice_detail_item_id",
                table: "invoice_detail",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_invoice_detail_item_variant_uom__id",
                table: "invoice_detail",
                column: "item_variant_uom__id");

            migrationBuilder.CreateIndex(
                name: "IX_invoice_detail_sale_invoice_id",
                table: "invoice_detail",
                column: "sale_invoice_id");

            migrationBuilder.CreateIndex(
                name: "idx4xwxmd7c5scggdhewiue7fopp",
                table: "item",
                column: "item_code");

            migrationBuilder.CreateIndex(
                name: "idxmqo9xeh2a6fvb17cqpmo1q72n",
                table: "item",
                column: "item_name");

            migrationBuilder.CreateIndex(
                name: "IX_item_item_brand_id",
                table: "item",
                column: "item_brand_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_item_group_id",
                table: "item",
                column: "item_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_uom_id",
                table: "item",
                column: "uom_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_valuation_method_id",
                table: "item",
                column: "valuation_method_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_attribute_detail_item_attribute_id",
                table: "item_attribute_detail",
                column: "item_attribute_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_attribute_value_item_attribute_detail_id",
                table: "item_attribute_value",
                column: "item_attribute_detail_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_attribute_value_item_attribute_id",
                table: "item_attribute_value",
                column: "item_attribute_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_attribute_value_item_item_id",
                table: "item_attribute_value",
                column: "item_item_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_group_parent_id",
                table: "item_group",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_image_item_id",
                table: "item_image",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_inventory_item_id",
                table: "item_inventory",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_inventory_material_request_type_id",
                table: "item_inventory",
                column: "material_request_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_inventory_uom_id",
                table: "item_inventory",
                column: "uom_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_inventory_valuation_method_id",
                table: "item_inventory",
                column: "valuation_method_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_items_item_id",
                table: "item_items",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_price_currency_id",
                table: "item_price",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_price_item_id",
                table: "item_price",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_price_price_list_id",
                table: "item_price",
                column: "price_list_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_tax_account_id",
                table: "item_tax",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_tax_item_id",
                table: "item_tax",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_varrant_uom_item_id",
                table: "item_varrant_uom",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_varrant_uom_uom_id",
                table: "item_varrant_uom",
                column: "uom_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_warehouse_company_id",
                table: "item_warehouse",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_warehouse_item_id",
                table: "item_warehouse",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_warehouse_price_list_id",
                table: "item_warehouse",
                column: "price_list_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_warehouse_warehouse_id",
                table: "item_warehouse",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_journal_entry_branch_id",
                table: "journal_entry",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_journal_entry_currency_id",
                table: "journal_entry",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_journal_entry_trxn_type_id",
                table: "journal_entry",
                column: "trxn_type_id");

            migrationBuilder.CreateIndex(
                name: "uk_m63q3sk9p3gt4wteto2ckc5sg",
                table: "permission",
                column: "feature_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_price_list_currency_id",
                table: "price_list",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "idx7wn0qc6932b6uhmf1ke9iw635",
                table: "purchase_invoice",
                column: "series");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_invoice_currency_id",
                table: "purchase_invoice",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_invoice_purchase_order_id",
                table: "purchase_invoice",
                column: "purchase_order_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_invoice_purchase_receipt_id",
                table: "purchase_invoice",
                column: "purchase_receipt_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_invoice_supplier_id",
                table: "purchase_invoice",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_invoice_warehouse_id",
                table: "purchase_invoice",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_invoice_detail_item_id",
                table: "purchase_invoice_detail",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_invoice_detail_item_variant_uom__id",
                table: "purchase_invoice_detail",
                column: "item_variant_uom__id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_invoice_detail_purchase_invoice_id",
                table: "purchase_invoice_detail",
                column: "purchase_invoice_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_invoice_purchase_invoice_detail_purchase_invoice_id",
                table: "purchase_invoice_purchase_invoice_detail",
                column: "purchase_invoice_id");

            migrationBuilder.CreateIndex(
                name: "uk_523pbs526qoeltrrbiqqmm2m3",
                table: "purchase_invoice_purchase_invoice_detail",
                column: "purchase_invoice_detail_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_purchase_item_item_id",
                table: "purchase_item",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_item_uom_id",
                table: "purchase_item",
                column: "uom_id");

            migrationBuilder.CreateIndex(
                name: "idx5ny4s4qvd5lg0q2fydgxcv6ow",
                table: "purchase_order",
                column: "series");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_order_contact_id",
                table: "purchase_order",
                column: "contact_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_order_currency_id",
                table: "purchase_order",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_order_price_list_id",
                table: "purchase_order",
                column: "price_list_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_order_supplier_id",
                table: "purchase_order",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_order_warehouse_id",
                table: "purchase_order",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_order_detail_item_id",
                table: "purchase_order_detail",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_order_detail_item_variant_uom__id",
                table: "purchase_order_detail",
                column: "item_variant_uom__id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_order_detail_purchase_order_id",
                table: "purchase_order_detail",
                column: "purchase_order_id");

            migrationBuilder.CreateIndex(
                name: "idx23c88ptlr39apyxyx6p6w4u6m",
                table: "purchase_receipt",
                column: "series");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_receipt_contact_id",
                table: "purchase_receipt",
                column: "contact_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_receipt_currency_id",
                table: "purchase_receipt",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_receipt_price_list_id",
                table: "purchase_receipt",
                column: "price_list_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_receipt_purchase_order_id",
                table: "purchase_receipt",
                column: "purchase_order_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_receipt_supplier_id",
                table: "purchase_receipt",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_receipt_warehouse_id",
                table: "purchase_receipt",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_receipt_detail_item_id",
                table: "purchase_receipt_detail",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_receipt_detail_item_variant_uom__id",
                table: "purchase_receipt_detail",
                column: "item_variant_uom__id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_receipt_detail_purchase_receipt_id",
                table: "purchase_receipt_detail",
                column: "purchase_receipt_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_receipt_expanse_expanse_category_id",
                table: "purchase_receipt_expanse",
                column: "expanse_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_receipt_expanse_purchase_receipt_id",
                table: "purchase_receipt_expanse",
                column: "purchase_receipt_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_receipt_expanse_supplier_id",
                table: "purchase_receipt_expanse",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "idxfabjy9hw2uq2hsh64icyg45dp",
                table: "purchase_refund",
                column: "series");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_refund_debit_note_id",
                table: "purchase_refund",
                column: "debit_note_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_refund_gl_account_id",
                table: "purchase_refund",
                column: "gl_account_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_refund_supplier_id",
                table: "purchase_refund",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "idxgfj7vg4hkcyfrnhkk8reeei7p",
                table: "purchase_return",
                column: "series");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_return_supplier_id",
                table: "purchase_return",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_return_warehouse_id",
                table: "purchase_return",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_return_detail_item_id",
                table: "purchase_return_detail",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_return_detail_item_variant_uom_id",
                table: "purchase_return_detail",
                column: "item_variant_uom_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_return_detail_purchase_return_id",
                table: "purchase_return_detail",
                column: "purchase_return_id");

            migrationBuilder.CreateIndex(
                name: "idxg7n3afp81sr8t1hxo2meu3aj1",
                table: "quotation",
                column: "series");

            migrationBuilder.CreateIndex(
                name: "IX_quotation_currency_id",
                table: "quotation",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_quotation_customer_id",
                table: "quotation",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_quotation_price_list_id",
                table: "quotation",
                column: "price_list_id");

            migrationBuilder.CreateIndex(
                name: "IX_quotation_sale_order_id",
                table: "quotation",
                column: "sale_order_id");

            migrationBuilder.CreateIndex(
                name: "IX_quotation_sale_person_id",
                table: "quotation",
                column: "sale_person_id");

            migrationBuilder.CreateIndex(
                name: "IX_quotation_term_condition_id",
                table: "quotation",
                column: "term_condition_id");

            migrationBuilder.CreateIndex(
                name: "IX_quotation_warehouse_id",
                table: "quotation",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_quotation_detail_item_id",
                table: "quotation_detail",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_quotation_detail_item_variant_uom_id",
                table: "quotation_detail",
                column: "item_variant_uom_id");

            migrationBuilder.CreateIndex(
                name: "IX_quotation_detail_quotation_id",
                table: "quotation_detail",
                column: "quotation_id");

            migrationBuilder.CreateIndex(
                name: "idxiaf0hxc896ewo9xorfwsfhaij",
                table: "refund",
                column: "series");

            migrationBuilder.CreateIndex(
                name: "IX_refund_credit_note_id",
                table: "refund",
                column: "credit_note_id");

            migrationBuilder.CreateIndex(
                name: "IX_refund_customer_id",
                table: "refund",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_refund_gl_account_id",
                table: "refund",
                column: "gl_account_id");

            migrationBuilder.CreateIndex(
                name: "IX_refund_invoice_id",
                table: "refund",
                column: "invoice_id");

            migrationBuilder.CreateIndex(
                name: "uk_iubw515ff0ugtm28p8g3myt0h",
                table: "role",
                column: "role_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_role_menu_menu_item_id",
                table: "role_menu",
                column: "menu_item_id");

            migrationBuilder.CreateIndex(
                name: "IX_role_menu_role_id",
                table: "role_menu",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_role_permission_permission_id",
                table: "role_permission",
                column: "permission_id");

            migrationBuilder.CreateIndex(
                name: "IX_role_permission_role_id",
                table: "role_permission",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "idxqbmft4q1dmjlerprud17m172k",
                table: "sale_order",
                column: "series");

            migrationBuilder.CreateIndex(
                name: "IX_sale_order_currency_id",
                table: "sale_order",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_order_customer_id",
                table: "sale_order",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_order_price_list_id",
                table: "sale_order",
                column: "price_list_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_order_quotation_id",
                table: "sale_order",
                column: "quotation_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_order_sale_person_id",
                table: "sale_order",
                column: "sale_person_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_order_warehouse_id",
                table: "sale_order",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_order_detail_item_id",
                table: "sale_order_detail",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_order_detail_item_variant_uom_id",
                table: "sale_order_detail",
                column: "item_variant_uom_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_order_detail_sale_order_id",
                table: "sale_order_detail",
                column: "sale_order_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_person_employee_id",
                table: "sale_person",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_person_parent_id",
                table: "sale_person",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "idxix1ctilkl2tb93ca3mjm8ucyj",
                table: "sale_return",
                column: "series");

            migrationBuilder.CreateIndex(
                name: "IX_sale_return_currency_id",
                table: "sale_return",
                column: "currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_return_customer_id",
                table: "sale_return",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_return_delivery_note_id",
                table: "sale_return",
                column: "delivery_note_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_return_sale_order_id",
                table: "sale_return",
                column: "sale_order_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_return_warehouse_id",
                table: "sale_return",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_return_detail_item_id",
                table: "sale_return_detail",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_return_detail_item_variant_uom__id",
                table: "sale_return_detail",
                column: "item_variant_uom__id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_return_detail_sale_return_id",
                table: "sale_return_detail",
                column: "sale_return_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_tax_charge_company_id",
                table: "sale_tax_charge",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_tax_detail_account_id",
                table: "sale_tax_detail",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_tax_detail_sale_tax_charge_id",
                table: "sale_tax_detail",
                column: "sale_tax_charge_id");

            migrationBuilder.CreateIndex(
                name: "IX_sale_tax_detail_sale_tax_type_id",
                table: "sale_tax_detail",
                column: "sale_tax_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_salutation_gender_id",
                table: "salutation",
                column: "gender_id");

            migrationBuilder.CreateIndex(
                name: "IX_serial_no_customer_id",
                table: "serial_no",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_serial_no_item_id",
                table: "serial_no",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_serial_no_supplier_id",
                table: "serial_no",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_serial_no_warehouse_id",
                table: "serial_no",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_stock_balance_company_id",
                table: "stock_balance",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_stock_balance_item_brand_id",
                table: "stock_balance",
                column: "item_brand_id");

            migrationBuilder.CreateIndex(
                name: "IX_stock_balance_item_group_id",
                table: "stock_balance",
                column: "item_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_stock_balance_item_id",
                table: "stock_balance",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_stock_balance_uom_id",
                table: "stock_balance",
                column: "uom_id");

            migrationBuilder.CreateIndex(
                name: "IX_stock_balance_warehouse_id",
                table: "stock_balance",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_stock_ledger_entry_item_id",
                table: "stock_ledger_entry",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_stock_ledger_entry_uom_id",
                table: "stock_ledger_entry",
                column: "uom_id");

            migrationBuilder.CreateIndex(
                name: "IX_stock_ledger_entry_warehouse_id",
                table: "stock_ledger_entry",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_stock_move_item_id",
                table: "stock_move",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_stock_move_warehouse_id",
                table: "stock_move",
                column: "warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_supplier_supplier_group_id",
                table: "supplier",
                column: "supplier_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_supplier_supplier_type_id",
                table: "supplier",
                column: "supplier_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_supplier_group_parent_id",
                table: "supplier_group",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "idxj2xgusphcaj5mq9u9obuh6o4v",
                table: "supplier_payment",
                column: "series");

            migrationBuilder.CreateIndex(
                name: "IX_supplier_payment_gl_account_id",
                table: "supplier_payment",
                column: "gl_account_id");

            migrationBuilder.CreateIndex(
                name: "IX_supplier_payment_supplier_id",
                table: "supplier_payment",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_supplier_payment_reference_supplier_payment_id",
                table: "supplier_payment_reference",
                column: "supplier_payment_id");

            migrationBuilder.CreateIndex(
                name: "IX_territory_parent_id",
                table: "territory",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_journal_chart_of_acc_id",
                table: "transaction_journal",
                column: "chart_of_acc_id");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_journal_journal_entry_id",
                table: "transaction_journal",
                column: "journal_entry_id");

            migrationBuilder.CreateIndex(
                name: "uk_cbtgke7cl0j68qi8ufskdk013",
                table: "transaction_journal",
                column: "gl_code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_role_role_id",
                table: "user_role",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_role_user_id",
                table: "user_role",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_users_branch_id",
                table: "users",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_village_commune_id",
                table: "village",
                column: "commune_id");

            migrationBuilder.CreateIndex(
                name: "IX_warehouse_account_id",
                table: "warehouse",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_warehouse_parent_id",
                table: "warehouse",
                column: "parent_id");

            migrationBuilder.AddForeignKey(
                name: "fkyx9qhair86pc6tnbh322xjg4",
                table: "account",
                column: "company_id",
                principalTable: "company",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fkefu76h3fpowk5ng2bdsdjh9hc",
                table: "address",
                column: "shipping_address_id",
                principalTable: "sale_order",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fkoithnn5ny5u7dvmxjpi3n2h25",
                table: "address",
                column: "billing_address_id",
                principalTable: "sale_order",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk89mv8mrynbjxoc6khjkbfibeb",
                table: "credit_note",
                column: "invoice_id",
                principalTable: "invoice",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk3gy7lieq388f2f6tx7awlmima",
                table: "customer_pre_payment_reference",
                column: "sale_order_id",
                principalTable: "sale_order",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fka23892al36fcn71e9bcok898e",
                table: "delivery_note",
                column: "sale_order_id",
                principalTable: "sale_order",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fkt7avycfyg7220eq428hogylmw",
                table: "invoice",
                column: "sale_order_id",
                principalTable: "sale_order",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk8a34ncoptrruc4powlgob0yc5",
                table: "quotation",
                column: "sale_order_id",
                principalTable: "sale_order",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk316pn109iutn6yqoxrqp09cpc",
                table: "account");

            migrationBuilder.DropForeignKey(
                name: "fk6ukoma5ydy94w070ewmn7udfy",
                table: "company");

            migrationBuilder.DropForeignKey(
                name: "fk3fqcpx7dko5slv9s6m31cm4g1",
                table: "customer");

            migrationBuilder.DropForeignKey(
                name: "fkc06v5ro9p64ywvhc589nhaygn",
                table: "price_list");

            migrationBuilder.DropForeignKey(
                name: "fkriqr781i8uaks8kw4hipfejmu",
                table: "quotation");

            migrationBuilder.DropForeignKey(
                name: "fk6e9jxg1jpu3b8dro6diuphdn8",
                table: "sale_order");

            migrationBuilder.DropForeignKey(
                name: "fk6qc52gy2x227bjs1exltnye4i",
                table: "account");

            migrationBuilder.DropForeignKey(
                name: "fkgw84mgpacw9htdxcs2j1p7u6j",
                table: "account");

            migrationBuilder.DropForeignKey(
                name: "fkyx9qhair86pc6tnbh322xjg4",
                table: "account");

            migrationBuilder.DropForeignKey(
                name: "fk5v50ed2bjh60n1gc7ifuxmgf4",
                table: "employee");

            migrationBuilder.DropForeignKey(
                name: "fklf5ti8fw77uew5ivt1rh1dlrd",
                table: "quotation");

            migrationBuilder.DropForeignKey(
                name: "fkfe1q5gxqihxkop8uycrfuxg5j",
                table: "sale_order");

            migrationBuilder.DropForeignKey(
                name: "fk8a34ncoptrruc4powlgob0yc5",
                table: "quotation");

            migrationBuilder.DropTable(
                name: "account_bill_item");

            migrationBuilder.DropTable(
                name: "account_mapping");

            migrationBuilder.DropTable(
                name: "account_setup_payable");

            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "asset_category");

            migrationBuilder.DropTable(
                name: "barcode_item");

            migrationBuilder.DropTable(
                name: "coa_balance");

            migrationBuilder.DropTable(
                name: "customer_balance");

            migrationBuilder.DropTable(
                name: "customer_payment_entry_reference");

            migrationBuilder.DropTable(
                name: "customer_pre_payment_reference");

            migrationBuilder.DropTable(
                name: "data_source_config");

            migrationBuilder.DropTable(
                name: "delivery_note_detail");

            migrationBuilder.DropTable(
                name: "document_setting");

            migrationBuilder.DropTable(
                name: "glentry");

            migrationBuilder.DropTable(
                name: "global_search");

            migrationBuilder.DropTable(
                name: "holiday");

            migrationBuilder.DropTable(
                name: "invoice_detail");

            migrationBuilder.DropTable(
                name: "item_attribute_value");

            migrationBuilder.DropTable(
                name: "item_image");

            migrationBuilder.DropTable(
                name: "item_inventory");

            migrationBuilder.DropTable(
                name: "item_price");

            migrationBuilder.DropTable(
                name: "item_tax");

            migrationBuilder.DropTable(
                name: "item_warehouse");

            migrationBuilder.DropTable(
                name: "miscellaneous");

            migrationBuilder.DropTable(
                name: "purchase_hold_invoice");

            migrationBuilder.DropTable(
                name: "purchase_invoice_purchase_invoice_detail");

            migrationBuilder.DropTable(
                name: "purchase_item");

            migrationBuilder.DropTable(
                name: "purchase_order_detail");

            migrationBuilder.DropTable(
                name: "purchase_receipt_detail");

            migrationBuilder.DropTable(
                name: "purchase_receipt_expanse");

            migrationBuilder.DropTable(
                name: "purchase_refund");

            migrationBuilder.DropTable(
                name: "purchase_return_detail");

            migrationBuilder.DropTable(
                name: "quotation_detail");

            migrationBuilder.DropTable(
                name: "refund");

            migrationBuilder.DropTable(
                name: "role_menu");

            migrationBuilder.DropTable(
                name: "role_permission");

            migrationBuilder.DropTable(
                name: "sale_order_detail");

            migrationBuilder.DropTable(
                name: "sale_return_detail");

            migrationBuilder.DropTable(
                name: "sale_tax_detail");

            migrationBuilder.DropTable(
                name: "serial_no");

            migrationBuilder.DropTable(
                name: "stock_balance");

            migrationBuilder.DropTable(
                name: "stock_ledger_entry");

            migrationBuilder.DropTable(
                name: "stock_move");

            migrationBuilder.DropTable(
                name: "supplier_payment_reference");

            migrationBuilder.DropTable(
                name: "transaction_journal");

            migrationBuilder.DropTable(
                name: "user_role");

            migrationBuilder.DropTable(
                name: "account_bill");

            migrationBuilder.DropTable(
                name: "village");

            migrationBuilder.DropTable(
                name: "address_type");

            migrationBuilder.DropTable(
                name: "city");

            migrationBuilder.DropTable(
                name: "barcode_type");

            migrationBuilder.DropTable(
                name: "customer_payment_entry");

            migrationBuilder.DropTable(
                name: "customer_pre_payment");

            migrationBuilder.DropTable(
                name: "item_items");

            migrationBuilder.DropTable(
                name: "item_attribute_detail");

            migrationBuilder.DropTable(
                name: "material_request_type");

            migrationBuilder.DropTable(
                name: "purchase_invoice_detail");

            migrationBuilder.DropTable(
                name: "expanse_category");

            migrationBuilder.DropTable(
                name: "debit_note");

            migrationBuilder.DropTable(
                name: "credit_note");

            migrationBuilder.DropTable(
                name: "menu_item");

            migrationBuilder.DropTable(
                name: "permission");

            migrationBuilder.DropTable(
                name: "sale_return");

            migrationBuilder.DropTable(
                name: "sale_tax_type");

            migrationBuilder.DropTable(
                name: "sale_tax_charge");

            migrationBuilder.DropTable(
                name: "supplier_payment");

            migrationBuilder.DropTable(
                name: "journal_entry");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "clear_bill");

            migrationBuilder.DropTable(
                name: "commune");

            migrationBuilder.DropTable(
                name: "item_attribute");

            migrationBuilder.DropTable(
                name: "purchase_invoice");

            migrationBuilder.DropTable(
                name: "item_varrant_uom");

            migrationBuilder.DropTable(
                name: "purchase_return");

            migrationBuilder.DropTable(
                name: "invoice");

            migrationBuilder.DropTable(
                name: "feature");

            migrationBuilder.DropTable(
                name: "chart_of_account");

            migrationBuilder.DropTable(
                name: "transaction_type");

            migrationBuilder.DropTable(
                name: "branch");

            migrationBuilder.DropTable(
                name: "payment_method");

            migrationBuilder.DropTable(
                name: "district");

            migrationBuilder.DropTable(
                name: "purchase_receipt");

            migrationBuilder.DropTable(
                name: "item");

            migrationBuilder.DropTable(
                name: "delivery_note");

            migrationBuilder.DropTable(
                name: "account_sub_class");

            migrationBuilder.DropTable(
                name: "province");

            migrationBuilder.DropTable(
                name: "purchase_order");

            migrationBuilder.DropTable(
                name: "uom");

            migrationBuilder.DropTable(
                name: "item_brand");

            migrationBuilder.DropTable(
                name: "item_group");

            migrationBuilder.DropTable(
                name: "valuation_method");

            migrationBuilder.DropTable(
                name: "drivers");

            migrationBuilder.DropTable(
                name: "delivery_type");

            migrationBuilder.DropTable(
                name: "account_class");

            migrationBuilder.DropTable(
                name: "supplier");

            migrationBuilder.DropTable(
                name: "contact");

            migrationBuilder.DropTable(
                name: "driver_status");

            migrationBuilder.DropTable(
                name: "balance_side");

            migrationBuilder.DropTable(
                name: "supplier_group");

            migrationBuilder.DropTable(
                name: "supplier_type");

            migrationBuilder.DropTable(
                name: "currency");

            migrationBuilder.DropTable(
                name: "balance");

            migrationBuilder.DropTable(
                name: "account_type");

            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropTable(
                name: "country");

            migrationBuilder.DropTable(
                name: "finance_book");

            migrationBuilder.DropTable(
                name: "letter_head");

            migrationBuilder.DropTable(
                name: "domain");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "customer_group");

            migrationBuilder.DropTable(
                name: "territory");

            migrationBuilder.DropTable(
                name: "sale_order");

            migrationBuilder.DropTable(
                name: "quotation");

            migrationBuilder.DropTable(
                name: "warehouse");

            migrationBuilder.DropTable(
                name: "term_condition");

            migrationBuilder.DropTable(
                name: "sale_person");

            migrationBuilder.DropTable(
                name: "price_list");

            migrationBuilder.DropTable(
                name: "account");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "health_insurance");

            migrationBuilder.DropTable(
                name: "employee_type");

            migrationBuilder.DropTable(
                name: "salutation");

            migrationBuilder.DropTable(
                name: "gender");
        }
    }
}
