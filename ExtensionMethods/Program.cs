using ExtensionMethods.Extensions;

var person = new Person("Jack", "Miller");
Console.WriteLine(person.ToFullName());
Console.WriteLine(person.HasId());

public interface IIdentification
{
    int Id { get; }
}

public static class IdentificationExtensions
{
    public static bool HasId(this IIdentification identification)
    {
        return identification.Id > 0;
    }
}

public class Person : IIdentification
{
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int Id
    {
        get
        {
            return 7;
        }
    }
}