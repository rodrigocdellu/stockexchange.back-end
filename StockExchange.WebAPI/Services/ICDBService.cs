using StockExchange.WebAPI.Models;
using StockExchange.WebAPI.Helpers;

namespace StockExchange.WebAPI.Services;

public interface ICdbService
{
    Task<ServiceResultHelper<Retorno>> SolicitarCalculoInvestimento(decimal investimento, uint meses);
}
