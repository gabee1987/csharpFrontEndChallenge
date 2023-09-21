using Newtonsoft.Json;
using WeatherNET.App.Services.Interfaces;

namespace WeatherNET.App.Services
{
    public class TooltipService : ITooltipService
    {
        private readonly IHostEnvironment _hostEnvironment;
        private Dictionary<string, string> _tooltips;

        public TooltipService( IHostEnvironment hostEnvironment )
        {
            _hostEnvironment = hostEnvironment;
        }

        //public async Task InitializeAsync()
        //{
        //    var contentRootPath = _hostEnvironment.ContentRootPath;
        //    var jsonPath        = Path.Combine( contentRootPath, "Resources", "tooltips.json" );

        //    var jsonContent = await File.ReadAllTextAsync( jsonPath );
        //    _tooltips       = JsonConvert.DeserializeObject<Dictionary<string, string>>( jsonContent );
        //}

        private async Task EnsureTooltipsLoadedAsync()
        {
            if ( _tooltips == null )
            {
                var contentRootPath = _hostEnvironment.ContentRootPath;
                var jsonPath = Path.Combine( contentRootPath, "Resources", "tooltips.json" );

                var jsonContent = await File.ReadAllTextAsync( jsonPath );
                _tooltips = JsonConvert.DeserializeObject<Dictionary<string, string>>( jsonContent );
            }
        }

        public async Task<string> GetTooltipForAsync( string propertyName )
        {
            await EnsureTooltipsLoadedAsync();
            _tooltips.TryGetValue( propertyName, out var tooltip );
            return tooltip;
        }
    }
}
