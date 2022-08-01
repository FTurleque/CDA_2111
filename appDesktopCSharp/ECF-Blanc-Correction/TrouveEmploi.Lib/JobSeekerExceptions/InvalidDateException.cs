namespace TrouveEmploi.Lib.JobSeekerExceptions
{
    public class InvalidDateException : Exception
    {
        public InvalidDateException()
        {
        }

        public InvalidDateException(string? message) : base(message)
        {
        }
    }
}
