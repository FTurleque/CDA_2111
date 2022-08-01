namespace TrouveEmploi.Lib.Class
{
    public class Diploma
    {
        // Nom du diplôme.
        public string? LastDiplomaName { get; private set; }

        // Année d'obtention du diplôme.
        public string? LastDiplomaYear { get; private set; }

        public Diploma(string _lastDiplomaName, string _lastDiplomaYear)
        {
            LastDiplomaName = _lastDiplomaName;
            LastDiplomaYear = _lastDiplomaYear;
        }
    }
}
