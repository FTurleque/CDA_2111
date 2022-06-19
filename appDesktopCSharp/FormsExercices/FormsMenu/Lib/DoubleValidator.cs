using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FormsMenu
{
    public class DoubleValidator
    {
        private Regex regexDouble;
        private double amount;

        public DoubleValidator()
        {
            regexDouble = new Regex(@"^[\d]+([.,]?[\d]{2})?$");
            amount = 0.0;
        }

        public bool IsValidDouble(string _userEntry)
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            try
            {
                if (!regexDouble.IsMatch(_userEntry))
                {
                    throw new FormatException("Ne comporte pas que des chiffre");
                }
                if (currentCulture == new CultureInfo("en-EN"))
                {
                    amount = double.Parse(Regex.Replace(_userEntry, "[,]", replacement: "."));
                }
                else
                {
                    amount = double.Parse(Regex.Replace(_userEntry, "[.]", replacement: ","));
                }
                return true;
            }
            catch (FormatException e)
            {
                return false;
            }

        }
    }
}
