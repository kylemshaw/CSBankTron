using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BankTronData.Models
{
    public partial class BudgetGroups
    {
        public BudgetGroups()
        {
            BudgetItems = new HashSet<BudgetItems>();
            Transactions = new HashSet<Transactions>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("BudgetID")]
        public int? BudgetId { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        [Column(TypeName = "money")]
        public decimal? GroupGoalAmount { get; set; }

        [ForeignKey(nameof(BudgetId))]
        [InverseProperty(nameof(Budgets.BudgetGroups))]
        public virtual Budgets Budget { get; set; }
        [InverseProperty("BudgetGroup")]
        public virtual ICollection<BudgetItems> BudgetItems { get; set; }
        [InverseProperty("BudgetGroup")]
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
