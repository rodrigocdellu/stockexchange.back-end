using Microsoft.AspNetCore.Mvc;
using StockExchange.WebAPI.Services;
using StockExchange.WebAPI.Models;

namespace StockExchange.WebAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public sealed class ContentController : Controller
{
    private readonly IContentService _ContentService;
    
    public ContentController(IContentService contentService)
    {
        this._ContentService = contentService;
    }
    
    [HttpGet]
    public List<SampleContent> GetAll()
    {
        return this._ContentService.GetAll();
    }

    [HttpGet]
    public SampleContent GetByID(int id)
    {
        return this._ContentService.GetByID(id);
    }
}
