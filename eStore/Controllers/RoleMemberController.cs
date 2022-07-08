using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyLibrary.Models;
using MyLibrary.Repository;
using System.Collections.Generic;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Xml.Xsl;
using System.Linq;

namespace eStore.Controllers
{
    public class RoleMemberController : Controller
    {
        IProductRepository productRepository = new ProductRepository(); 
        IMemberRepository memberRepository = new MemberRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        IOrderRepository orderRepository = new OrderRepository();
        public IActionResult Index()
        {    
            var listProduct = productRepository.GetListProduct();
            return View(listProduct);
        }

        [HttpPost]
        public IActionResult Index(int productID)
        {
            var product = productRepository.GetProductById(productID);
            var listProduct = productRepository.GetListProduct();
            
            try
            {              
                if (product.UnitsInStock == 0)
                {
                    throw new Exception("The number of products in stock is out of stock");
                }
                //get key Cart
                var keyCart = HttpContext.Session.GetString("CART_LIST");
                //check Session
                if(keyCart == null)
                {
                    List<Product> cartList = new List<Product>();

                    Product cartProduct = new Product()
                    {
                        ProductId = productID,
                        CategoryId = product.CategoryId,
                        ProductName = product.ProductName,
                        Weight = product.Weight,
                        UnitsInStock = 1,
                        UnitPrice = product.UnitPrice,
                        Category = product.Category,
                    };
                    
                    cartList.Add(cartProduct);
                    HttpContext.Session.SetString("CART_LIST", JsonConvert.SerializeObject(cartList));
                }
                else
                {
                    List<Product> cartList = JsonConvert.DeserializeObject<List<Product>>(keyCart);
                    bool check = true;
                    foreach (var item in cartList)
                    {
                        if (item.ProductId == productID)
                        {
                            item.UnitsInStock += 1;
                            check = false;
                        }
                    }
                    if (check)
                    {
                        Product cartProduct = new Product()
                        {
                            ProductId = productID,
                            CategoryId = product.CategoryId,
                            ProductName = product.ProductName,
                            Weight = product.Weight,
                            UnitsInStock = 1,
                            UnitPrice = product.UnitPrice,
                            Category = product.Category,
                        };
                        cartList.Add(cartProduct);                        
                    }
                    HttpContext.Session.SetString("CART_LIST", JsonConvert.SerializeObject(cartList));
                }
                ViewBag.Message = "Add to cart successfully";
                return View(listProduct);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View(listProduct);
            }
        }

        public IActionResult ViewCart()
        {
            var keyCart = HttpContext.Session.GetString("CART_LIST");
            if(keyCart != null)
            {
                List<Product> cartList = JsonConvert.DeserializeObject<List<Product>>(keyCart);
                if (cartList.Count == 0)
                {
                    ViewBag.Message = "This cart does not has product";
                }
                return View(cartList);
            }
            else
            {
                ViewBag.Message = "This cart does not has product";
            }
            return View();
        }
        public IActionResult Profile(string id)
        {
            var member = memberRepository.GetMemberByEmail(id);
            return View(member);
        }

        public IActionResult Edit(int memberID)
        {
            if (memberID == null)
            {
                return NotFound();
            }
            var member = memberRepository.GetMemberByID(memberID);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        [HttpPost]
        public IActionResult Edit(Member member)
        {
            try
            {
                memberRepository.UpdateMember(member);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }

        public IActionResult Action(List<int> check)
        {

            string action = Request.Form["btnAction"];
            bool result = false;
            if (action.Equals("Check out"))
            {              
                foreach (var id in check)
                {
                    string productID = id.ToString();
                    int quantity = int.Parse(Request.Form[productID]);
                    //System.Diagnostics.Debug.WriteLine("ID: " + id + " Quantity: " + quantity);
                    var product = productRepository.GetProductById(id);
                    if (quantity > product.UnitsInStock)
                    {
                        ViewBag.Message = "Product quantity is larger than in stock";
                        return RedirectToAction(nameof(ViewCart));
                    }
                    DateTime today = DateTime.Now;
                    var oderID = orderRepository.IncreaseID();
                    var member = JsonConvert.DeserializeObject<MyLibrary.Models.Member>(HttpContext.Session.GetString("ACCOUNT"));

                    var order = new Order()
                    {
                        OrderId = oderID,
                        MemberId = member.MemberId,
                        OrderDate = today,
                        RequiredDate = today.AddDays(2),
                        ShippedDate = today.AddDays(4),
                        Freight = 10000,
                    };
                    var orderDetail = new OrderDetail()
                    {
                        OrderId = oderID,
                        ProductId = id,
                        UnitPrice = product.UnitPrice,
                        Quantity = quantity,
                        Discount = 0,
                        Order = order
                    };
                    result = orderDetailRepository.CreateOrderDetail(orderDetail);
                }
            }
                var keyCart = HttpContext.Session.GetString("CART_LIST");
                List<Product> cartList = JsonConvert.DeserializeObject<List<Product>>(keyCart);
                foreach (var id in check)
                {
                    var productFound = cartList.Where(c => c.ProductId == id).FirstOrDefault();
                    cartList.Remove(productFound);
                }
                HttpContext.Session.SetString("CART_LIST", JsonConvert.SerializeObject(cartList));
            return RedirectToAction(nameof(Index));
        }

        public IActionResult OrderHistory(int memberID)
        {
            var listOrder = orderRepository.GetListOrderByMemberID(memberID);
            return View(listOrder);
        }

        public IActionResult OrderHistoryDetail(int orderID)
        {
            Order order = orderRepository.GetOrderByID(orderID);
            var listOrderDetail = orderDetailRepository.GetListOrderDetailByID(orderID);
            ViewData["order"] = order;
            return View(listOrderDetail);
        }
    }
}
