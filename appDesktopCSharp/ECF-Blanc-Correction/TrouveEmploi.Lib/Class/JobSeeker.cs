using TrouveEmploi.Lib.Extensions;

namespace TrouveEmploi.Lib.Class
{
    public class JobSeeker
    {
        // Dernier Id qui concernera toutes les instances.
        private static int lastId = 0;

        // Id d'un demandeur d'emploi.
        public int Id { get; private set; }

        // Nom du demandeur.
        public string Name { get; set; }

        // Prénom du demandeur.
        public string FirstName { get; set; }

        // Année d'inscription du demandeur.
        public int RegistrationYear { get; set; }

        // Niveau d'étude du demandeur.
        public Levels? Level { get; set; }

        // Taux d'employabilité.
        public string Employability { get { return (int)Level + "%"; } }

        // Dernier diplôme obtenu.
        public Diploma? Diploma { get; set; }

        public JobSeeker()
        {
            Id = ++lastId;
            RegistrationYear = DateTime.Now.Year;
        }

        /// <summary>
        /// Constructeur par copie.
        /// </summary>
        /// <param name="jobSeeker">Instance du demandeur à cloné</param>
        public JobSeeker(JobSeeker jobSeeker)
        {
            Id = jobSeeker.Id;
            Name = jobSeeker.Name;
            FirstName = jobSeeker.FirstName;
            RegistrationYear = jobSeeker.RegistrationYear;
            Level = jobSeeker.Level;
            Diploma = jobSeeker.Diploma;
        }
    }
}