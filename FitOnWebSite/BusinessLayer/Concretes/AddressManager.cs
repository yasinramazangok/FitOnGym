using DataAccessLayer.Abstracts;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
    public class AddressManager(IAddressDal addressDal) : IAddressDal
    {
        private readonly IAddressDal _addressDal = addressDal; // Primary Constructor

        public void Delete(Address address)
        {
            _addressDal.Delete(address);
        }

        public Address GetById(int id)
        {
            return _addressDal.GetById(id);
        }

        public List<Address> GetListAll()
        {
            return _addressDal.GetListAll();
        }

        public void Insert(Address address)
        {
            _addressDal.Insert(address);
        }

        public void Update(Address address)
        {
            _addressDal.Update(address);
        }
    }
}
