using StockExchange.WebAPI.Models;

namespace StockExchange.WebAPI.Services;

public interface ICDBService
{
    Retorno SolicitarCalculoInvestimento(decimal investimento, uint meses);
}
