using Microsoft.AspNetCore.Mvc;
using StockExchange.WebAPI.Service;
using StockExchange.WebAPI.Model;

namespace StockExchange.WebAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class CountriesController : Controller
{
    IContentService _CountryService;

    public CountriesController(IContentService countryService)
    {
        _CountryService = countryService;
    }
    
    [HttpGet]
    public List<SampleContent> GetAll()
    {
        return _CountryService.GetAll();
    }

    [HttpGet]
    public SampleContent GetByID(int id)
    {
        return _CountryService.GetByID(id);
    }
}
