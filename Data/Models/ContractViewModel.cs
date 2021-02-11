using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGSSurvey.Service.Data.Models
{
    public class ContractViewModel
    {
        public Guid guid { get; set; }
        public string TCNO { get; set; }


        public string FullName { get; set; }

        public string PhoneNumber { get; set; }
        
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }
        
        public int CityId { get; set; }        


        // Eş        
        public string TCNO_Spouse { get; set; }
       
        public string FullName_Spouse { get; set; }

       
        public DateTime? BirthDate_Spouse { get; set; }

        public int CityId_Spouse { get; set; }
       


        // 1. Çocuk
      
        public string TCNO_Child_1 { get; set; }
      
        public string FullName_Child_1 { get; set; }
        public DateTime? BirthDate_Child_1 { get; set; }

        public int CityId_Child_1 { get; set; }

        // 2. Çocuk
        public string TCNO_Child_2 { get; set; }
        
        public string FullName_Child_2 { get; set; }
        
        public DateTime? BirthDate_Child_2 { get; set; }

        public int CityId_Child_2 { get; set; }

        // 3. Çocuk
        public string TCNO_Child_3 { get; set; }
        
        public string FullName_Child_3 { get; set; }

        public DateTime? BirthDate_Child_3 { get; set; }

        public int CityId_Child_3 { get; set; }

        // 4. Çocuk
        public string TCNO_Child_4 { get; set; }
        
        public string FullName_Child_4 { get; set; }
        
        public DateTime? BirthDate_Child_4 { get; set; }
        public int CityId_Child_4 { get; set; }

    }
}
