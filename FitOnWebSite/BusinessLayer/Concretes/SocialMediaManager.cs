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
    public class SocialMediaManager(ISocialMediaDal socialMediaDal) : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal = socialMediaDal; // Primary Constructor

        public void Delete(SocialMedia socialMedia)
        {
            _socialMediaDal.Delete(socialMedia);
        }

        public SocialMedia GetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public List<SocialMedia> GetListAll()
        {
            return _socialMediaDal.GetListAll();
        }

        public void Insert(SocialMedia socialMedia)
        {
            _socialMediaDal.Insert(socialMedia);
        }

        public void Update(SocialMedia socialMedia)
        {
            _socialMediaDal.Update(socialMedia);
        }
    }
}
