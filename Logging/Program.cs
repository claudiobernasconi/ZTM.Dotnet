var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddDebug();

var app = builder.Build();

app.MapGet("/", (ILogger<Program> logger) =>
{
    logger.LogWarning("Default route executing...");
    return "Hello World!";
});

app.Logger.LogInformation("Env: " + app.Environment.EnvironmentName);

app.Run();
