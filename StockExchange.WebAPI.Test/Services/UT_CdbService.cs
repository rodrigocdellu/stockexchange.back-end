using StockExchange.WebAPI.Services;
using StockExchange.WebAPI.Test.Helpers;

namespace StockExchange.WebAPI.Test.Services;

public class UT_CdbService
{
    private ICdbService? _CdbService;

    private List<RetornoContainerHelper>? Samples { get; set; }

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestValidResults()
    {
        // Load data
        this.Samples = DataHelper.LoadData();

        // Create the service
        this._CdbService = new CdbService();

        // Scan the list
        foreach (var sample in this.Samples)
        {
            // Scan the list
            foreach (var retornoValido in sample.RetornosValidos)
            {
                // Define the variables
                decimal investimento;
                uint meses;
                decimal resultadoBruto;
                decimal resultadoLiquido;

                // Cast variables for the service
                DataHelper.CastData(retornoValido, out investimento, out meses, out resultadoBruto, out resultadoLiquido);

                // Call the service
                var retorno = this._CdbService.SolicitarCalculoInvestimento(investimento, meses).Result.Data;

                // If there is no data, the test fail
                if (retorno == null)
                    Assert.Fail();
                else
                    Assert.That(retorno.ResultadoBruto, Is.EqualTo(resultadoBruto));
            }
        }
    }

    [Test]
    public void TestInvalidResults()
    {
        // Load data
        this.Samples = DataHelper.LoadData();

        // Create the service
        this._CdbService = new CdbService();

        // Scan the list
        foreach (var sample in this.Samples)
        {
            // Scan the list
            foreach (var retornoInvalido in sample.RetornosInvalidos)
            {
                // Define the variables
                decimal investimento;
                uint meses;
                decimal resultadoBruto;
                decimal resultadoLiquido;

                // Cast variables for the service
                DataHelper.CastData(retornoInvalido, out investimento, out meses, out resultadoBruto, out resultadoLiquido);

                // Call the service
                var retorno = this._CdbService.SolicitarCalculoInvestimento(investimento, meses).Result.Data;

                // If there is no data, the test fail
                if (retorno == null)
                    Assert.Fail();
                else
                    Assert.That(retorno.ResultadoBruto, !Is.EqualTo(resultadoBruto));
            }
        }
    }
}
