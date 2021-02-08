﻿using OGSSurvey.Service.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGSSurvey.Service.Data.Entities
{
    public class SurveyUser 
    {
        public SurveyUser()
        {
            this.SubUsers = new List<SubUser>();
        }
        public int Id { get; set; }
        public string TCNO { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public City City { get; set; }
        public List<SubUser> SubUsers { get; set; }
        public WorkType WorkType { get; set; }        
        public Premium Premium { get; set; }
    }
}
