using StockExchange.WebAPI.Models;

namespace StockExchange.WebAPI.Services;

public interface ICdbService
{
    Retorno SolicitarCalculoInvestimento(decimal investimento, uint meses);
}
