// 2025/02/20 - Required for Dependency Injection (IoC)
using StockExchange.WebAPI.Service;

// 2025/02/20 - Define the policy name
const string POLICYFORCORS = "StockExchangePolicy";

// Create the application builder
var builder = WebApplication.CreateBuilder(args);

// Add services to the container. Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers(); // 2025/02/20 - Add controllers for automatic mapping
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IContentService, ContentService>(); // 2025/02/20 - Add the Dependency Injection (IoC)

// 2025/02/20 - Add CORS with a policy
builder.Services.AddCors(options =>
{
    options.AddPolicy(POLICYFORCORS, policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Build the application
var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(POLICYFORCORS); // 2025/02/20 - Use CORS with the policy created
app.MapControllers(); // 2025/02/20 - Map the application controllers

/* ToDo: 2025/02/20 - Remove this later.
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();
*/

// Run the application
app.Run();

/* ToDo: 2025/02/20 - Remove this later.
record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
*/
