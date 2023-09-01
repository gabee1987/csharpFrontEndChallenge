namespace csharpFrontEndChallenge.Services.Interfaces
{
    public interface ITimeService
    {
        public DateTime ConvertUnixToDateTime( long unixTime );
        public long ConvertDateTimeToUnix( DateTime dateTime );
    }
}
