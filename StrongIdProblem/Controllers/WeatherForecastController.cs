using Microsoft.AspNetCore.Mvc;

namespace StrongIdProblem.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly StrongIdProblemDbContext _dbContext;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        StrongIdProblemDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        var results = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Id = default,
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        _dbContext.AttachRange(results);
        _dbContext.SaveChanges();
        return results;
    }
}
