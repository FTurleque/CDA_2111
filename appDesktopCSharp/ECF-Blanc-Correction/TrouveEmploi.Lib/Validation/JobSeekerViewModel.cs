using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrouveEmploi.Lib.Validation
{
    public class JobSeekerViewModel : JobSeeker
    {
        private readonly Regex regexName = new Regex(@"^([\p{L}]+([-]?[\p{L}]+)?){1}$");
        private readonly Regex regexDiploma = new Regex(@"^[\p{L} ']+$");
        private readonly int currentYear = DateTime.Now.Year;

        public bool IsValid()
        {
            if(!Validation_Name() || !ValidationFirstName())
            {
                return false;
            }

            if(!Validation_Date())
            {
                return false;
            }

            if(Diploma != null)
            {
                if(!Validation_LastDiplomaName())
                {
                    return false;
                }

                if(!Validation_Date())
                {
                    return false;
                }
            }
            
            return true;
        }

        public bool Validation_Name()
        {
            return regexName.IsMatch(Name);
        }

        public bool ValidationFirstName()
        {
            return regexName.IsMatch(FirstName);
        }

        public bool Validation_LastDiplomaName()
        {
            return regexDiploma.IsMatch(Diploma.LastDiplomaName);
        }

        public bool Validation_Date()
        {
            if (Diploma.LastDiplomaYear > currentYear || 
                Diploma.LastDiplomaYear < 1950 || 
                RegistrationYear > currentYear ||
                RegistrationYear < 1950)
            {
                return false;
            }
            return true;
        }
    }
}
