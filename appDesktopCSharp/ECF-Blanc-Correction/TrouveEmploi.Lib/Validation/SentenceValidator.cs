using System.Text.RegularExpressions;
using TrouveEmploi.Lib.JobSeekerExceptions;

namespace TrouveEmploi.Lib.Validation
{
    public class SentenceValidator
    {
        private Regex sentenceToValidate;

        public SentenceValidator()
        {
            sentenceToValidate = new Regex(@"^[\p{L} ']+$");
        }

        /// <summary>
        /// Valide une phrase n'acceptant que les espaces, l'appostrophe et toutes les lettres
        /// </summary>
        /// <param name="_sentence">Chaine de charactère</param>
        /// <returns>Vrai ou faux</returns>
        public bool IsValid(string _sentence)
        {
            if (String.IsNullOrEmpty(_sentence))
            {
                throw new InvalidStringException("Veuillez remplir le champ.");
            }
            if (!sentenceToValidate.IsMatch(_sentence))
            {
                throw new InvalidStringException("Le nom du diplôme comporte des charactères interdit.");
            }
            return true;
        }
    }
}
