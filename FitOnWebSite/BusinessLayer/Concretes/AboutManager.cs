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
    public class AboutManager(IAboutDal aboutDal) : IAboutService
    {
        private readonly IAboutDal _aboutDal = aboutDal; // Primary Constructor

        public void Delete(About about)
        {
            _aboutDal.Delete(about);
        }

        public About GetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> GetListAll()
        {
            return _aboutDal.GetListAll();
        }

        public void Insert(About about)
        {
            _aboutDal.Insert(about);
        }

        public void Update(About about)
        {
            _aboutDal.Update(about);
        }
    }
}
