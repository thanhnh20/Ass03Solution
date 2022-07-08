using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Models;

namespace MyLibrary.Data_Access
{
    public class MemberDAO
    {
        FStoreDBContext db = new FStoreDBContext();

        private static MemberDAO instance = null;
        private static readonly object instancelock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Member> GetListMember() => db.Members.ToList();

        public Member GetMemberByID(int memberID) => db.Members.Where(m => m.MemberId == memberID).FirstOrDefault();

        public Member GetMemberByAccount(string email, string password) => db.Members.Where(m => m.Email.Equals(email) && m.Password.Equals(password)).FirstOrDefault();
        
        public Member GetMemberByEmail(string email) => db.Members.Where(m => m.Email.Equals(email)).FirstOrDefault();
        public bool checkEmailDuplicated(string email)
        {
            var member = db.Members.Where(m => m.Email.Equals(email)).FirstOrDefault();
            if(member != null)
            {
                return true;
            }
            return false;
        }
        public void CreateMember(Member memberCreate)
        {
            var Membercheck = db.Members.Where(m => m.MemberId == memberCreate.MemberId).FirstOrDefault();
            if (Membercheck == null)
            {
                db.Add(memberCreate);
                db.SaveChanges();
            }
            else
            {
                throw new Exception("The Member ID is duplicated");
            }
        }

        public void UpdateMember(Member memberUpdate)
        {
            var Membercheck = db.Members.Where(m => m.MemberId == memberUpdate.MemberId).FirstOrDefault();
            if (Membercheck != null)
            {
                Membercheck.CompanyName = memberUpdate.CompanyName;
                Membercheck.City = memberUpdate.City;
                Membercheck.Country = memberUpdate.Country;
                Membercheck.Password = memberUpdate.Password;
                db.Update(Membercheck);
                db.SaveChanges();
            }
            else
            {
                throw new Exception("This Member does not already exist");
            }
        }
        public void DeleteMember(int memberID)
        {
            var Membercheck = db.Members.Where(m => m.MemberId == memberID).FirstOrDefault();
            if (Membercheck != null)
            {
                db.Members.Remove(Membercheck);
                db.SaveChanges();
            }
            else
            {
                throw new Exception("This member does not already exist");
            }
        }
        public int IncreaseID()
        {
            int lastID = db.Members.Max(m => m.MemberId);
            return lastID + 1;
        }
    }
}
