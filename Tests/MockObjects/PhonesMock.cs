using System.Collections.Generic;
using System.Data;
using System;
using Model.Entities;

namespace Tests.MockObjects
{
    public static class PhonesMock
    {
        public static Phones GetSamplePhone()
        {
            return new Phones {
                PhoneId = 1,
                PhoneNumber = "+44 45856454645",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Status = true
            };
        }

        public static List<Phones> GetSamplePhoneList()
        {
            var list = new List<Phones>();

            list.Add(new Phones() {
                PhoneId = 1,
                PhoneNumber = "+44 45856454645",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Status = true
            });

            list.Add(new Phones() {
                PhoneId = 2,
                PhoneNumber = "+44 45856454645",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Status = true
            });
            
            return list;
        }
    }
}