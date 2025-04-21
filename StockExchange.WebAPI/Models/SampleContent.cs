using System.Text.Json.Serialization;

namespace StockExchange.WebAPI.Models;

public class SampleContent
{
    [JsonPropertyName("name")]

    public string? Name { get; set; }

    [JsonPropertyName("capital")]

    public string? Capital { get; set; }

    public List<Content>? currencies { get; set; }
}
