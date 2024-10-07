var animals = new List<string> { "Deer", "Sheep", "Cat", "Dog", "Bull", "Donkey", "Goat" };

foreach (var animal in animals.OrderBy(animal => animal))
{
    Console.WriteLine(animal);
}

Console.WriteLine();

foreach (var animal in animals.OrderByDescending(animal => animal))
{
    Console.WriteLine(animal);
}

Console.WriteLine();

var persons = new List<Person> {
    new Person("John", "Deer"),
    new Person("John", "Apple"),
    new Person("Tim", "Walters"),
    new Person("April", "Johnson"),
};

foreach (var person in persons.OrderBy(person => person.FirstName).ThenBy(person => person.LastName))
{
    Console.WriteLine($"{person.FirstName} {person.LastName}");
}

animals.Reverse();
foreach (var animal in animals)
{
    Console.WriteLine(animal);
}

record Person(string FirstName, string LastName);