using Microsoft.EntityFrameworkCore;

namespace StrongIdProblem;

public class StrongIdProblemDbContext : DbContext
{
    public StrongIdProblemDbContext (DbContextOptions<StrongIdProblemDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new WeatherForecastTypeConfiguration().Configure(modelBuilder.Entity<WeatherForecast>());
    }
}
