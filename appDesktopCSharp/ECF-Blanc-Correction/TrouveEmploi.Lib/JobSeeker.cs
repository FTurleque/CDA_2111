namespace TrouveEmploi.Lib
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
        }

        /// <summary>
        /// Constructeur par copie.
        /// </summary>
        /// <param name="jobSeeker">Instance du demandeur à cloné</param>
        public JobSeeker(JobSeeker jobSeeker)
        {
            this.Id = jobSeeker.Id;
            this.Name = jobSeeker.Name;
            this.FirstName = jobSeeker.FirstName;
            this.RegistrationYear = jobSeeker.RegistrationYear;
            this.Level = jobSeeker.Level;
            this.Diploma = jobSeeker.Diploma;
        }
    }
}