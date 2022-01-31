using System;
using System.Collections.Generic;
using System.Text;

namespace BankTronSQLiteData
{
    public class Budget
    {       
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public decimal? Value { get; set; }       
                
        public ICollection<BudgetGroup> BudgetGroups { get; set; }

    }
}
