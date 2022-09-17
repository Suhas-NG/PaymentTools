using NoteOne.Common.Dates;

namespace NoteOne.Common
{
    public class DateService : IDateService
    {
        public DateTime GetDateTime()
        {
            return DateTime.Now.Date;
        }
    }
}