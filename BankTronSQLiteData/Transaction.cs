using System;
using System.Collections.Generic;
using System.Text;

namespace BankTronSQLiteData
{
    public class Transaction
    {        
        public int ID { get; set; }        
        
        public string Bank { get; set; }
       
        public string AccountType { get; set; }
       
        public string AccountNumber { get; set; }
       
        public DateTime TransactionDate { get; set; }
        
        public string Description { get; set; }
       
        public decimal Amount { get; set; }
       
        public string Tags { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
