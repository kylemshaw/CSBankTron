using System;
using Microsoft.EntityFrameworkCore;



namespace BankTronSQLiteData
{
    public partial class BankTronContext : DbContext
    {
        public virtual DbSet<BudgetGroup> BudgetGroups { get; set; }
        public virtual DbSet<BudgetItem> BudgetItems { get; set; }
        public virtual DbSet<Budget> Budgets { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryDescription> CategoryDescriptions { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public string DbPath { get; }

        public BankTronContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "BankTron.db");
        }

        public BankTronContext(DbContextOptions<BankTronContext> options)
            : base(options)
        {
        }       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=BankTron.db"); //Creates file                       
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Budget>().HasData(
                new Budget { ID = 1, Name = "Default", Value = 1000.00m }               
            );

            modelBuilder.Entity<BudgetGroup>().HasData(
                new BudgetGroup { ID = 1, BudgetID = 1, Name = "Fixed Costs", WeightInBudget = 0.50d },
                new BudgetGroup { ID = 2, BudgetID = 1, Name = "Investments", WeightInBudget = 0.20d },
                new BudgetGroup { ID = 3, BudgetID = 1, Name = "Savings", WeightInBudget = 0.20d },
                new BudgetGroup { ID = 4, BudgetID = 1, Name = "Guilt Free", WeightInBudget = 0.10d }
            );            

            modelBuilder.Entity<Category>().HasData(
               new Category { ID = 1, Name = "Rent"},
               new Category { ID = 2, Name = "Bills"},
               new Category { ID = 3, Name = "Vehicle" },
               new Category { ID = 4, Name = "Public Transport" },
               new Category { ID = 5, Name = "Health" },
               new Category { ID = 6, Name =  "RRSP" },
               new Category { ID = 7, Name =  "TSFA"},
               new Category { ID = 8, Name =  "Travel"},
               new Category { ID = 9, Name =  "Morgage Downpayment"},
               new Category { ID = 10, Name =  "New Car"},
               new Category { ID = 11, Name =  "Climbing Gym" },
               new Category { ID = 12, Name =  "Volleyball" },
               new Category { ID = 13, Name =  "Social" },
               new Category { ID = 14, Name =  "Splurge" }

           );

            //modelBuilder.Entity<BudgetItem>().HasData(
            //    new BudgetItem { },
            //    new BudgetItem { },
            //    new BudgetItem { },
            //    new BudgetItem { }
            //);

           

        }
       
    }
}
