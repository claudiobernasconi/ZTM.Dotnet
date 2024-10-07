// value types
var rectangle = new Rectangle(200, 300);
Console.WriteLine($"rectangle height: {rectangle.Height}");

MethodParameters.ChangeHeight(ref rectangle);
Console.WriteLine($"rectangle height: {rectangle.Height}");
Console.WriteLine();

// reference types
var person = new Person("Claudio Bernasconi");
Console.WriteLine($"Name: {person.Name}");

MethodParameters.ChangeName(person);
Console.WriteLine($"Name: {person.Name}");

public class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}

public struct Rectangle
{
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Width { get; set; }
    public double Height { get; set; }
}

public class MethodParameters
{
    public static void ChangeName(Person person)
    {
        person.Name = "Unknown";
        // person = new Person("John Wayne");
    }

    public static void ChangeHeight(ref Rectangle rectangle)
    {
        rectangle.Height = 500;
        Console.WriteLine($"rectangle height in Method: {rectangle.Height}");
    }
}