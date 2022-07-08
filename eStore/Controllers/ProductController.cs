using Microsoft.AspNetCore.Mvc;
using MyLibrary.Repository;
using MyLibrary.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace eStore.Controllers

{
    public class ProductController : Controller
    {
        IProductRepository productRepositoty = new ProductRepository();
        ICategoryRepository categoryRepositoty = new CategoryRepository();
        public IActionResult Index()
        {
            var listProduct = productRepositoty.GetListProduct();
            return View(listProduct);
        }

        public IActionResult Create()
        {
            var listCategory = categoryRepositoty.GetListCategory();
            var productID = productRepositoty.IncreaseID();
            ViewBag.ProductID = productID;
            ViewBag.CategoryId = new SelectList(listCategory, "CategoryId", "CategoryName", null);
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            try
            {
                Product p = new Product()
                {
                    ProductId = 6,
                    ProductName = "a",
                    CategoryId = 1,
                    Weight = "1a",
                    UnitPrice = 1,
                    UnitsInStock = 1,                   
                };
                //System.Diagnostics.Debug.WriteLine("ID " + product.ProductId + "CateID " + product.CategoryId + "Name: " + product.ProductName);
                productRepositoty.CreateProduct(p);             
                return RedirectToAction(nameof(Index));
            }catch(Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return RedirectToAction(nameof(Create));
            }
            
        }

        public IActionResult Delete(int? productID)
        {
            if (productID == null)
            {
                return NotFound();
            }
            var member = productRepositoty.GetProductById(productID.Value);
            return View(member);
        }

        [HttpPost]
        public IActionResult Delete(int productID)
        {
            try
            {
                productRepositoty.DeleteProduct(productID);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }
    }
}
