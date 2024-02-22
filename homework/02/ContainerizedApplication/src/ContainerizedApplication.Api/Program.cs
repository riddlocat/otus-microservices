var app = WebApplication.CreateBuilder(args).Build();

app.MapGet("/health", () => Results.Ok(new { Status = "OK" }));

app.Run();
