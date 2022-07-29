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
            int year;
            try
            {
                year = Int32.Parse(_year);
                if (!regexYear.IsMatch(_year))
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                return false;
            }
            return IsNotInFuture(year);
        }

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
