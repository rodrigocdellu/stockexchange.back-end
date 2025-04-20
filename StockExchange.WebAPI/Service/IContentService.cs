using StockExchange.WebAPI.Model;

namespace StockExchange.WebAPI.Service;

public interface IContentService
{
    List<SampleContent> GetAll();

    SampleContent GetByID(int id);
}
