using BankTronSQLiteData;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTronBusinessLogic
{
    public static class TransactionManager
    {
        public static void Add(Transaction transaction)
        {
            using (BankTronContext db = new BankTronContext())
            {
                db.Add(transaction);
                db.SaveChanges();
            }
        }
    }
}
