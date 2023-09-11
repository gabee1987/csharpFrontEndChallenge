namespace WeatherNET.Services.Exceptions_Models
{
    public class InvalidLocationException : Exception
    {
        public InvalidLocationException() : base() { }
        public InvalidLocationException( string message ) : base( message ) { }
        public InvalidLocationException( string message, Exception innerException ) : base( message, innerException ) { }
    }
}
