namespace RazorDependencyInjection.Services;

public class LuckyNumberService : ILuckyNumberService
{
    private readonly Random _random = new Random();

    public int GetMyLuckyNumber()
    {
        return _random.Next(1, 99);
    }
}
