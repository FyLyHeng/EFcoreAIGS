using EFCoreAIGS.erp.Entites;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAIGS.erp
{
    public partial class erpContext : DbContext
    {
        public erpContext()
        {
        }

        public erpContext(DbContextOptions<erpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Gender> Genders { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=P@ssw0rd;Database=erp");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pg_catalog", "adminpack");

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("gender");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BaseCustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("base_custom_status");

                entity.Property(e => e.BaseSeries)
                    .HasMaxLength(255)
                    .HasColumnName("base_series");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Gender1)
                    .HasMaxLength(255)
                    .HasColumnName("gender");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BaseCustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("base_custom_status");

                entity.Property(e => e.BaseSeries)
                    .HasMaxLength(255)
                    .HasColumnName("base_series");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(255)
                    .HasColumnName("role_name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BaseCustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("base_custom_status");

                entity.Property(e => e.BaseSeries)
                    .HasMaxLength(255)
                    .HasColumnName("base_series");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(255)
                    .HasColumnName("image_path");

                entity.Property(e => e.IsAdmin).HasColumnName("is_admin");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_role");

                entity.Property(e => e.BaseCustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("base_custom_status");

                entity.Property(e => e.BaseSeries)
                    .HasMaxLength(255)
                    .HasColumnName("base_series");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Role)
                    .WithMany()
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fka68196081fvovjhkek5m97n3y");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkj345gk1bovqvfame88rcx7yyx");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
