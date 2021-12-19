using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BankTronData.Models
{
    public partial class BudgetItems
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("BudgetGroupID")]
        public int? BudgetGroupId { get; set; }
        [Column("CategoryID")]
        public int? CategoryId { get; set; }
        [Column(TypeName = "money")]
        public decimal? ItemGoalAmount { get; set; }

        [ForeignKey(nameof(BudgetGroupId))]
        [InverseProperty(nameof(BudgetGroups.BudgetItems))]
        public virtual BudgetGroups BudgetGroup { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Categories.BudgetItems))]
        public virtual Categories Category { get; set; }
    }
}
