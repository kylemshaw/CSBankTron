using BankTronSQLiteData;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;

namespace BankTronBusinessLogic
{
    public static class CategoryManager
    {

        public static List<Category> GetAll()
        {
            using (BankTronContext db = new BankTronContext())
            {
                List<Category> categories =  db.Categories.OrderBy(c => c.Name).ToList();
                return categories;
            }
        }

        public static List<string> GetAllTest()
        {           
            List<string> categories = new List<string>{ "Rent", "Utilities", "Bills", "Transport" };
            return categories;
        }
    }
}
