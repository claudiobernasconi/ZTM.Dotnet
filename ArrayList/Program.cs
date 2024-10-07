using System.Collections;

var arrayList = new ArrayList();

var day = 22;
arrayList.Add(day);

var person1 = new Person("Andrew");
arrayList.Add(person1);

var firstElement = arrayList[0];
Console.WriteLine($"First Element: {firstElement}");

foreach (var item in arrayList)
{
    if (item is Person)
    {
        var person = item as Person;
        if (person != null)
        {
            Console.WriteLine(person.Name);
        }
    }
    else
    {
        Console.WriteLine(item);
    }
}

public class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}