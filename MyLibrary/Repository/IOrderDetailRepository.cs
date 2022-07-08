using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Models;
namespace MyLibrary.Repository
{
    public interface IOrderDetailRepository
    {
        public List<OrderDetail> GetListOrderDetailByID(int orderID);

        public bool CreateOrderDetail(OrderDetail orderDetail);
    }
}
