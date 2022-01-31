using System;
using System.Collections.Generic;
using System.Text;

namespace BankTronSQLiteData
{
    public class CategoryDescription
    {
        public int ID { get; set; }        
        
        public string Description { get; set; }
        
        public int Weight { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
