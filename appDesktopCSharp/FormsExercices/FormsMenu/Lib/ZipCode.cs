using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FormsMenu
{
    public class ZipCode
    {
        private Regex regexZipCode;
        private int zipCode;

        public ZipCode()
        {
            regexZipCode = new Regex(@"^[\d]{5}");
            zipCode = 0;
        }

        public bool isValidNumber(string _userEntry)
        {
            try
            {
                if (!regexZipCode.IsMatch(_userEntry))
                {
                    throw new FormatException("Ne doit comporter que 5 chiffre.");
                }
                zipCode = int.Parse(_userEntry);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
