using Microsoft.EntityFrameworkCore;
using OGSSurvey.Service.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGSSurvey.Service.Data
{
    public class Repository : IRepository
    {
        private readonly Context _context;

        public Repository(Context context)
        {
            _context = context;
        }
        public Contract GetContractByGuid(Guid guid)
        {
            var contract = _context.Contracts.Where(c => c.Guid == guid)
                        .Include(c => c.SurveyUser).ThenInclude(c => c.City)
                        .Include(c => c.SurveyUser)
                        .FirstOrDefault();
            var subUsers = _context.SubUsers.Include(s => s.City).Where(s => s.SurveyUser == contract.SurveyUser).ToList();
            contract.SurveyUser.SubUsers = subUsers;
            return contract;
        }

        public Contract GetContractById(int id)
        {
            var contract = _context.Contracts.Where(c => c.Id == id)
                                    .Include(c => c.SurveyUser).ThenInclude(c => c.City)
                                    .Include(c => c.SurveyUser)
                                    .FirstOrDefault();
            var subUsers = _context.SubUsers.Include(s => s.City).Where(s => s.SurveyUser == contract.SurveyUser).ToList();
            contract.SurveyUser.SubUsers = subUsers;
            return contract;
        }

        public Contract GetContractByTcNo(string tcno)
        {
            var user = _context.SurveyUsers.Where(su => su.TCNO.Contains(tcno)).OrderByDescending(su => su.Id).FirstOrDefault();

            var contract = _context.Contracts.Where(c => c.SurveyUser == user)
                        .Include(c => c.SurveyUser).ThenInclude(c => c.City)
                        .Include(c => c.SurveyUser)
                        .FirstOrDefault();
            var subUsers = _context.SubUsers.Include(s => s.City).Where(s => s.SurveyUser == contract.SurveyUser).ToList();
            contract.SurveyUser.SubUsers = subUsers;
            return contract;
        }
    }
}
