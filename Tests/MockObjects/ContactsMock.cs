using System;
using System.Collections.Generic;
using Model.Entities;

namespace Tests.MockObjects
{
    public static class ContactsMock
    {
        public static Contacts GetSampleContact()
        {
            return new Contacts
            {
                ContactId = 1,
                FirstName = "Example Name",
                MiddleName = "Example Middle Name",
                LastName = "Example Last Name",
                Organization = "Freelancer",
                Title = "Software Developer",
                MobilePhone = "+44 1254889545",
                HomePhone = "+44 8588784564",
                Notes = "Example Notes",
                HomeAddress = "London/UK",
                NickName = "Tolgacinars",
                WebSite = "cinarr.com",
                Status = true,
            };
        }

        public static List<Contacts> GetSampleContactList()
        {
            var list = new List<Contacts>();

            list.Add(new Contacts()
            {
                ContactId = 1,
                FirstName = "Example Name",
                MiddleName = "Example Middle Name",
                LastName = "Example Last Name",
                Organization = "Freelancer",
                Title = "Software Developer",
                MobilePhone = "+44 1254889545",
                HomePhone = "+44 8588784564",
                Notes = "Example Notes",
                HomeAddress = "London/UK",
                NickName = "Tolgacinars",
                WebSite = "cinarr.com",
                Status = true,
            });

            list.Add(new Contacts()
            {
                ContactId = 2,
                FirstName = "Example Name",
                MiddleName = "Example Middle Name",
                LastName = "Example Last Name",
                Organization = "Freelancer",
                Title = "Software Developer",
                MobilePhone = "+44 1254889545",
                HomePhone = "+44 8588784564",
                Notes = "Example Notes",
                HomeAddress = "London/UK",
                NickName = "Tolgacinars",
                WebSite = "cinarr.com",
                Status = true,
            });

            return list;
        }
    }
}