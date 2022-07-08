using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Models;
using MyLibrary.Data_Access;
namespace MyLibrary.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetListOrder() => OrderDAO.Instance.GetListOrder();

        public Order GetOrderByID(int id) => OrderDAO.Instance.GetOrderByID(id);

        public int IncreaseID() => OrderDAO.Instance.IncreaseID();
        public List<Order> GetListOrderByMemberID(int memberID) => OrderDAO.Instance.GetListOrderByMemberID(memberID);
    }
}
