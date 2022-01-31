using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankTronSQLiteData.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BudgetGroups",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    WeightInBudget = table.Column<double>(nullable: true),
                    BudgetID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetGroups", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BudgetGroups_Budgets_BudgetID",
                        column: x => x.BudgetID,
                        principalTable: "Budgets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryDescriptions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    Weight = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDescriptions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategoryDescriptions_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Bank = table.Column<string>(nullable: true),
                    AccountType = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Tags = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transactions_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BudgetItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WeightInGroup = table.Column<double>(nullable: true),
                    BudgetGroupID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BudgetItems_BudgetGroups_BudgetGroupID",
                        column: x => x.BudgetGroupID,
                        principalTable: "BudgetGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BudgetItems_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "ID", "Name", "Value" },
                values: new object[] { 1, "Default", 1000.00m });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Rent" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2, "Bills" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[] { 3, "Vehicle" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[] { 4, "Public Transport" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[] { 5, "Health" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[] { 6, "RRSP" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[] { 7, "TSFA" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[] { 8, "Travel" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[] { 9, "Morgage Downpayment" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[] { 10, "New Car" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[] { 11, "Climbing Gym" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[] { 12, "Volleyball" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[] { 13, "Social" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[] { 14, "Splurge" });

            migrationBuilder.InsertData(
                table: "BudgetGroups",
                columns: new[] { "ID", "BudgetID", "Name", "WeightInBudget" },
                values: new object[] { 1, 1, "Fixed Costs", 0.5 });

            migrationBuilder.InsertData(
                table: "BudgetGroups",
                columns: new[] { "ID", "BudgetID", "Name", "WeightInBudget" },
                values: new object[] { 2, 1, "Investments", 0.20000000000000001 });

            migrationBuilder.InsertData(
                table: "BudgetGroups",
                columns: new[] { "ID", "BudgetID", "Name", "WeightInBudget" },
                values: new object[] { 3, 1, "Savings", 0.20000000000000001 });

            migrationBuilder.InsertData(
                table: "BudgetGroups",
                columns: new[] { "ID", "BudgetID", "Name", "WeightInBudget" },
                values: new object[] { 4, 1, "Guilt Free", 0.10000000000000001 });

            migrationBuilder.CreateIndex(
                name: "IX_BudgetGroups_BudgetID",
                table: "BudgetGroups",
                column: "BudgetID");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetItems_BudgetGroupID",
                table: "BudgetItems",
                column: "BudgetGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetItems_CategoryID",
                table: "BudgetItems",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDescriptions_CategoryID",
                table: "CategoryDescriptions",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CategoryID",
                table: "Transactions",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BudgetItems");

            migrationBuilder.DropTable(
                name: "CategoryDescriptions");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "BudgetGroups");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Budgets");
        }
    }
}
