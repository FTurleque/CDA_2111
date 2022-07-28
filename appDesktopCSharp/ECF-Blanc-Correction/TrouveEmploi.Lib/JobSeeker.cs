namespace TrouveEmploi.Lib
{
    public class JobSeeker
    {
        private static int lastId = 0;

        public int Id { get; set; }

        public string Name { get; set; }

        public string FirstName { get; set; }

        public int RegistrationYear { get; set; }

        public Levels Level { get; set; }

        public string Employability { get { return Int32.Parse(Level.ToString()).ToString() + "%"; } }

        public Diploma? Diploma { get; set; }

        public JobSeeker()
        {
            Id = ++lastId;
        }

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