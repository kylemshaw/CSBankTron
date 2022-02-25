using BankTronSQLiteData;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTronBusinessLogic
{
    public class BudgetItemManager
    {
        public static void Add(BudgetItem item)
        {
            using (BankTronContext db = new BankTronContext())
            {
                db.BudgetItems.Add(item);
                db.SaveChanges();
            }
        }

    }
}
