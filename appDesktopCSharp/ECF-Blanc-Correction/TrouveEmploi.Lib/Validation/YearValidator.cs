using System.Text.RegularExpressions;

namespace TrouveEmploi.Lib.Validation
{
    public class YearValidator
    {
        private DateTime dateToVlidate;
        private Regex regexYear;

        public YearValidator()
        {
            regexYear = new Regex(@"^[0-9]{4}$");
        }

        /// <summary>
        /// Valide que la chaine de charactère est un entier.
        /// </summary>
        /// <param name="_year">Chaine de charactère</param>
        /// <returns>Vrai ou faux</returns>
        public bool IsValid(string _year)
        {
            if (String.IsNullOrEmpty(_year))
            {
                return false;
            }
            if (!regexYear.IsMatch(_year))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valide que l'année n'est pas dans le futur.
        /// </summary>
        /// <param name="_year"></param>
        /// <returns>Vrai ou faux</returns>
        public bool IsNotInFuture(int _year)
        {
            int thisYear = DateTime.Today.Year;
            if (thisYear < _year)
            {
                return false;
            }
            return true;
        }
    }
}
