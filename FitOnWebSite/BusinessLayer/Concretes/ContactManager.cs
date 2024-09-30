using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
    public class ContactManager(IContactDal contactDal) : IContactService
    {
        private readonly IContactDal _contactDal = contactDal; // Primary Constructor

        public void Delete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> GetListAll()
        {
            return _contactDal.GetListAll();
        }

        public void Insert(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void Update(Contact contact)
        {
            _contactDal.Update(contact);
        }
    }
}
