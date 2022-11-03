var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var configuration = (IConfiguration)app.Services.GetService(typeof(IConfiguration))!;

app.MapGet("/", () => $"Hello CI/CD! Value: {configuration.GetSection("test").Value}");

app.Run();
