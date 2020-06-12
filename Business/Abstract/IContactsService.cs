using System.Collections.Generic;
using Model.Entities;

namespace Business.Abstract
{
    public interface IContactsService
    {
        List<Contacts> GetAll();
        Contacts GetById(int? contactId);
        List<Contacts> GetListByPhoneId(int? phoneId);
        void Add(Contacts entity);
        void Update(Contacts entity);
        void Delete(Contacts entity);
    }
}