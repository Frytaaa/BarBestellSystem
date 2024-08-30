using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        var dbPath = Path.Join(path, "bar.db");
        services.AddDbContext<BarDbContext>(options =>
        {
            options.UseSqlite($"Data Source={dbPath}");
        });

        return services;
    }
}