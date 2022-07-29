using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TrouveEmploi.Lib.Class;

namespace TrouveEmploi.Lib.Validation
{
    public class JobSeekerViewModel : JobSeeker
    {
        private readonly Regex regexName = new Regex(@"^([\p{L}]+([-]?[\p{L}]+)?){1}$");
        private readonly Regex regexDiploma = new Regex(@"^[\p{L} ']+$");
        private readonly int currentYear = DateTime.Now.Year;
        private NameValidator nameValidator = new NameValidator();
        private SentenceValidator sentenceValidator = new SentenceValidator();
        private YearValidator yearValidator = new YearValidator();

        /// <summary>
        /// Valide toutes les données du view model.
        /// </summary>
        /// <returns>Retourne si le test est passé ou pas</returns>
        public bool IsValid()
        {
            if(!nameValidator.IsValid(Name) || !nameValidator.IsValid(FirstName))
            {
                return false;
            }

            if(!yearValidator.IsValid(RegistrationYear.ToString()))
            {
                return false;
            }

            if(Diploma != null)
            {
                if(!sentenceValidator.IsValid(Diploma.LastDiplomaName))
                {
                    return false;
                }

                if(!yearValidator.IsValid(Diploma.LastDiplomaYear.ToString()))
                {
                    return false;
                }
            }
            
            return true;
        }

        /*public bool Validation_Name()
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

        public bool ValidationRegistrationYear_Date()
        {
            if (RegistrationYear > currentYear || RegistrationYear < 1950)
            {
                return false;
            }
            return true;
        }

        public bool ValidationDiplomaYear_Date()
        {
            if (Diploma.LastDiplomaYear > currentYear || Diploma.LastDiplomaYear < 1950)
            {
                return false;
            }
            return true;
        }*/
    }
}
