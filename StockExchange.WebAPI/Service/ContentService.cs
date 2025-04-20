using System.Text.Json;
using StockExchange.WebAPI.Model;

namespace StockExchange.WebAPI.Service;

public class ContentService : IContentService
{
    List<SampleContent> CountriesInfo;
    
    public ContentService()
    {
        CountriesInfo = ReadFile();
    }

    private List<SampleContent> ReadFile()
    {
        var sampleContentDeserialized = new List<SampleContent>();
        var sampleContent = String.Empty;

        try
        {
            sampleContent = File.ReadAllText(@"Data/SampleContent.json");

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
        return CountriesInfo;
    }

    public SampleContent GetByID(int id)
    {
        return CountriesInfo[id];
    }
}
