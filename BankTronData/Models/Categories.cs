using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BankTronData.Models
{
    public partial class Categories
    {
        public Categories()
        {
            BudgetItems = new HashSet<BudgetItems>();
            CategoryDescriptions = new HashSet<CategoryDescriptions>();
            Transactions = new HashSet<Transactions>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [InverseProperty("Category")]
        public virtual ICollection<BudgetItems> BudgetItems { get; set; }
        [InverseProperty("Category")]
        public virtual ICollection<CategoryDescriptions> CategoryDescriptions { get; set; }
        [InverseProperty("Category")]
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
