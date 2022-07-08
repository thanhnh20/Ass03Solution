using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Models;
namespace MyLibrary.Repository
{
    public interface IMemberRepository
    {
        public List<Member> GetListMember();

        public Member GetMemberByID(int memberID);
        public Member GetMemberByAccount(string email, string password);
        public Member GetMemberByEmail(string email);
        public bool checkEmailDuplicated(string email);

        public void UpdateMember(Member memberUpdate);
        public void CreateMember(Member memberCreate);

        public void DeleteMember(int memberID);

        public int IncreaseID();
    }
}
