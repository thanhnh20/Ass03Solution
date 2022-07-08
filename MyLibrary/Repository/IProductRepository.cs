using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Models;
namespace MyLibrary.Repository
{
    public interface IProductRepository
    {
        public IEnumerable<dynamic> GetListProduct();
        public void CreateProduct(Product productCreate);

        public Product GetProductById(int id);

        public int IncreaseID();

        public void DeleteProduct(int productID);

    }
}
