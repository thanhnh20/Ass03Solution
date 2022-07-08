using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Models;
namespace MyLibrary.Data_Access
{
    public class CategoryDAO
    {
        FStoreDBContext db = new FStoreDBContext();

        private static CategoryDAO instance = null;
        private static readonly object instancelock = new object();
        private CategoryDAO() { }
        public static CategoryDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }

        public Category GetCategoryByID(int id) => db.Categories.Where(c => c.CategoryId == id).FirstOrDefault();

        public List<Category> GetListCategory() => db.Categories.ToList();
    }
}
