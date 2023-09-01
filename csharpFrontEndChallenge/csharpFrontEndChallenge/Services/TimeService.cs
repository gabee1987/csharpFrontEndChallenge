using csharpFrontEndChallenge.Services.Interfaces;

namespace csharpFrontEndChallenge.Services
{
    public class TimeService : ITimeService
    {
        public  DateTime ConvertUnixToDateTime( long unixTime )
        {
            return DateTime.Now;
        }

        public  long ConvertDateTimeToUnix( DateTime dateTime )
        {
            return 0;
        }
    }
}
