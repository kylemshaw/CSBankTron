using System;
using System.Collections.Generic;
using System.Text;

namespace BankTronSQLiteData
{
    public class BudgetGroup
    {
        public int ID { get; set; }       
       
        public string Name { get; set; }
       
        public double? WeightInBudget { get; set; }

        public int BudgetID { get; set; }
        public Budget Budget { get; set; }

        public ICollection<BudgetItem> BudgetItems { get; set; }      

    }
}
