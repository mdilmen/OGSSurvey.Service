using OGSSurvey.Service.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGSSurvey.Service.Data
{
    public interface IRepository
    {
        Contract GetContractByTcNo(string tcno);
        Contract GetContractByGuid(Guid guid);
        Contract GetContractById(int id);
    }
}
