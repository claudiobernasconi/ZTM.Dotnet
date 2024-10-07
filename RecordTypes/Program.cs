var person1 = new Person("Peter", "Parker");
var person2 = new Person("Peter", "Parker 2");

if (person1 == person2)
{
    Console.WriteLine("Persons are equal");
}

// person1.FirstName = "a";

public record Person(string FirstName, string LastName);

public record Employee() : Person("First", "Last");