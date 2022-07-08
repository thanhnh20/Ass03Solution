using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Data_Access;
using MyLibrary.Models;

namespace MyLibrary.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public List<Member> GetListMember() => MemberDAO.Instance.GetListMember();
        public Member GetMemberByID(int memberID) => MemberDAO.Instance.GetMemberByID(memberID);
        public bool checkEmailDuplicated(string email) => MemberDAO.Instance.checkEmailDuplicated(email);
        public Member GetMemberByEmail(string email) => MemberDAO.Instance.GetMemberByEmail(email);
        public void CreateMember(Member memberCreate) => MemberDAO.Instance.CreateMember(memberCreate);
        public void UpdateMember(Member memberUpdate) => MemberDAO.Instance.UpdateMember(memberUpdate);
        public Member GetMemberByAccount(string email, string password) => MemberDAO.Instance.GetMemberByAccount(email, password);
        public void DeleteMember(int memberID) => MemberDAO.Instance.DeleteMember(memberID);

        public int IncreaseID() => MemberDAO.Instance.IncreaseID();
    }
}
