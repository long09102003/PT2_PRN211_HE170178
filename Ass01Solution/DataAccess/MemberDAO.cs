
using BusinessObject.MemberObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class MemberDAO:IComparer<MemberObject>
    {
        private static List<MemberObject> MemberList = new List<MemberObject>()
        {
            new MemberObject{MemberID = 1, MemberName = "long"
            , Email = "long@gmail.com", PassWord = "123", City = "HungYen", Country = "VN" },
            new MemberObject{MemberID = 2, MemberName = "bach"
            , Email = "bach@gmail.com", PassWord = "123", City = "ThanhHoa", Country = "VN"},
            new MemberObject{MemberID = 3, MemberName = "cuong"
            , Email = "cuong@gmail.com", PassWord = "123", City = "HaiDuong", Country = "VN" }
        };

        //Using Singleton Pattern
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock(instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                }
                return instance;
            }
        }

        public List<MemberObject> GetMemberObjectsList => MemberList;

        public MemberObject GetMemberByID(int memberID) 
        {
            MemberObject member = null;
            member = MemberList.SingleOrDefault(pro => pro.MemberID == memberID); 
            return member;
        }

        // ADD new member
        //public void Add(MemberObject member)
        //{
        //    MemberObject pro = GetMemberByID(member.MemberID);
        //    if (pro == null)
        //    {
        //        MemberList.Add(member);
        //    }
        //    else
        //    {
        //        throw new Exception("Menber ID is already exists (add new)");
        //    }
        //}

        public void AddNew(MemberObject member)
        {
            if (GetMemberByID(member.MemberID) == null)
            {
                MemberList.Add(member);
            }
            else
            {
                throw new Exception("Add faild: have that id in List ");
            }
        }

        // UPDATE a member

        public void Update(MemberObject member)
        {
            MemberObject mem = GetMemberByID(member.MemberID);
            if(mem != null)
            {
                var index = MemberList.IndexOf(mem);
                MemberList[index] = member;
            }
            else
            {
                throw new Exception("Member does not already exists.(update)");
            }
        }

        //Remove Member
        public void Remove(int memberID)
        {
            MemberObject p = GetMemberByID(memberID);
            if(p != null)
            {
                MemberList.Remove(p);
            }
            else
            {
                throw new Exception("Member does not already exists");
            }
        }

        public void SortByID()
        {
            MemberList.Sort(Compare);
        }

        public void SortByName()
        {
            MemberList.Sort(Compare1);
        }

        public int Compare(MemberObject x, MemberObject y)
        {
            return x.MemberID.CompareTo(y.MemberID);
        }
        public int Compare1(MemberObject x, MemberObject y)
        {
            return x.MemberName.CompareTo(y.MemberName);
        }

        public IEnumerable<MemberObject> Search(string key)
        {
            key = key.ToLower(); 
            return MemberList.Where(member =>
                member.MemberID.ToString().Contains(key) ||
                member.MemberName.ToLower().Contains(key) ||
                member.Email.ToLower().Contains(key) ||
                member.City.ToLower().Contains(key) ||
                member.Country.ToLower().Contains(key)
            );
        }
    }
}
