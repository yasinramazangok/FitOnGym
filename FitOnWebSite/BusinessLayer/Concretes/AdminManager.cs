using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
    public class AdminManager(IAdminDal adminDal) : IAdminService
    {
        private readonly IAdminDal _adminDal = adminDal; // Primary Constructor

        public void Delete(Admin admin)
        {
            _adminDal.Delete(admin);
        }

        public Admin GetById(int id)
        {
            return _adminDal.GetById(id);
        }

        public List<Admin> GetListAll()
        {
            return _adminDal.GetListAll();
        }

        public void Insert(Admin admin)
        {
            _adminDal.Insert(admin);
        }

        public void Update(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }
}
