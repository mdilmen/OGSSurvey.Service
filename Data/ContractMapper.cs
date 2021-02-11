using OGSSurvey.Service.Data.Entities;
using OGSSurvey.Service.Data.Enums;
using OGSSurvey.Service.Data.Models;
using System;
using System.Linq;

namespace OGSSurvey.Service.Data
{
    public class ContractMapper : IContractMapper
    {
        public ContractViewModel MapContract(Contract contract)
        {
            var surveyUser = contract.SurveyUser;
            var spouse = surveyUser.SubUsers.Where(su => su.UserType == UserType.Spouse).FirstOrDefault();
            var child1 = surveyUser.SubUsers.Where(su => su.UserType == UserType.Child && su.SubUserOrder == 1).FirstOrDefault();
            var child2 = surveyUser.SubUsers.Where(su => su.UserType == UserType.Child && su.SubUserOrder == 2).FirstOrDefault();
            var child3 = surveyUser.SubUsers.Where(su => su.UserType == UserType.Child && su.SubUserOrder == 3).FirstOrDefault();
            var child4 = surveyUser.SubUsers.Where(su => su.UserType == UserType.Child && su.SubUserOrder == 4).FirstOrDefault();

            ContractViewModel model = new ContractViewModel()
            {
                BirthDate = contract.SurveyUser.BirthDate,
                CityId = contract.SurveyUser.City.Id,
                Email = contract.SurveyUser.Email,
                PhoneNumber = contract.SurveyUser.Phone,
                FullName = contract.SurveyUser.FullName,
                TCNO = contract.SurveyUser.TCNO,
                guid = contract.Guid

            };
            if (spouse != null)
            {
                model.BirthDate_Spouse = spouse.BirthDate;
                model.CityId_Spouse = spouse.City.Id;
                model.FullName_Spouse = spouse.FullName;
                model.TCNO_Spouse = spouse.TCNO;            
            }
            if (child1 != null)
            {
                model.BirthDate_Child_1 = child1.BirthDate;
                model.CityId_Child_1 = child1.City.Id;
                model.FullName_Child_1 = child1.FullName;
                model.TCNO_Child_1 = child1.TCNO;
            }
            if (child2 != null)
            {
                model.BirthDate_Child_2 = child2.BirthDate;
                model.CityId_Child_2 = child2.City.Id;
                model.FullName_Child_2 = child2.FullName;
                model.TCNO_Child_2 = child2.TCNO;
            }
            if (child3 != null)
            {
                model.BirthDate_Child_3 = child3.BirthDate;
                model.CityId_Child_3 = child3.City.Id;
                model.FullName_Child_3 = child3.FullName;
                model.TCNO_Child_3 = child3.TCNO;
            }
            if (child4 != null)
            {
                model.BirthDate_Child_4 = child4.BirthDate;
                model.CityId_Child_4 = child4.City.Id;
                model.FullName_Child_4 = child4.FullName;
                model.TCNO_Child_4 = child4.TCNO;
            }
            return model;
        }
    }
}
