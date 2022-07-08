using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Models;
using MyLibrary.Data_Access;
namespace MyLibrary.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public List<OrderDetail> GetListOrderDetailByID(int orderID) => OrderDetailDAO.Instance.GetListOrderDetailByID(orderID);

        public bool CreateOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.CreateOrderDetail(orderDetail);
    }
}
