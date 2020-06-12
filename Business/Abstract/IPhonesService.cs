using System.Collections.Generic;
using Model.Entities;

namespace Business.Abstract
{
    public interface IPhonesService
    {
        List<Phones> GetAll();
        Phones GetByPhoneNumber(string phoneNumber);
        void Add(Phones entity);
        void Update(Phones entity);
        void Delete(Phones entity);
    }
}