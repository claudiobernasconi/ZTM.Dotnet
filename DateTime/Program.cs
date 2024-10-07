using System.Globalization;

DateTime dateOfBirth = new DateTime(1990, 9, 21);
Console.WriteLine(dateOfBirth.DayOfWeek);

// Computed Values
DateTime today = DateTime.Today;
DateTime now = DateTime.Now;
DateTime utcNow = DateTime.UtcNow;

// DateTime Parsing
DateTime localDate = DateTime.Parse("21.09.1990");
DateTime usDate = DateTime.Parse("09/21/1990", new CultureInfo("en-US"));

Console.WriteLine($"localDate: {localDate}, usDate: {usDate}");

// DateTime Formatting
Console.WriteLine(dateOfBirth.ToString());
Console.WriteLine(dateOfBirth.ToString(new CultureInfo("en-US")));
Console.WriteLine(dateOfBirth.ToString("yyyy-MM-dd"));
