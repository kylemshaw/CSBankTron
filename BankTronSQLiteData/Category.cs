using System;
using System.Collections.Generic;
using System.Text;

namespace BankTronSQLiteData
{
    public class Category
    {      
        public int ID { get; set; }
       
        public string Name { get; set; }
                    
        public ICollection<CategoryDescription> CategoryDescriptions { get; set; }
       
        public ICollection<Transaction> Transactions { get; set; }

        public ICollection<BudgetItem> BudgetItems { get; set; }
    }
}
