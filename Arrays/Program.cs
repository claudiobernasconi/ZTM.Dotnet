var array1 = new int[4];

array1[0] = 7;
array1[1] = 16;
array1[2] = 21;
array1[3] = 27;

Console.WriteLine(array1);
Console.WriteLine(array1[0]);

//Array initializer
var array2 = new int[] { 7, 16, 21, 27 };

Console.WriteLine(array2);
Console.WriteLine(array2[0]);

//Alternative Syntax
int[] array3 = { 7, 16, 21, 27 };

Console.WriteLine(array3);
Console.WriteLine(array3[0]);

// Uninitialized elements
int[] array4 = new int[5];
Console.WriteLine(array4[0]);

Person[] persons = new Person[2];
persons[0] = new Person("John");
persons[1] = new Person("Jenna");

Console.WriteLine(persons);
var person0 = persons[0];
Console.WriteLine(person0.Name);

foreach (Person person in persons)
{
    Console.WriteLine(person.Name);
}

public class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}