using Microsoft.AspNetCore.Mvc;
using StockExchange.WebAPI.Services;
using StockExchange.WebAPI.Models;

namespace StockExchange.WebAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public sealed class CDBController : ControllerBase
{
    private readonly ICDBService _CDBService;
    
    public CDBController(ICDBService cdbService)
    {
        this._CDBService = cdbService;
    }
    
    [HttpGet("SolicitarCalculoInvestimento")]
    public Retorno SolicitarCalculoInvestimento(decimal investimento, uint meses)
    {
        return this._CDBService.SolicitarCalculoInvestimento(investimento, meses);
    }     
}
