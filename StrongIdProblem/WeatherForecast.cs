namespace StrongIdProblem;

public class WeatherForecast
{
    public readonly record struct StrongId(long Value);

    public StrongId Id { get; set; }

    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public string? Summary { get; set; }
}
