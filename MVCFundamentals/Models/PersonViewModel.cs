using MVCFundamentals.Data;

namespace MVCFundamentals.Models;

public class PersonViewModel
{
    public string Name { get; set; }
    public int Age { get; set; }

    public PersonViewModel(Person person)
    {
        Name = $"{person.FirstName} {person.LastName}";
        Age = DateTime.Today.Year - person.DateOfBirth.Year;
    }
}
