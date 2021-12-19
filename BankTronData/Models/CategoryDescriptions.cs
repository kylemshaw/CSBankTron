using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BankTronData.Models
{
    public partial class CategoryDescriptions
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("CategoryID")]
        public int? CategoryId { get; set; }
        [StringLength(100)]
        public string Description { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Categories.CategoryDescriptions))]
        public virtual Categories Category { get; set; }
    }
}
