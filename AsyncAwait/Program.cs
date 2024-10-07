Console.WriteLine("Program started.");

await LongRunningTaskAsync();
var number = await Calculate();
Console.WriteLine(number);

Console.WriteLine("Program finished.");

async Task LongRunningTaskAsync()
{
    Console.WriteLine("  Task starting...");
    await Task.Delay(5000);
    Console.WriteLine("  Task completed.");
}

async Task<int> Calculate()
{
    await Task.Delay(2000);
    return 42;
}