using System.Text.RegularExpressions;

namespace LibInputValidation
{
    public class NameValidator
    {
        private Regex regexName;
        private string name;

        public NameValidator()
        {
            regexName = new Regex(@"^([\w]+[-]?[\w]+){2,30}$");
            name = string.Empty;
        }

        public string Name { get => name; }

        public bool isValid(string _name)
        {
            name = _name;
            return regexName.IsMatch(_name);
        }

    }
}