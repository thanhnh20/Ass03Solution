using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Models;
using MyLibrary.Repository;
namespace MyLibrary.Data_Access
{
    public class OrderDetailDAO
    {
        FStoreDBContext db = new FStoreDBContext();
        private static OrderDetailDAO instance = null;
        private static readonly object instancelock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public List<OrderDetail> GetListOrderDetailByID(int orderID)
        {
            var listOrderDetail = db.OrderDetails.Where(o => o.OrderId == orderID).ToList();
            IOrderRepository orderRepository = new OrderRepository();
            IProductRepository productRepository = new ProductRepository();
            foreach (var o in listOrderDetail)
            {
                o.Order = orderRepository.GetOrderByID(o.OrderId);
                o.Product = productRepository.GetProductById(o.ProductId);
            }
            return listOrderDetail;
        }

        public bool CreateOrderDetail(OrderDetail orderDetail)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.Orders.Add(orderDetail.Order);
                    db.SaveChanges();

                    db.OrderDetails.Add(orderDetail);
                    db.SaveChanges();

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); 
                }
            }
            return false;
        }
    }
}
