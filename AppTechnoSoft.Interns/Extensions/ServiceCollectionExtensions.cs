using AppTechnoSoft.Interns.Helpers;

namespace AppTechnoSoft.Interns.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBrowserTimeProvider(this IServiceCollection services)
        => services.AddTransient<TimeProvider, BrowserTimeProvider>();
}