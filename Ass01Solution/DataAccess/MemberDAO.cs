
using BusinessObject.MemberObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class MemberDAO
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

        public List<MemberObject> GetMemberObjects => MemberList;

        public MemberObject GetMemberByID(int memberID) 
        {
            MemberObject member = MemberList.SingleOrDefault(pro => pro.MemberID == memberID); 
            return member;
        }

        // ADD new member
        public void AddNew(MemberObject member)
        {
            MemberObject pro = GetMemberByID(member.MemberID);
            if (pro == null)
            {
                MemberList.Add(member);
            }
            else
            {
                throw new Exception("Menber ID is already exists");
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
                throw new Exception("Member does not already exists.");
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
    }
}
