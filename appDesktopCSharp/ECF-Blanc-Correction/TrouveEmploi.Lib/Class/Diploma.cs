using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrouveEmploi.Lib.Class
{
    public class Diploma
    {
        // Nom du diplôme.
        public string? LastDiplomaName { get; private set; }

        // Année d'obtention du diplôme.
        public int? LastDiplomaYear { get; private set; }

        public Diploma(string _lastDiplomaName, int _lastDiplomaYear)
        {
            LastDiplomaName = _lastDiplomaName;
            LastDiplomaYear = _lastDiplomaYear;
        }
    }
}
