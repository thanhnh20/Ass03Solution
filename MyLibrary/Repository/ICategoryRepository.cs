using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Models;
namespace MyLibrary.Repository
{
    public interface ICategoryRepository
    {
        public Category GetCategoryByID(int id);

        public List<Category> GetListCategory();
    }
}
