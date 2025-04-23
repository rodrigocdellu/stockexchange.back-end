using Microsoft.AspNetCore.Mvc;
using StockExchange.WebAPI.Services;
using StockExchange.WebAPI.Models;

namespace StockExchange.WebAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public sealed class CdbController : ControllerBase
{
    private readonly ICdbService _CDBService;
    
    public CdbController(ICdbService cdbService)
    {
        this._CDBService = cdbService;
    }
    
    [HttpGet("SolicitarCalculoInvestimento")]
    public Retorno SolicitarCalculoInvestimento(decimal investimento, uint meses)
    {
        return this._CDBService.SolicitarCalculoInvestimento(investimento, meses);
    }     
}
