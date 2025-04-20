using System.Text.Json.Serialization;

namespace StockExchange.WebAPI.Model;

public class Content
{
    [JsonPropertyName("code")]

    public string? Code { get; set; }

    [JsonPropertyName("name")]

    public string? Name { get; set; }
}
