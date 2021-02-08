﻿using OGSSurvey.Service.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGSSurvey.Service.Data.Entities
{
    public class Payment
    {
        public Payment()
        {
            PaymentStatus = PaymentStatus.Unknown;
        }
        public int Id { get; set; }
        public Contract Contract { get; set; }
        public Guid ContractGuid { get; set; }
        public int ContractId { get; set; }
        public DateTime CreateDate { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public string ErrMessage { get; set; }
        public string TransactionId { get; set; }
    }
}
