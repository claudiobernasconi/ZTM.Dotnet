var person1 = new Person("Jack", 24, 19);
var person2 = new Person(name: "Jack", age: 24, luckyNumber: 19);
var person3 = new Person("Jack", luckyNumber: 19, age: 24);

public class Person
{
    public Person(string name, int age, int luckyNumber)
    {
        Name = name;
        Age = age;
        LuckyNumber = luckyNumber;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public int LuckyNumber { get; set; }
}