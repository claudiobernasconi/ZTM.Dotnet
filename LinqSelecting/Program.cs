var persons = new List<Person>
{
    new Person("John", "Miller", 27),
    new Person("Jack", "Stevens", 41),
    new Person("Maria", "Mc Allister", 29),
    new Person("Christopher", "Collum", 36),
    new Person("Javier", "Alegro", 34)
};

var lastNames = persons.Select(person => person.LastName);

foreach (var lastName in lastNames)
{
    Console.WriteLine(lastName);
}

var ageBetween20and30 = persons
    .Where(person => person.Age >= 20 && person.Age <= 30)
    .Select(person => person.Age);

foreach (var age in ageBetween20and30)
{
    Console.WriteLine(age);
}

Console.WriteLine();

var firstPerson = persons.FirstOrDefault();
Console.WriteLine(firstPerson.FirstName);

foreach (var person in persons.Skip(1).Take(2))
{
    Console.WriteLine(person.FirstName);
}


record Person(string FirstName, string LastName, int Age);