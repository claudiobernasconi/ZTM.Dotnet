var person1 = new Person("Jasmin");
Console.WriteLine(person1.Name);

Person? person2 = null;

if (person2 != null)
{
    Console.WriteLine(person2.Name);
}

Person? person3 = null;
Console.WriteLine(person3?.Name);
Console.WriteLine("The End.");

public class Person
{
    public Person(string firstName)
    {
        Name = firstName;
    }

    public string Name { get; set; }
}