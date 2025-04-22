using System.Runtime.InteropServices;

namespace StockExchange.WebAPI.Services;

public class ApplicationService : IApplicationService
{
    public DateTime StartupTime { get; set; }

    public string? FrameworkVersion { get; set;}

    public ApplicationService()
    {
        this.StartupTime = DateTime.Now;
        this.FrameworkVersion = RuntimeInformation.FrameworkDescription;
    }
}
