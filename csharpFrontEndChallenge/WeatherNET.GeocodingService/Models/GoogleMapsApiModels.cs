namespace WeatherNET.GeocodingService
{
    public class GeocodingResponse
    {
        public string Status { get; set; }
        public List<GeocodingResult> Results { get; set; }
    }

    public class GeocodingResult
    {
        public string FormattedAddress { get; set; }
        public GeocodingGeometry Geometry { get; set; }
    }

    public class GeocodingGeometry
    {
        public GeocodingLocation Location { get; set; }
    }

    public class GeocodingLocation
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
}
