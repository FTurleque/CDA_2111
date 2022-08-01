using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrouveEmploi.Lib.Validation
{
    public class YearValidator
    {
        private DateTime dateToVlidate;
        private Regex regexYear;

        public YearValidator()
        {
            regexYear = new Regex(@"^[\d]{4}$");
        }

        public bool IsValid(string _year)
        {
            try
            {
                if (String.IsNullOrEmpty(_year))
                {
                    throw new ArgumentNullException("Veuillez remplir le champ.");
                }
                if (!regexYear.IsMatch(_year))
                {
                    throw new FormatException("Une année ne comporte pas de lettres.");
                }
            }
            catch (ArgumentNullException e)
            {
                throw e;
            }
            catch (FormatException e)
            {
                throw e;
            }
            return IsNotInFuture(Int32.Parse(_year));
        }

        public bool IsNotInFuture(int _year)
        {
            int thisYear = DateTime.Today.Year;
            if (thisYear < _year)
            {
                throw new FormatException("L'année ne peut pas être dans le futur.");
            }
            return true;
        }
    }
}
