using WeatherNET.Services.PirateWeatherApi.TimeService.Interfaces;

namespace WeatherNET.Services.PirateWeatherApi.TimeService
{
    public class TimeService : ITimeService
    {
        private static readonly DateTimeOffset UnixEpoch = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);

        public DateTime ConvertUnixToDateTime(long unixTime)
        {
            var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTime).ToLocalTime();

            return dateTime;
        }

        public long ConvertDateTimeToUnix(DateTime dateTime)
        {
            var unixTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            long unixTimeStamp = (long)(dateTime.ToUniversalTime() - unixTime).TotalSeconds;

            return 0;
        }

        /// <summary>
        /// Converts a UNIX timestamp to a DateTimeOffset.
        /// </summary>
        /// <param name="unixTimeStamp">The UNIX timestamp.</param>
        /// <returns>The corresponding DateTimeOffset.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the timestamp is out of valid range.</exception>
        public DateTimeOffset UnixTimeStampToDateTimeOffset(long unixTimeStamp)
        {
            if (unixTimeStamp < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(unixTimeStamp), "UNIX timestamp cannot be negative.");
            }

            return UnixEpoch.AddSeconds(unixTimeStamp);
        }

        /// <summary>
        /// Converts a DateTimeOffset to a UNIX timestamp.
        /// </summary>
        /// <param name="dateTimeOffset">The DateTimeOffset.</param>
        /// <returns>The corresponding UNIX timestamp.</returns>
        public long DateTimeOffsetToUnixTimeStamp(DateTimeOffset dateTimeOffset)
        {
            if (dateTimeOffset < UnixEpoch)
            {
                throw new ArgumentOutOfRangeException(nameof(dateTimeOffset), "DateTimeOffset cannot be before the UNIX epoch.");
            }

            return (long)(dateTimeOffset - UnixEpoch).TotalSeconds;
        }

        /// <summary>
        /// Converts a DateTime to a UNIX timestamp.
        /// </summary>
        /// <param name="dateTime">The DateTime (should be in UTC).</param>
        /// <returns>The corresponding UNIX timestamp.</returns>
        /// <exception cref="ArgumentException">Thrown when the DateTime is not in UTC.</exception>
        public long DateTimeToUnixTimeStamp(DateTime dateTime)
        {
            if (dateTime.Kind != DateTimeKind.Utc)
            {
                throw new ArgumentException("DateTime must be in UTC.", nameof(dateTime));
            }

            return DateTimeOffsetToUnixTimeStamp(new DateTimeOffset(dateTime));
        }
    }
}
