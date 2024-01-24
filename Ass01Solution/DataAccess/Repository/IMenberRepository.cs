﻿using System;
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
        public void SortMemberByID();
        public void SortMemberByName();
        public void SearchByID(string id);
    }
}
