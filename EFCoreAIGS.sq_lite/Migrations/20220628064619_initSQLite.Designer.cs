﻿// <auto-generated />
using System;
using EFCoreAIGS.sq_lite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreAIGS.sq_lite.Migrations
{
    [DbContext(typeof(SQLiteContext))]
    [Migration("20220628064619_initSQLite")]
    partial class initSQLite
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0-preview.5.22302.2");

            modelBuilder.Entity("EFCoreAIGS.sq_lite.Entity.Item", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<Guid?>("ItemGroupId")
                        .HasColumnType("TEXT")
                        .HasColumnName("item_group_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue("Item TEST")
                        .HasColumnName("name");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
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
                            Id = new Guid("95254799-131c-43a9-88c8-39865a39e61c"),
                            ItemGroupId = new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"),
                            Name = "Milk tea",
                            Status = false
                        },
                        new
                        {
                            Id = new Guid("b2cc35e8-ed6e-4b24-a793-726844cf52d7"),
                            ItemGroupId = new Guid("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"),
                            Name = "Ice Coffee",
                            Status = false
                        });
                });

            modelBuilder.Entity("EFCoreAIGS.sq_lite.Entity.ItemGroup", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue("TEST UUID")
                        .HasColumnName("name");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
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

            modelBuilder.Entity("EFCoreAIGS.sq_lite.Entity.Item", b =>
                {
                    b.HasOne("EFCoreAIGS.sq_lite.Entity.ItemGroup", "ItemGroup")
                        .WithMany()
                        .HasForeignKey("ItemGroupId")
                        .HasConstraintName("fk_item_item_group_item_group_id");

                    b.Navigation("ItemGroup");
                });
#pragma warning restore 612, 618
        }
    }
}