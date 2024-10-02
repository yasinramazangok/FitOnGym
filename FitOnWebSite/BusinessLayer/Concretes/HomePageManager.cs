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
    public class HomePageManager(IHomePageDal homePageDal) : IHomePageService
    {
        private readonly IHomePageDal _homePageDal = homePageDal; // Primary Constructor

        public void Delete(HomePage homePage)
        {
            _homePageDal.Delete(homePage);
        }

        public HomePage GetById(int id)
        {
            return _homePageDal.GetById(id);
        }

        public List<HomePage> GetListAll()
        {
            return _homePageDal.GetListAll();
        }

        public void Insert(HomePage homePage)
        {
            _homePageDal.Insert(homePage);
        }

        public void Update(HomePage homePage)
        {
            _homePageDal.Update(homePage);
        }
    }
}
