Console.WriteLine("Enter your age: ");
string? input = Console.ReadLine();
int age = int.Parse(input ?? "0");

switch (age)
{
    case < 10:
        Console.WriteLine("You're a child.");
        break;
    case < 20:
        Console.WriteLine("You're a teenager.");
        break;
    case < 30:
        Console.WriteLine("You're a young adult.");
        break;
    case < 40:
        Console.WriteLine("You're an adult.");
        break;
    case < 50:
        Console.WriteLine("You're still an adult.");
        break;
    default:
        Console.WriteLine("You're a wise person.");
        break;
}

switch (age)
{
    case 10:
    case 20:
    case 30:
    case 40:
    case 50:
    case 60:
        Console.WriteLine("You just had a round birthday.");
        break;
    default:
        Console.WriteLine("You just had a normal birthday.");
        break;
}