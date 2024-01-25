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
        MemberObject GetMemberByID(int id);
        void InsertMember(MemberObject member);
        void DeleteMember(int id);
        void UpdateMember(MemberObject member);
        void SortMemberByID();
        void SortMemberByName();

        IEnumerable<MemberObject> Search(string key);

        List<string> GetDistinctCities();

        List<string> GetDistinctCountry();
        IEnumerable<MemberObject> GetMembersByCity(string city);

        IEnumerable<MemberObject> GetMembersByCountry(string country);

    }
}
