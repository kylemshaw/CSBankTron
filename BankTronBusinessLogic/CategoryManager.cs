using BankTronSQLiteData;
using System.Collections.Generic;
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

        public static void Add(Category c)
        {
            using (BankTronContext db = new BankTronContext())
            {
                db.Categories.Add(c);
                db.SaveChanges();
            }
        }

        public static Category FindByName(string name)
        {
            using (BankTronContext db = new BankTronContext())
            {
                Category category = db.Categories.FirstOrDefault<Category>(c => c.Name.ToLower().Equals(name.ToLower()));
                return category;
            }
        }


    }
}
