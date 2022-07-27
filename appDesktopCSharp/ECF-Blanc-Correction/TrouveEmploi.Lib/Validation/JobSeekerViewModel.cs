using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrouveEmploi.Lib.Validation
{
    public class JobSeekerViewModel : JobSeeker
    {
        private readonly Regex regexName = new Regex(@"^([\p{L}]+([-]?[\p{L}]+)?){1}$");
        private readonly Regex regexDiploma = new Regex(@"^[\p{L} ']+$");

        public bool IsValid()
        {
            if(!regexName.IsMatch(Name) || regexName.IsMatch(FirstName))
            {
                return false;
            }

            // Verifié si un diplôme est bien renseigné.
            if(Diploma != null)
            {
                if(!regexDiploma.IsMatch(Diploma.LastDiplomaName))
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}
