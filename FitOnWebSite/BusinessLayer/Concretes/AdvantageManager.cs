using DataAccessLayer.Abstracts;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
    public class AdvantageManager(IAdvantageDal advantageDal) : IAdvantageDal
    {
        private readonly IAdvantageDal _advantageDal = advantageDal; // Primary Constructor

        public void Delete(Advantage advantage)
        {
            _advantageDal.Delete(advantage);
        }

        public Advantage GetById(int id)
        {
            return _advantageDal.GetById(id);
        }

        public List<Advantage> GetListAll()
        {
            return _advantageDal.GetListAll();
        }

        public void Insert(Advantage advantage)
        {
            _advantageDal.Insert(advantage);
        }

        public void Update(Advantage advantage)
        {
            _advantageDal.Update(advantage);
        }
    }
}
