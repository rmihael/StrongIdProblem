using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StrongIdProblem;

public class WeatherForecastTypeConfiguration : IEntityTypeConfiguration<WeatherForecast>
{
    public void Configure(EntityTypeBuilder<WeatherForecast> builder)
    {
        builder.Property(e => e.Id).HasConversion<StrongIdConverter>().UseHiLo();
    }
}
