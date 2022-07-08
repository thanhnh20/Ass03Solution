using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Models;
namespace MyLibrary.Repository
{
    public interface IOrderRepository
    {
        public List<Order> GetListOrder();
        public Order GetOrderByID(int id);

        public int IncreaseID();
        public List<Order> GetListOrderByMemberID(int memberID);
    }
}
