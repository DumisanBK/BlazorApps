using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EazyMobileRegPortal.Models
{
    public partial class emailbankingContext : DbContext
    {
        public emailbankingContext(DbContextOptions<emailbankingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PortalUserActions> PortalUserActions { get; set; }
        public virtual DbSet<PortalUserSessionBridge> PortalUserSessionBridge { get; set; }
        public virtual DbSet<TbSelfRegistration> TbSelfRegistration { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PortalUserActions>(entity =>
            {
                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateConducted)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntityId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PortalUserSessionBridge>(entity =>
            {
                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateGenerated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbSelfRegistration>(entity =>
            {
                entity.HasKey(e => e.AcId);

                entity.ToTable("tbSelfRegistration");

                entity.Property(e => e.AcId)
                    .HasColumnName("acID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcAccountName)
                    .IsRequired()
                    .HasColumnName("acAccountName")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AcAccountNumber)
                    .IsRequired()
                    .HasColumnName("acAccountNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcCustomerNumber)
                    .IsRequired()
                    .HasColumnName("acCustomerNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcPhoneNumber)
                    .IsRequired()
                    .HasColumnName("acPhoneNumber")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AcRegistrationDate)
                    .IsRequired()
                    .HasColumnName("acRegistrationDate")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AcStatus)
                    .IsRequired()
                    .HasColumnName("acStatus")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CheckedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CheckedDate).HasColumnType("datetime");

                entity.Property(e => e.DeniedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeniedDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
