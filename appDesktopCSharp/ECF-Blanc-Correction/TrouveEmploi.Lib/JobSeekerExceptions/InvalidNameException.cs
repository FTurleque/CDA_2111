namespace TrouveEmploi.Lib.JobSeekerExceptions
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException()
        {
        }

        public InvalidNameException(string? message) : base(message)
        {
        }
    }
}
