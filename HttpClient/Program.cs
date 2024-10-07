var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
builder.Services.AddHttpClient("Jokes", httpClient =>
{
    httpClient.BaseAddress = new Uri("https://official-joke-api.appspot.com/jokes/programming");
});

var app = builder.Build();

app.MapGet("/", async (IHttpClientFactory httpClientFactory, HttpContext httpContext) =>
{
    var httpClient = httpClientFactory.CreateClient();
    var apiUrl = "https://official-joke-api.appspot.com/jokes/programming/random";
    var response = await httpClient.GetAsync(apiUrl);
    var jokes = await response.Content.ReadFromJsonAsync<Joke[]>();

    httpContext.Response.ContentType = "text/html";

    var joke = jokes?.Single();
    return $"<h1>{joke?.Setup}</h1><p>{joke?.Punchline}</p>";
});

app.MapGet("/top10", async (IHttpClientFactory httpClientFactory, HttpContext httpContext) =>
{
    var httpClient = httpClientFactory.CreateClient("Jokes");
    var response = await httpClient.GetAsync("ten");
    var jokes = await response.Content.ReadFromJsonAsync<Joke[]>();

    httpContext.Response.ContentType = "text/html";

    var jokesHtml = string.Join("", jokes?.Select(joke => $"<li>{joke.Setup} {joke.Punchline}</li>") ?? [""]);
    return $"<h1>Top 10 Jokes</h1><ul>{jokesHtml}</ul>";
});

app.Run();

public record Joke(string Type, string Setup, string Punchline);