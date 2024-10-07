var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Route template
app.MapGet("/{name?}", (string? name) => $"Hello World, {name}!");

app.Run();
