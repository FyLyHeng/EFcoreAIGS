﻿// <auto-generated />
using System;
using EFCore.AIGS.UUID;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EFCore.AIGS.UUID.Migrations
{
    [DbContext(typeof(UuidContext))]
    [Migration("20220612103432_init1")]
    partial class init1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.4.22229.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "uuid-ossp");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EFCore.AIGS.UUID.Entity.Item", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<Guid?>("ItemGroupId")
                        .HasColumnType("uuid")
                        .HasColumnName("item_group_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("Item TEST")
                        .HasColumnName("name");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("status");

                    b.HasKey("Id")
                        .HasName("pk_item");

                    b.HasIndex("ItemGroupId")
                        .HasDatabaseName("ix_item_item_group_id");

                    b.ToTable("item", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("d37960c4-b81f-4bdb-9162-4a2620842569"),
                            ItemGroupId = new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"),
                            Name = "Milk tea",
                            Status = false
                        },
                        new
                        {
                            Id = new Guid("02a921d2-2187-4878-ac8a-4215a80260f7"),
                            ItemGroupId = new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"),
                            Name = "Ice Coffee",
                            Status = false
                        });
                });

            modelBuilder.Entity("EFCore.AIGS.UUID.Entity.ItemGroup", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("TEST UUID")
                        .HasColumnName("name");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("status");

                    b.HasKey("Id")
                        .HasName("pk_item_group");

                    b.ToTable("item_group", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"),
                            Name = "Drink",
                            Status = false
                        },
                        new
                        {
                            Id = new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d2"),
                            Name = "TEST-1",
                            Status = false
                        });
                });

            modelBuilder.Entity("EFCore.AIGS.UUID.Entity.Item", b =>
                {
                    b.HasOne("EFCore.AIGS.UUID.Entity.ItemGroup", "ItemGroup")
                        .WithMany("Items")
                        .HasForeignKey("ItemGroupId")
                        .HasConstraintName("fk_item_item_group_item_group_id");

                    b.Navigation("ItemGroup");
                });

            modelBuilder.Entity("EFCore.AIGS.UUID.Entity.ItemGroup", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}