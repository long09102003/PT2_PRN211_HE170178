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

        public List<string> GetDistinctCities() => MemberDAO.Instance.GetCities();

        public List<string> GetDistinctCountry() => MemberDAO.Instance.GetCountry();
        public IEnumerable<MemberObject> GetMembersByCity(string city)
        {
            return MemberDAO.Instance.GetMemberObjectsList
                .Where(member => member.City.Equals(city, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<MemberObject> GetMembersByCountry(string country)
        {
            return MemberDAO.Instance.GetMemberObjectsList
                .Where(member => member.Country.Equals(country, StringComparison.OrdinalIgnoreCase));
        }

    }
}
