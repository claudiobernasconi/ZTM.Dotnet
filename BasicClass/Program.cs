Person person1 = new Person("Claudio");
Person person2 = new Person("John");

Console.WriteLine(person1.Name);
Console.WriteLine(person2.Name);

person1.PrintGreeting();
person2.PrintGreeting();

string greeting = person1.GetGreeting();
Console.WriteLine(greeting);

Math math = new Math();
int result = math.Sum(14, 16);
Console.WriteLine(result);

class Person
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

public class Math
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
}