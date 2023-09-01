using csharpFrontEndChallenge.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharpFrontEndChallenge.Controllers
{
    public class WeatherForecastController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<WeatherForecast> _logger;


        public WeatherForecastController( IConfiguration configuration, ILogger<WeatherForecast> logger )
        {
            _configuration = configuration;
            _logger        = logger;
        }

        public IActionResult ForecastIndex()
        {
            return View();
        }
    }
}
