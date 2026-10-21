var person = new Person("Peter");
var person2 = new Person2("John");

var animal = new Animal("Cow");
Console.WriteLine(animal.Name);

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
}

// Primary Constructors (C# 12)
public class Person2(string name)
{
    public string Name { get; set; } = name;
}

// Record Types
public record Animal(string Name);