using System.Runtime.InteropServices;
using StockExchange.WebAPI.Helpers;

namespace StockExchange.WebAPI.Services;

public class ApplicationService : IApplicationService
{
    public DateTime StartupTime { get; set; }

    public string? FrameworkVersion { get; set;}

    public ApplicationService()
    {
        // Looking for a Brazil/SãoPaulo timezone due to Docker Container timezone
        var brazilTimeZone = TimeZoneInfo.GetSystemTimeZones()
            .FirstOrDefault(tz =>
                (tz.Id.Contains("Brazil", StringComparison.OrdinalIgnoreCase) ||
                tz.Id.Contains("E. South America", StringComparison.OrdinalIgnoreCase) ||
                tz.Id.Contains("America/Sao_Paulo", StringComparison.OrdinalIgnoreCase) ||
                tz.DisplayName.Contains("Brazil", StringComparison.OrdinalIgnoreCase) ||
                tz.DisplayName.Contains("Sao Paulo", StringComparison.OrdinalIgnoreCase)) &&
                tz.GetUtcOffset(DateTime.Now) == TimeSpan.FromHours(-3)
            );

        // If the Brazil/SãoPaulo timezone was not found, used the UTC timezone
        if (brazilTimeZone == null)
            this.StartupTime = DateTime.UtcNow;
        else
            this.StartupTime = DateTime.UtcNow.ConvertToLocalTime(brazilTimeZone.Id);

        this.FrameworkVersion = RuntimeInformation.FrameworkDescription;
    }
}
