using StockExchange.WebAPI.Services;
using StockExchange.WebAPI.Test.Helpers;

namespace StockExchange.WebAPI.Test.Services;

public class UT_ApplicationService
{
    private IApplicationService? _ApplicationService;

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestTimeZone()
    {
        // Load data
        var brasilianTimEZone = DataHelper.GetBrasilianTimeZone();

        // Do the tests
        Assert.That(brasilianTimEZone, Is.Not.Null);

        // Create the service
        this._ApplicationService = new ApplicationService();

        // Call the service
        var retorno = this._ApplicationService.TimeZone;

        // Do the tests
        Assert.Multiple(() =>
        {
            Assert.That(retorno, Is.Not.Null);
            Assert.That(retorno, Is.Not.Empty);
            Assert.That(retorno, Is.EqualTo(brasilianTimEZone.DisplayName));
        });
    }

    [Test]
    public void TestStartupTime()
    {
        // Create the service
        this._ApplicationService = new ApplicationService();

        // Call the service
        var retorno = this._ApplicationService.StartupTime;

        // Do the tests
        Assert.Multiple(() =>
        {
            Assert.That(retorno.ToString(), Is.Not.Empty);
            Assert.That(retorno.GetType(), Is.EqualTo(typeof(DateTime)));
            Assert.That(retorno, Is.LessThanOrEqualTo(DateTime.Now));
        });
    }

    [Test]
    public void TestFrameworkVersion()
    {
        // Create the service
        this._ApplicationService = new ApplicationService();

        // Call the service
        var retorno = this._ApplicationService.FrameworkVersion;

        // Do the tests
        Assert.Multiple(() =>
        {
            Assert.That(retorno, Is.Not.Null);
            Assert.That(retorno, Is.Not.Empty);
        });
    }    
}
