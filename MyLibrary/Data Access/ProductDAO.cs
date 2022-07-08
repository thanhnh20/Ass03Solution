using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Models;
using MyLibrary.Repository;
namespace MyLibrary.Data_Access
{
    public class ProductDAO
    {
        FStoreDBContext db = new FStoreDBContext();
        private static ProductDAO instance = null;
        private static readonly object instancelock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<dynamic> GetListProduct()
        {
            var listProduct = db.Products.ToList();
            ICategoryRepository categoryRepository = new CategoryRepository();
            foreach (var product in listProduct)
            {
                var category = categoryRepository.GetCategoryByID((int)product.CategoryId);
                product.Category = category;
            }
            return listProduct;
        }
        public Product GetProductById(int productID) => db.Products.Where(p => p.ProductId == productID).FirstOrDefault();
        public int IncreaseID()
        {
            int lastID = db.Products.Max(m => m.ProductId);
            return lastID + 1;
        }

        public void CreateProduct(Product productCreate)
        {
            var productFound = db.Products.Where(p => p.ProductId == productCreate.ProductId).FirstOrDefault();
            if (productFound == null)
            {
                db.Products.Add(productCreate);
                db.SaveChanges();
            }
            else
            {
                throw new Exception("The Product is already");
            }
        }

        public void DeleteProduct(int productDelete)
        {
            var productFound = GetProductById(productDelete);
            if (productFound != null)
            {
                db.Products.Remove(productFound);
                db.SaveChanges();
            }
            else
            {
                throw new Exception("The Product does not already");
            }
        }
    }
}
