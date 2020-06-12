using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Model.Entities;

namespace Business.Concrete
{
    public class UsersManager : IUsersService
    {
        private readonly IUsersDal _usersDal;
        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }

        public void Add(Users entity)
        {
            _usersDal.Add(entity);
        }

        public bool CheckUser(string username, string password)
        {
            return _usersDal.Get(x => x.Username == username && x.Password == password && x.Status) == null ? false : true;
        }

        public void Delete(Users entity)
        {
            _usersDal.Delete(entity);
        }
    }
}