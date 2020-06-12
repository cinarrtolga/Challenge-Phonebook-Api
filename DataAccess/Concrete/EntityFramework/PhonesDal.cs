using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Model.Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class PhonesDal : EfRepositoryBase<Phones, DatabaseContext>, IPhonesDal {

    }
}