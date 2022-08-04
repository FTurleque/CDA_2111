using System.Text.RegularExpressions;
using TrouveEmploi.Lib.JobSeekerExceptions;

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

        /// <summary>
        /// Validation d'un nom et un prénom
        /// </summary>
        /// <param name="_name">Nom ou prénom</param>
        /// <returns>Vrai ou faux</returns>
        public bool IsValid(string _name)
        {
            if (String.IsNullOrEmpty(_name))
            {
                throw new InvalidStringException("Veuillez remplir le champ.");
            }
            Name = _name;
            if (!regexName.IsMatch(Name))
            {
                throw new InvalidNameException("Le nom comporte des charactères invalide.");
            }
            return true;
        }
    }
}
