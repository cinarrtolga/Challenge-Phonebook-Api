using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Model.Entities;

namespace Business.Concrete
{
    public class PhonesManager : IPhonesService
    {
        private readonly IPhonesDal _phonesDal;
        public PhonesManager(IPhonesDal phonesDal)
        {
            _phonesDal = phonesDal;
        }

        public void Add(Phones entity)
        {
            _phonesDal.Add(entity);
        }

        public void Delete(Phones entity)
        {
            _phonesDal.Delete(entity);
        }

        public List<Phones> GetAll()
        {
            return _phonesDal.GetList(x => x.Status);
        }

        public Phones GetByPhoneNumber(string phoneNumber)
        {
            return _phonesDal.Get(x => x.PhoneNumber == phoneNumber && x.Status);
        }

        public void Update(Phones entity)
        {
            _phonesDal.Update(entity);
        }
    }
}