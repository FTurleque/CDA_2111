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
            RegistrationYear = DateTime.Now.Year;
            if (nameValidator.IsValid(Name) && nameValidator.IsValid(FirstName))
            {
                if (Diploma is not null)
                {
                    if (Diploma.LastDiplomaYear is not null && String.IsNullOrEmpty(Diploma.LastDiplomaName))
                    {
                        throw new InvalidDataException("Vous n'avez pas renseigné le nom du diplôme.");
                    }

                    if (!sentenceValidator.IsValid(Diploma.LastDiplomaName))
                    {
                        throw new InvalidDataException("Le nom du diplôme comporte des charactères interdit.");
                    }

                    /*if (yearValidator.IsValid(Diploma.LastDiplomaYear.ToString()))
                    {
                        throw new FormatException("Une année ne comporte que des chiffres.");
                    }*/

                    if (Diploma.LastDiplomaYear is null && String.IsNullOrEmpty(Diploma.LastDiplomaName))
                    {
                        throw new InvalidDataException("Vous n'avez pas renseigné la date du diplôme.");
                    }
                }
                return true;
            }
            return false;
        }
    }
}
