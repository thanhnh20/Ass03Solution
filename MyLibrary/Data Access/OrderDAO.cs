using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Models;
using MyLibrary.Repository;
namespace MyLibrary.Data_Access
{
    public class OrderDAO
    {
        FStoreDBContext db = new FStoreDBContext();
        private static OrderDAO instance = null;
        private static readonly object instancelock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Order> GetListOrder()
        {
            var listOrder = db.Orders.ToList();
            IMemberRepository memberRepository = new MemberRepository();
            foreach (var o in listOrder)
            {
                o.Member = memberRepository.GetMemberByID((int)o.MemberId);
            }
            return listOrder;

        }

        public List<Order> GetListOrderByMemberID(int memberID)
        {
            var listOrder = db.Orders.Where(o => o.MemberId == memberID).ToList();
            IMemberRepository memberRepository = new MemberRepository();
            foreach (var o in listOrder)
            {
                o.Member = memberRepository.GetMemberByID((int)o.MemberId);
            }
            return listOrder;

        }

        public Order GetOrderByID(int id) => GetListOrder().Where(o => o.OrderId == id).FirstOrDefault();

        public int IncreaseID()
        {
            int lastID = db.Orders.Max(m => m.OrderId);
            return lastID + 1;
        }

    }
}
