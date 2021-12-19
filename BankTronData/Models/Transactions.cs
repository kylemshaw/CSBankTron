using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BankTronData.Models
{
    public partial class Transactions
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("BudgetGroupID")]
        public int? BudgetGroupId { get; set; }
        [Column("CategoryID")]
        public int? CategoryId { get; set; }
        [StringLength(20)]
        public string Bank { get; set; }
        [StringLength(20)]
        public string AccountType { get; set; }
        [StringLength(20)]
        public string AccountNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TransactionDate { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        [StringLength(100)]
        public string Tags { get; set; }

        [ForeignKey(nameof(BudgetGroupId))]
        [InverseProperty(nameof(BudgetGroups.Transactions))]
        public virtual BudgetGroups BudgetGroup { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Categories.Transactions))]
        public virtual Categories Category { get; set; }
    }
}
