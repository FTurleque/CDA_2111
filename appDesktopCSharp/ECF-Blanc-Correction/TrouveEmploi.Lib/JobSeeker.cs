namespace TrouveEmploi.Lib
{
    public class JobSeeker
    {
        private static int lastId = 0;

        public int Id { get; private set; }

        public string Name { get; private set; }

        public string FirstName { get; private set; }

        public int RegistrationYear { get; private set; }

        public Levels Level { get; private set; }

        public string Employability { get { return Level + "%"; } }

        public Diploma? Diploma { get; private set; }

        public JobSeeker()
        {
            Id = ++lastId;
        }

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