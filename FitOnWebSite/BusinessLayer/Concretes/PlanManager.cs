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
    public class PlanManager(IPlanDal planDal) : IPlanService
    {
        private readonly IPlanDal _planDal = planDal; // Primary Constructor

        public void Delete(Plan plan)
        {
            _planDal.Delete(plan);
        }

        public Plan GetById(int id)
        {
            return _planDal.GetById(id);
        }

        public List<Plan> GetListAll()
        {
            return _planDal.GetListAll();
        }

        public void Insert(Plan plan)
        {
            _planDal.Insert(plan);
        }

        public void Update(Plan plan)
        {
            _planDal.Update(plan);
        }
    }
}
