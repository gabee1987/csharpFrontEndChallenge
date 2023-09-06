namespace WeatherNET.Services.PirateWeatherApi.TimeService
{
    public interface ITimeService
    {
        public DateTime ConvertUnixToDateTime(long unixTime);
        public long ConvertDateTimeToUnix(DateTime dateTime);
        public DateTimeOffset UnixTimeStampToDateTimeOffset(long unixTimeStamp);
        public long DateTimeOffsetToUnixTimeStamp(DateTimeOffset dateTimeOffset);
        public long DateTimeToUnixTimeStamp(DateTime dateTime);
    }
}
