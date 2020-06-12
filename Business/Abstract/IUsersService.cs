using System.Collections.Generic;
using Model.Entities;

namespace Business.Abstract
{
    public interface IUsersService
    {
        bool CheckUser(string username, string password);
        void Add(Users entity);
        void Delete(Users entity);
    }
}