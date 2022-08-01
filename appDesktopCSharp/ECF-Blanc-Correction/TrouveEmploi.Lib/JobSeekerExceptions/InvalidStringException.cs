namespace TrouveEmploi.Lib.JobSeekerExceptions
{
    public class InvalidStringException : Exception
    {
        public InvalidStringException()
        {
        }

        public InvalidStringException(string message) : base(message)
        {
        }
    }
}
