using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Models;
using MyLibrary.Data_Access;
namespace MyLibrary.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<dynamic> GetListProduct() => ProductDAO.Instance.GetListProduct();
        public void CreateProduct(Product productCreate) => ProductDAO.Instance.CreateProduct(productCreate);

        public Product GetProductById(int id) => ProductDAO.Instance.GetProductById(id);

        public int IncreaseID() => ProductDAO.Instance.IncreaseID();

        public void DeleteProduct(int productID) => ProductDAO.Instance.DeleteProduct(productID);
    }
}
