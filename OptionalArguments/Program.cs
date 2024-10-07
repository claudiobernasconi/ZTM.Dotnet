var person1 = new Person("John", 21);
Console.WriteLine(person1.LuckyNumber);

var person2 = new Person("Mandy", age: 25, luckyNumber: 16);
var person3 = new Person("Jessica", age: 29, favoriteColor: "red");

public class Person
{
    public Person(string name, int age, int luckyNumber = 7, string favoriteColor = "blue")
    {
        Name = name;
        Age = age;
        LuckyNumber = luckyNumber;
        FavoriteColor = favoriteColor;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public int LuckyNumber { get; set; }
    public string FavoriteColor { get; set; }
}