namespace BlazorDependencyInjection.Services;

public class GreetingService : IGreetingService
{
    public string GetGreeting()
    {
        return "Welcome to your new app.";
    }
}
