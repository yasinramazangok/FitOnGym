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
    public class HomeManager(IHomeDal homeDal) : IHomeDal
    {
        private readonly IHomeDal _homeDal = homeDal; // Primary Constructor

        public void Delete(Home home)
        {
            _homeDal.Delete(home);
        }

        public Home GetById(int id)
        {
            return _homeDal.GetById(id);
        }

        public List<Home> GetListAll()
        {
            return _homeDal.GetListAll();
        }

        public void Insert(Home home)
        {
            _homeDal.Insert(home);
        }

        public void Update(Home home)
        {
            _homeDal.Update(home);
        }
    }
}
