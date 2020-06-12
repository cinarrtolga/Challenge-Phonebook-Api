using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Model.Entities;

namespace Business.Concrete
{
    public class ContactsManager : IContactsService
    {
        private readonly IContactsDal _contactsDal;

        public ContactsManager(IContactsDal contactsDal)
        {
            _contactsDal = contactsDal;
        }

        public void Add(Contacts entity)
        {
            _contactsDal.Add(entity);
        }

        public void Delete(Contacts entity)
        {
            _contactsDal.Delete(entity);
        }

        public List<Contacts> GetAll()
        {
            return _contactsDal.GetList(x => x.Status);
        }

        public Contacts GetById(int? contactId)
        {
            return _contactsDal.Get(x => x.ContactId == contactId && x.Status);
        }

        public List<Contacts> GetListByPhoneId(int? phoneId)
        {
            return _contactsDal.GetList(x => x.PhoneId == phoneId && x.Status);
        }

        public void Update(Contacts entity)
        {
            _contactsDal.Update(entity);
        }
    }
}