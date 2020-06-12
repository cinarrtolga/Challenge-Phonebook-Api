using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Model.Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class UsersDal : EfRepositoryBase<Users, DatabaseContext>, IUsersDal {

    }
}