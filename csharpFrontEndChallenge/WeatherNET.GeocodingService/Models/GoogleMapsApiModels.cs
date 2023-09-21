using Newtonsoft.Json;

namespace WeatherNET.GeocodingService
{
    public class GoogleGeocodeResponse
    {
        [JsonProperty( "status" )]
        public string Status { get; set; }

        [JsonProperty( "results" )]
        public List<GeocodingResult> Results { get; set; }

        [JsonProperty( "plus_code" )]
        public PlusCode Plus_Code { get; set; }
    }

    public class GeocodingResult
    {
        [JsonProperty( "address_components" )] 
        public List<AddressComponent> Address_Components { get; set; }

        [JsonProperty( "formatted_address" )]
        public string Formatted_Address { get; set; }

        [JsonProperty( "geometry" )]
        public GeocodingGeometry Geometry { get; set; }

        [JsonProperty( "types" )]
        public List<string> Types { get; set; }

        [JsonProperty( "place_id" )]
        public string Place_Id { get; set; }
    }

    public class AddressComponent
    {
        [JsonProperty( "long_name" )]
        public string Long_Name { get; set; }

        [JsonProperty( "short_name" )]
        public string Short_Name { get; set; }

        [JsonProperty( "types" )]
        public List<string> Types { get; set; }
    }

    public class GeocodingGeometry
    {
        [JsonProperty( "location" )]
        public GeocodingLocation Location { get; set; }

        [JsonProperty( "location_type" )]
        public string Location_Type { get; set; }

        [JsonProperty( "viewport" )]
        public Bounds Viewport { get; set; }

        [JsonProperty( "bounds", NullValueHandling = NullValueHandling.Ignore )]
        public Bounds Bounds { get; set; }
    }

    public class Bounds
    {
        [JsonProperty( "northeast" )]
        public GeocodingLocation Northeast { get; set; }

        [JsonProperty( "southwest" )]
        public GeocodingLocation Southwest { get; set; }
    }

    public class GeocodingLocation
    {
        [JsonProperty( "lat" )]
        public double Lat { get; set; }

        [JsonProperty( "lng" )]
        public double Lng { get; set; }
    }

    public class PlusCode
    {
        [JsonProperty( "compound_code" )]
        public string Compound_Code { get; set; }

        [JsonProperty( "global_code" )]
        public string Global_Code { get; set; }
    }
}
