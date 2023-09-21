namespace WeatherNET.App.Services.Interfaces
{
    public interface ITooltipService
    {
        Task<string> GetTooltipForAsync( string propertyName );
        //Task InitializeAsync();
    }
}
