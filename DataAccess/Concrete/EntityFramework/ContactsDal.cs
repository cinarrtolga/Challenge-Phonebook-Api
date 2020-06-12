using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Model.Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class ContactsDal : EfRepositoryBase<Contacts, DatabaseContext>, IContactsDal {

    }
}