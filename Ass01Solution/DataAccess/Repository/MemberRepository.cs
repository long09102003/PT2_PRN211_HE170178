using BusinessObject.MemberObject;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMenberRepository
    {
        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMemberObjectsList;
        public MemberObject GetMemberByID(int id) => MemberDAO.Instance.GetMemberByID(id);
        public void InsertMember(MemberObject member) => MemberDAO.Instance.AddNew(member);
        public void DeleteMember(int memberId) => MemberDAO.Instance.Remove(memberId);
        public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);
        public void SortMemberByID() => MemberDAO.Instance.SortByID();

        public void SortMemberByName() => MemberDAO.Instance.SortByName();

        public IEnumerable<MemberObject> Search(string key) => MemberDAO.Instance.Search(key);
    }
}
