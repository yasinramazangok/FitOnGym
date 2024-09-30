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
    public class TeamManager(ITeamDal teamDal) : ITeamService
    {
        private readonly ITeamDal _teamDal = teamDal; // Primary Constructor

        public void Delete(Team team)
        {
            _teamDal.Delete(team);
        }

        public Team GetById(int id)
        {
            return _teamDal.GetById(id);
        }

        public List<Team> GetListAll()
        {
            return _teamDal.GetListAll();
        }

        public void Insert(Team team)
        {
            _teamDal.Insert(team);
        }

        public void Update(Team team)
        {
            _teamDal.Update(team);
        }
    }
}
