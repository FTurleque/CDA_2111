using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrouveEmploi.Lib.Validation
{
    public class NameValidator
    {
        private Regex regexName;
        public string Name { get; set; }

        public NameValidator()
        {
            regexName = new Regex(@"^([\p{L}]+([-]?[\p{L}]+)?){1}$");
            Name = string.Empty;
        }

        public bool IsValid(string _name)
        {
            Name = _name;
            return regexName.IsMatch(Name);
        }
    }
}
