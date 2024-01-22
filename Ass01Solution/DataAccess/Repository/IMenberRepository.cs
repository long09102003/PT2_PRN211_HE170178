using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.MemberObject;

namespace DataAccess.Repository
{
    public interface IMenberRepository
    {
        IEnumerable<MemberObject> GetMembers();
        MemberObject GetMember(int id);
        void InsertMember(MemberObject member);
        void UpdateMember(MemberObject member);
        void DeleteMember(int id);
    }
}
