namespace MVCFundamentals.Data;

public class PersonService : IPersonService
{
    public IEnumerable<Person> GetAll()
    {
        return [
            new Person(1, "John", "Doe", new DateTime(1967, 5, 26)),
            new Person(2, "Peter", "Jackson", new DateTime(1987, 4, 16))
        ];
    }
}
