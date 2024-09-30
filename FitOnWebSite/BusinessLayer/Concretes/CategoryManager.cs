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
    public class CategoryManager(ICategoryDal categoryDal) : ICategoryDal
    {
        private readonly ICategoryDal _categoryDal = categoryDal; // Primary Constructor

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetListAll()
        {
            return _categoryDal.GetListAll();
        }

        public void Insert(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
