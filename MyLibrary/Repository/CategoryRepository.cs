using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Models;
using MyLibrary.Data_Access;
namespace MyLibrary.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public Category GetCategoryByID(int id) => CategoryDAO.Instance.GetCategoryByID(id);
        public List<Category> GetListCategory() => CategoryDAO.Instance.GetListCategory();
    }
}
