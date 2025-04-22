namespace StockExchange.WebAPI.Services;

public interface IApplicationService
{
    DateTime StartupTime { get; set; }

    string? FrameworkVersion { get; set; }
}
