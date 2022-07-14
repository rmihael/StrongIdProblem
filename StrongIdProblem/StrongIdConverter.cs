using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace StrongIdProblem;

public class StrongIdConverter : ValueConverter<WeatherForecast.StrongId, long>
{
    public StrongIdConverter()
        : base(id => id.Value, v => new WeatherForecast.StrongId(v))
    {
    }
}
