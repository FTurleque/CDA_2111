using System.Text.RegularExpressions;

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
            return sentenceToValidate.IsMatch(_sentence);
        }
    }
}
