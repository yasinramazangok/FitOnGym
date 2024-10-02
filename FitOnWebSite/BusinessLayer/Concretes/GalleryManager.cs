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
    public class GalleryManager(IGalleryDal galleryDal) : IGalleryService
    {
        private readonly IGalleryDal _galleryDal = galleryDal; // Primary Constructor

        public void Delete(Gallery gallery)
        {
            _galleryDal.Delete(gallery);
        }

        public Gallery GetById(int id)
        {
            return _galleryDal.GetById(id);
        }

        public List<Gallery> GetListAll()
        {
            return _galleryDal.GetListAll();
        }

        public void Insert(Gallery gallery)
        {
            _galleryDal.Insert(gallery);
        }

        public void Update(Gallery gallery)
        {
            _galleryDal.Update(gallery);
        }
    }
}
