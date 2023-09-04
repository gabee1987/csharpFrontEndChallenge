using WeatherNET.Models.WeatherForecast;
using Microsoft.AspNetCore.Mvc;

namespace WeatherNET.Controllers
{
    public class WeatherForecastController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<WeatherForecastModel> _logger;


        public WeatherForecastController( IConfiguration configuration, ILogger<WeatherForecastModel> logger )
        {
            _configuration = configuration;
            _logger        = logger;
        }

        public IActionResult ForecastIndex()
        {
            return View();
        }

        public IActionResult FetchForecast(  )
        {
            return View();
        }
    }
}
