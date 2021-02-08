﻿using OGSSurvey.Service.Data.Entities;
using OGSSurvey.Service.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGSSurvey.Service.Data
{
    public interface IContractMapper
    {
        ContractViewModel MapContract(Contract contract);
    }
}
