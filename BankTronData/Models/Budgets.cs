using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BankTronData.Models
{
    public partial class Budgets
    {
        public Budgets()
        {
            BudgetGroups = new HashSet<BudgetGroups>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "money")]
        public decimal? BudgetGoalAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal? IncomeAmount { get; set; }

        [InverseProperty("Budget")]
        public virtual ICollection<BudgetGroups> BudgetGroups { get; set; }
    }
}
