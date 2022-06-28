namespace FormsMenu.Lib
{
    public class DateValidator
    {
        private DateTime newDate;

        public DateValidator()
        {
            
        }

        public bool IsValidDate(string _date)
        {
            try
            {
                newDate = DateTime.Parse(_date);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public bool DateInTheFUture(string _date)
        {
            newDate = DateTime.Parse(_date);
            try
            {
                if (newDate <= DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException("La date doit être dans le futur.");
                }
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
        }
    }
}
