using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BancassuranceLib.Models
{
    public partial class BancassuranceContext : DbContext
    {
        public BancassuranceContext(DbContextOptions<BancassuranceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountSettings> AccountSettings { get; set; }
        public virtual DbSet<Branches> Branches { get; set; }
        public virtual DbSet<DeletedEntities> DeletedEntities { get; set; }
        public virtual DbSet<Dependents> Dependents { get; set; }
        public virtual DbSet<MainMemberDetails> MainMemberDetails { get; set; }
        public virtual DbSet<PageAccess> PageAccess { get; set; }
        public virtual DbSet<PortalUserActions> PortalUserActions { get; set; }
        public virtual DbSet<PortalUserSessionBridge> PortalUserSessionBridge { get; set; }
        public virtual DbSet<Relationships> Relationships { get; set; }
        public virtual DbSet<SplitChargeEntries> SplitChargeEntries { get; set; }
        public virtual DbSet<SystemSettings> SystemSettings { get; set; }
        public virtual DbSet<Titles> Titles { get; set; }
        public virtual DbSet<TurnOverTypes> TurnOverTypes { get; set; }
        public virtual DbSet<UnsubscribeRequests> UnsubscribeRequests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountSettings>(entity =>
            {
                entity.HasIndex(e => e.AccountNumber)
                    .HasName("IX_Table_Account");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'N/A')");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Admin')");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Branches>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("branches");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("branch_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasColumnName("branch_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mnemonic)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OtherAccountOfficer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryAccountOfficer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeletedEntities>(entity =>
            {
                entity.Property(e => e.DateConducted)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntityAsJson).IsRequired();

                entity.Property(e => e.EntityType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Inputter)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Dependents>(entity =>
            {
                entity.Property(e => e.Age)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateVoided).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InputTeller)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SurName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VoidedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Dependents)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_Dependents_MainMemberDetails");
            });

            modelBuilder.Entity<MainMemberDetails>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cashier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateVoidRequested).HasColumnType("datetime");

                entity.Property(e => e.DateVoided).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportedToMasm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SurName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VoidAuthorization)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoidReason)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VoidRequestedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoidedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.TurnOver)
                    .WithMany(p => p.MainMemberDetails)
                    .HasForeignKey(d => d.TurnOverId)
                    .HasConstraintName("FK_MainMemberDetails_TurnOverTypes");
            });

            modelBuilder.Entity<PageAccess>(entity =>
            {
                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Page)
                    .IsRequired()
                    .HasMaxLength(50);
            });

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
                    .HasMaxLength(100);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100);
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

            modelBuilder.Entity<Relationships>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .IsUnique();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SplitChargeEntries>(entity =>
            {
                entity.HasKey(e => e.Line);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeAccount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeAmount).HasColumnType("money");

                entity.Property(e => e.ChargeDate).HasColumnType("datetime");

                entity.Property(e => e.ChargeDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ofsrequest)
                    .HasColumnName("OFSRequest")
                    .IsUnicode(false);

                entity.Property(e => e.Ofsresponse)
                    .HasColumnName("OFSResponse")
                    .HasColumnType("text");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.RefTransactionId)
                    .HasColumnName("RefTransactionID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId)
                    .IsRequired()
                    .HasColumnName("ServiceID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemSettings>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .IsUnique();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastDateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Titles>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .IsUnique();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TurnOverTypes>(entity =>
            {
                entity.HasKey(e => e.TurnOverId);

                entity.Property(e => e.AdditionaPremium).HasColumnType("money");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.TurnOverType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnsubscribeRequests>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("unsubscribeRequests");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MemberId).HasColumnName("memberId");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnName("reason")
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
