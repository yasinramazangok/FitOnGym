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
    public class ServiceManager(IServiceDal serviceDal) : IServiceDal
    {
        private readonly IServiceDal _serviceDal = serviceDal; // Primary Constructor

        public void Delete(Service service)
        {
            _serviceDal.Delete(service);
        }

        public Service GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> GetListAll()
        {
            return _serviceDal.GetListAll();
        }

        public void Insert(Service service)
        {
            _serviceDal.Insert(service);
        }

        public void Update(Service service)
        {
            _serviceDal.Update(service);
        }
    }
}
