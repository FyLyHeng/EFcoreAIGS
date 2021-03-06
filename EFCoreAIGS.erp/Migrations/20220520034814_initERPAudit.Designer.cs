// <auto-generated />
using System;
using EFCoreAIGS.erp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EFCoreAIGS.erp.Migrations
{
    [DbContext(typeof(erpContext))]
    [Migration("20220520034814_initERPAudit")]
    partial class initERPAudit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.4.22229.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "pg_catalog", "adminpack");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EFCoreAIGS.erp.Gender", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("BaseCustomStatus")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("base_custom_status");

                    b.Property<string>("BaseSeries")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("base_series");

                    b.Property<long?>("CreatedById")
                        .HasColumnType("bigint")
                        .HasColumnName("created_by_id");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_created");

                    b.Property<string>("Gender1")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("gender");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("last_updated");

                    b.Property<bool?>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasColumnName("status")
                        .HasDefaultValueSql("true");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint")
                        .HasColumnName("updated_by_id");

                    b.Property<int?>("Version")
                        .HasColumnType("integer")
                        .HasColumnName("version");

                    b.HasKey("Id");

                    b.ToTable("gender", (string)null);
                });

            modelBuilder.Entity("EFCoreAIGS.erp.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("BaseCustomStatus")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("base_custom_status");

                    b.Property<string>("BaseSeries")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("base_series");

                    b.Property<long?>("CreatedById")
                        .HasColumnType("bigint")
                        .HasColumnName("created_by_id");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("timestamp(6) without time zone")
                        .HasColumnName("date_created");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("description");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("timestamp(6) without time zone")
                        .HasColumnName("last_updated");

                    b.Property<string>("RoleName")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("role_name");

                    b.Property<bool?>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasColumnName("status")
                        .HasDefaultValueSql("true");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint")
                        .HasColumnName("updated_by_id");

                    b.Property<int?>("Version")
                        .HasColumnType("integer")
                        .HasColumnName("version");

                    b.HasKey("Id");

                    b.ToTable("role", (string)null);
                });

            modelBuilder.Entity("EFCoreAIGS.erp.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("BaseCustomStatus")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("base_custom_status");

                    b.Property<string>("BaseSeries")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("base_series");

                    b.Property<long?>("BranchId")
                        .HasColumnType("bigint")
                        .HasColumnName("branch_id");

                    b.Property<long?>("CreatedById")
                        .HasColumnType("bigint")
                        .HasColumnName("created_by_id");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_created");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("email");

                    b.Property<string>("ImagePath")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("image_path");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean")
                        .HasColumnName("is_admin");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("last_updated");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("phone");

                    b.Property<bool?>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasColumnName("status")
                        .HasDefaultValueSql("true");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint")
                        .HasColumnName("updated_by_id");

                    b.Property<string>("Username")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("username");

                    b.Property<int?>("Version")
                        .HasColumnType("integer")
                        .HasColumnName("version");

                    b.HasKey("Id");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("EFCoreAIGS.erp.UserRole", b =>
                {
                    b.Property<string>("BaseCustomStatus")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("base_custom_status");

                    b.Property<string>("BaseSeries")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("base_series");

                    b.Property<long?>("CreatedById")
                        .HasColumnType("bigint")
                        .HasColumnName("created_by_id");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("timestamp(6) without time zone")
                        .HasColumnName("date_created");

                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("timestamp(6) without time zone")
                        .HasColumnName("last_updated");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint")
                        .HasColumnName("role_id");

                    b.Property<bool?>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasColumnName("status")
                        .HasDefaultValueSql("true");

                    b.Property<long?>("UpdatedById")
                        .HasColumnType("bigint")
                        .HasColumnName("updated_by_id");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.Property<int?>("Version")
                        .HasColumnType("integer")
                        .HasColumnName("version");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("user_role", (string)null);
                });

            modelBuilder.Entity("EFCoreAIGS.erp.UserRole", b =>
                {
                    b.HasOne("EFCoreAIGS.erp.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("fka68196081fvovjhkek5m97n3y");

                    b.HasOne("EFCoreAIGS.erp.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("fkj345gk1bovqvfame88rcx7yyx");

                    b.Navigation("Role");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
