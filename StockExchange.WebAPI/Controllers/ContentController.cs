using Microsoft.AspNetCore.Mvc;
using StockExchange.WebAPI.Services;
using StockExchange.WebAPI.Models;

namespace StockExchange.WebAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ContentController : Controller
{
    IContentService _ContentService;

    public ContentController(IContentService contentService)
    {
        _ContentService = contentService;
    }
    
    [HttpGet]
    public List<SampleContent> GetAll()
    {
        return _ContentService.GetAll();
    }

    [HttpGet]
    public SampleContent GetByID(int id)
    {
        return _ContentService.GetByID(id);
    }
}
