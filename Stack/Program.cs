var countries = new Stack<string>();

countries.Push("Switzerland");
countries.Push("Germany");
countries.Push("Ireland");
countries.Push("United States of America");

var lastCountry = countries.Pop();
Console.WriteLine($"The last visited country was: {lastCountry}");

var previouslyListedCountry = countries.Peek();
Console.WriteLine($"The previously visited country was: {previouslyListedCountry}");

foreach (var country in countries)
{
    Console.WriteLine(country);
}