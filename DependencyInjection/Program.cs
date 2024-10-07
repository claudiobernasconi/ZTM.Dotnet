var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGreetings();

var app = builder.Build();

app.MapGet("/", (IGreetings greetings) => greetings.GetGreeting());

app.Run();

public interface IGreetings
{
    string GetGreeting();
}

public class Greetings : IGreetings
{
    public string GetGreeting()
    {
        return "Hello from a service!";
    }
}

public static class GreetingsServiceBuilderExtensions
{
    public static IServiceCollection AddGreetings(this IServiceCollection services)
    {
        services.AddScoped<IGreetings, Greetings>();

        return services;
    }
}