using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TrouveEmploi.Lib.Class;
using TrouveEmploi.Lib.JobSeekerExceptions;

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
            if (String.IsNullOrEmpty(Name) || String.IsNullOrEmpty(FirstName))
            {
                return false;
                //throw new InvalidNameException("Veuillez renseigner le champ.");
            }
            RegistrationYear = DateTime.Now.Year;
            if (nameValidator.IsValid(Name) && nameValidator.IsValid(FirstName))
            {
                if (Diploma is not null)
                {
                    if ((!String.IsNullOrEmpty(Diploma.LastDiplomaYear) && String.IsNullOrEmpty(Diploma.LastDiplomaName)) ||
                        (String.IsNullOrEmpty(Diploma.LastDiplomaYear) && !String.IsNullOrEmpty(Diploma.LastDiplomaName)))
                    {
                        return false;
                        //throw new InvalidDataException("Vous n'avez pas renseigné ");
                    }

                    if (!sentenceValidator.IsValid(Diploma.LastDiplomaName))
                    {
                        return false;
                        //throw new InvalidStringException("diplôme comporte des charactères interdit.");
                    }

                    if (!yearValidator.IsValid(Diploma.LastDiplomaYear))
                    {
                        return false;
                        //throw new InvalidDateException("Une année ne comporte 4 chiffres.");
                    }

                    if (!yearValidator.IsNotInFuture(int.Parse(Diploma.LastDiplomaYear)))
                    {
                        return false;
                        //throw new InvalidDateException("La date du diplôme ne peut pas être dans le future.");
                    }

                }
                return true;
            }
            return false;
            //throw new InvalidNameException("Le champ ne doit comporté que des lettres ou un '-'.");
        }
    }
}
