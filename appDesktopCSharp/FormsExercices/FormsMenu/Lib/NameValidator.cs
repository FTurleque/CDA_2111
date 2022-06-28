﻿using System.Text.RegularExpressions;

namespace FormsMenu.Lib
{
    public class NameValidator
    {
        private Regex regexName;
        private string name;

        public NameValidator()
        {
            regexName = new Regex(@"^([\p{L}]+([-]?[\p{L}]+)?){1}$");
            name = string.Empty;
        }

        public string Name { get => name; }

        public bool IsValidName(string _name)
        {
            name = _name;
            return regexName.IsMatch(_name);
        }

    }
}