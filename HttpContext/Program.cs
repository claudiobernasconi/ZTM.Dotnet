var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext context) =>
{
    context.Response.StatusCode = 201;
    context.Response.ContentType = "text/html";

    return $"<h1>{context.Request.Path.Value}</h1><p>This is a test.</p>";
});

app.Run();
