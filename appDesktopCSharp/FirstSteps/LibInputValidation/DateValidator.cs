using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibInputValidation
{
    public class DateValidator
    {
        private DateTime newDate;

        public DateValidator()
        {

        }

        public bool isValid(string _date)
        {
            try
            {
                newDate = DateTime.Parse(_date);
/*                if(newDate <= DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException("La date doit être dans le futur.");
                }
*/                return true;
            }
            catch (FormatException e)
            {
                throw e;
            }
        }
    }
}
