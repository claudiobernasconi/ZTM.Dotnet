Person person1 = new Person("Claudio");
Person person2 = new Person("John");

Console.WriteLine(person1.Name);
Console.WriteLine(person2.Name);

person1.PrintGreeting();
person2.PrintGreeting();

string greeting = person1.GetGreeting();
Console.WriteLine(greeting);

int result = Math.Sum(16, 14);
Console.WriteLine(result);
Console.WriteLine(Math.PI);

public class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }

    public void PrintGreeting()
    {
        Console.WriteLine($"Hello, {Name}!");
    }

    public string GetGreeting()
    {
        return $"Hello, {Name}!";
    }
}

public static class Math
{
    public static double PI
    {
        get { return 3.14d; }
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}