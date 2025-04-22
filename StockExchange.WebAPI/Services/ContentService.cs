using System.Text.Json;
using StockExchange.WebAPI.Models;

namespace StockExchange.WebAPI.Services;

public class ContentService : IContentService
{
    private const string FILEPATH = @"Data/SampleContent.json";

    public List<SampleContent> CountriesInfo { get; set; }
    
    public ContentService()
    {
        this.CountriesInfo = ReadFile();
    }

    private List<SampleContent> ReadFile()
    {
        var sampleContentDeserialized = new List<SampleContent>();
        var sampleContent = String.Empty;

        try
        {
            sampleContent = File.ReadAllText(ContentService.FILEPATH);

            sampleContentDeserialized = JsonSerializer.Deserialize<List<SampleContent>>(sampleContent);
        }
        catch
        {
            throw;
        }

        return sampleContentDeserialized;
    }

    public List<SampleContent> GetAll()
    {
        return this.CountriesInfo;
    }

    public SampleContent GetByID(int id)
    {
        return this.CountriesInfo[id];
    }
}
