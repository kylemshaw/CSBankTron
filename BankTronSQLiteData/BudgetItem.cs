using System;
using System.Collections.Generic;
using System.Text;

namespace BankTronSQLiteData
{
    public class BudgetItem
    {       
        public int ID { get; set; }        
       
        public decimal GoalAmount { get; set; }

        //Foreign Key
        public int BudgetGroupID { get; set; }
        public BudgetGroup BudgetGroup { get; set; }

        //Foreign Key
        public int CategoryID { get; set; }
        public Category Category { get; set; }
     
    }
}
