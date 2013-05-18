using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Prototype1_1.Data.EntityModel;

namespace Prototype1_1.Data.DependantModel
{
    public class DependantAPI
    {
        private soen390Entities _soen390Entities;

         public DependantAPI()
        {
            _soen390Entities = EntityModel.EntityModel.getInstance()._soen390Entities;
        }

         public List<dependant> getAllDependants()
         {
             return _soen390Entities.dependant.ToList();
         }
         public bool isMedicareValid(string medicare)
         {
             string pattern = @"\w\w\w\w\d\d\d\d\d\d\d\d";
             Regex regex = new Regex(pattern);

             return regex.IsMatch(medicare);
         }

         public DateTime getDOBFromMcare(string medicare)
         {
             string dateOfBirthString = medicare.Substring(4, 6);
             int year = int.Parse(dateOfBirthString.Substring(0, 2));
             int month = int.Parse(dateOfBirthString.Substring(2, 2));
             int day = int.Parse(dateOfBirthString.Substring(4, 2));
             int thisYear = int.Parse(DateTime.Today.Year.ToString().Substring(2, 2));

             if (year <= thisYear)
             {
                 year += 2000;
             }
             else
             {
                 year += 1900;
             }

             if (getSexFromMcare(medicare) == "F")
             {
                 month -= 50;
             }

             DateTime dateOfBirthDateTime = new DateTime(year, month, day);

             return dateOfBirthDateTime;

         }

         public int getAgeFromDOB(DateTime DOB)
         {
             int age = DateTime.Now.Year - DOB.Year;
             if (DateTime.Now.Month < DOB.Month || (DateTime.Now.Month == DOB.Month && DateTime.Now.Day < DOB.Day))
             {
                 age--;
             }
             return age;
         }

         public string getSexFromMcare(string medicare)
         {
             int monthID = int.Parse(medicare.Substring(6, 2));

             if (monthID > 50)
             {
                 return "F";
             }
             else
             {
                 return "M";
             }
         }
    }
}
