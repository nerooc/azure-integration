var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "FAILING TEST!");

app.Run();
