using Microsoft.AspNetCore.Mvc;
using MyLibrary.Repository;
using MyLibrary.Models;
namespace eStore.Controllers
{
    public class OrderController : Controller
    {
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public IActionResult Index()
        {
            var listOrder = orderRepository.GetListOrder();
            return View(listOrder);
        }

        public IActionResult Details(int orderId)
        {
            Order order = orderRepository.GetOrderByID(orderId);
            var listOrderDetail = orderDetailRepository.GetListOrderDetailByID(orderId);
            ViewData["order"] = order;
            return View(listOrderDetail);
        }
    }
}
