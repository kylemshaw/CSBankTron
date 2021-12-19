using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BankTronData.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BudgetGroups> BudgetGroups { get; set; }
        public virtual DbSet<BudgetItems> BudgetItems { get; set; }
        public virtual DbSet<Budgets> Budgets { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<CategoryDescriptions> CategoryDescriptions { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BankTron"].ConnectionString).UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BudgetGroups>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.Budget)
                    .WithMany(p => p.BudgetGroups)
                    .HasForeignKey(d => d.BudgetId)
                    .HasConstraintName("BudgetGroup_Budget_FK");
            });

            modelBuilder.Entity<BudgetItems>(entity =>
            {
                entity.HasOne(d => d.BudgetGroup)
                    .WithMany(p => p.BudgetItems)
                    .HasForeignKey(d => d.BudgetGroupId)
                    .HasConstraintName("BudgetItem_BudgetGroup_FK");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.BudgetItems)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("BudgetItem_Category_FK");
            });

            modelBuilder.Entity<Budgets>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<CategoryDescriptions>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryDescriptions)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("CatDesc_Category_FK");
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.Property(e => e.AccountNumber).IsUnicode(false);

                entity.Property(e => e.AccountType).IsUnicode(false);

                entity.Property(e => e.Bank).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Tags).IsUnicode(false);

                entity.HasOne(d => d.BudgetGroup)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.BudgetGroupId)
                    .HasConstraintName("Trans_BudgetGroup_FK");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("Trans_Category_FK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
