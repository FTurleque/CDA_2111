using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrouveEmploi.Lib.Validation
{
    public class SentenceValidator
    {
        private Regex sentenceToValidate;

        public SentenceValidator()
        {
            sentenceToValidate = new Regex(@"^[\p{L} ']+$");
        }

        public bool IsValid(string _sentence)
        {
            return sentenceToValidate.IsMatch(_sentence);
        }
    }
}
