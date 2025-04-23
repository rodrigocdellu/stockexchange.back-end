// 2025/04/20 - Required for Dependency Injection (IoC)
using Microsoft.OpenApi.Models;
using StockExchange.WebAPI.Services;

// 2025/04/20 - Define the policy name
const string POLICYFORCORS = "StockExchangePolicy";

// Create the application builder
var builder = WebApplication.CreateBuilder(args);

// Add services to the container. Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers(); // 2025/04/20 - Add controllers for automatic mapping
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => { // 2025/04/20 - For Swagger to run in the production environment
    options.SwaggerDoc("v1", new OpenApiInfo{
        Version = "v1",
        Title = "StockExchange.WebAPI",
        Description = "For StockExchange usage",
        TermsOfService = new Uri("https://github.com/rodrigocdellu")
    });
});
builder.Services.AddSingleton<IApplicationService, ApplicationService>(); // 2025/04/22 - To deal with application information
builder.Services.AddTransient<ICDBService, CdbService>(); // 2025/04/22 - Add the Dependency Injection (IoC)

// 2025/04/20 - Add CORS with a policy
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

/* ToDo: 2025/04/20 - Maybe remove this later.
// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
*/

app.UseSwagger(); // 2025/04/20 - For Swagger to run in the production environment
app.UseSwaggerUI(); // 2025/04/20 - For Swagger to run in the production environment
app.UseCors(POLICYFORCORS); // 2025/04/20 - Use CORS with the policy created
app.MapControllers(); // 2025/04/20 - Map the application controllers

// Run the application
await app.RunAsync();
