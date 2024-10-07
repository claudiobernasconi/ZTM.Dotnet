var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsProduction())
{
    builder.Logging.SetMinimumLevel(LogLevel.Error);
}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

if (app.Environment.IsProduction())
{
    app.MapGet("/", (IHostEnvironment environment) => "Hello World!" + environment.EnvironmentName);
}

// Development - Development
// Production - Live Systems
// Staging - Testing


app.Run();
