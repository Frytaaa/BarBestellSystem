using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var exePath = AppDomain.CurrentDomain.BaseDirectory;
        var solutionPath = Directory.GetParent(exePath).Parent.Parent.Parent.Parent.FullName;

        var dbPath = Path.Join(solutionPath, "bar.db");
        services.AddDbContext<BarDbContext>(options =>
        {
            options.UseSqlite($"Data Source={dbPath}");
        });

        return services;
    }
}