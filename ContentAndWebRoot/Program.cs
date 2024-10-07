var options = new WebApplicationOptions
{
    Args = args,
    ContentRootPath = Directory.GetCurrentDirectory(),
    WebRootPath = Path.Combine(Directory.GetCurrentDirectory(), "web")
};

var builder = WebApplication.CreateBuilder(options);
var app = builder.Build();

app.MapGet("/", (HttpContext context) =>
{
    context.Response.ContentType = "text/html";
    return $"<p><b>Content Root:</b> {app.Environment.ContentRootPath}<br />" +
            $"<b>Web Root:</b> {app.Environment.WebRootPath}</p>";
});

app.Run();
