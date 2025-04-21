using StockExchange.WebAPI.Models;

namespace StockExchange.WebAPI.Services;

public interface IContentService
{
    List<SampleContent> GetAll();

    SampleContent GetByID(int id);
}
