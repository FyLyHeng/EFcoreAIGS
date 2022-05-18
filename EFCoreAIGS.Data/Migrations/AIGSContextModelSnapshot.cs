﻿// <auto-generated />
using System;
using EFCoreAIGS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EFCoreAIGS.Data.Migrations
{
    [DbContext(typeof(AIGSContext))]
    partial class AIGSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.4.22229.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("EFCoreAIGS.Data.Entities.CreditCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<double>("Balance")
                        .HasColumnType("double precision");

                    b.Property<string>("CreditCardNumber")
                        .HasColumnType("text");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<double>("TotalIncomeAmount")
                        .HasColumnType("double precision");

                    b.Property<double>("TotalOutcomeAmount")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("CreditCard");
                });

            modelBuilder.Entity("EFCoreAIGS.Data.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Hired")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EFCoreAIGS.Data.Entities.Spend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("IncomeSpendingDetailsId")
                        .HasColumnType("integer");

                    b.Property<int>("OutcomeSpendingDetailsId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IncomeSpendingDetailsId");

                    b.HasIndex("OutcomeSpendingDetailsId");

                    b.ToTable("Spend");
                });

            modelBuilder.Entity("EFCoreAIGS.Data.Entities.SpendingDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("Amount")
                        .HasColumnType("numeric");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<string>("SpentOn")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("SpendingDetails");
                });

            modelBuilder.Entity("EFCoreAIGS.Data.Entities.CreditCard", b =>
                {
                    b.HasOne("EFCoreAIGS.Data.Entities.Employee", "Employee")
                        .WithOne("CreditCard")
                        .HasForeignKey("EFCoreAIGS.Data.Entities.CreditCard", "EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EFCoreAIGS.Data.Entities.Spend", b =>
                {
                    b.HasOne("EFCoreAIGS.Data.Entities.SpendingDetails", "IncomeSpendingDetails")
                        .WithMany("IncomeSpend")
                        .HasForeignKey("IncomeSpendingDetailsId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("EFCoreAIGS.Data.Entities.SpendingDetails", "OutcomeSpendingDetails")
                        .WithMany("OutcomeSpend")
                        .HasForeignKey("OutcomeSpendingDetailsId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("IncomeSpendingDetails");

                    b.Navigation("OutcomeSpendingDetails");
                });

            modelBuilder.Entity("EFCoreAIGS.Data.Entities.SpendingDetails", b =>
                {
                    b.HasOne("EFCoreAIGS.Data.Entities.Employee", "Employee")
                        .WithMany("SpendingDetails")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EFCoreAIGS.Data.Entities.Employee", b =>
                {
                    b.Navigation("CreditCard");

                    b.Navigation("SpendingDetails");
                });

            modelBuilder.Entity("EFCoreAIGS.Data.Entities.SpendingDetails", b =>
                {
                    b.Navigation("IncomeSpend");

                    b.Navigation("OutcomeSpend");
                });
#pragma warning restore 612, 618
        }
    }
}
