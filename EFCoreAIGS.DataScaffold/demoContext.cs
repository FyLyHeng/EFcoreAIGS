using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCoreAIGS.DataScaffold
{
    public partial class demoContext : DbContext
    {
        public demoContext()
        {
        }

        public demoContext(DbContextOptions<demoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<DocumentSetting> DocumentSettings { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<StockTransaction> StockTransactions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=P@ssw0rd;Database=demo");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Sex)
                    .HasMaxLength(255)
                    .HasColumnName("sex");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<DocumentSetting>(entity =>
            {
                entity.ToTable("document_setting");

                entity.HasIndex(e => e.Name, "idx8vql0es88p6virsa77nqnot1y");

                entity.HasIndex(e => e.NonVatPrefix, "uk_34ksnj6rogabks5ux36aexjfv")
                    .IsUnique();

                entity.HasIndex(e => e.Prefix, "uk_59vl05p8a1g8vknuiv7jobj8c")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "uk_8vql0es88p6virsa77nqnot1y")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.IsDifferentPrefix).HasColumnName("is_different_prefix");

                entity.Property(e => e.IsDifferentSequence).HasColumnName("is_different_sequence");

                entity.Property(e => e.LastCode).HasColumnName("last_code");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.NonVatLastCode).HasColumnName("non_vat_last_code");

                entity.Property(e => e.NonVatPrefix)
                    .HasMaxLength(255)
                    .HasColumnName("non_vat_prefix");

                entity.Property(e => e.NonVatSuffix)
                    .HasMaxLength(255)
                    .HasColumnName("non_vat_suffix");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(255)
                    .HasColumnName("prefix");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(255)
                    .HasColumnName("suffix");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("invoice");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(255)
                    .HasColumnName("customer_name");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.GrandTotal).HasColumnName("grand_total");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_no");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SubTotal).HasColumnName("sub_total");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.VatAmount).HasColumnName("vat_amount");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.ToTable("invoice_detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("fkit1rbx4thcr6gx6bm3gxub3y4");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk4kdkykjwo7h7hj6qgs8cxtf3b");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("fkestu504m7lfire9mbipgytbwo");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("fk2n9w8d0dp4bsfra9dcg0046l4");
            });

            modelBuilder.Entity<StockTransaction>(entity =>
            {
                entity.ToTable("stock_transaction");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(255)
                    .HasColumnName("reference_no");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.StockTransactions)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fkca52yvi8ps6se74qk8f93wxse");
            });

            modelBuilder.HasSequence("account_seq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
