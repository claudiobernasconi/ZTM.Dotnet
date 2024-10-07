namespace MVCDataPassing.Models;

public class PersonViewModel
{
    private readonly Random _random = new Random();

    public PersonViewModel(int personId, string firstName, string lastName, IList<int> luckyNumbers)
    {
        PersonId = personId;
        FirstName = firstName;
        LastName = lastName;
        LuckyNumbers = luckyNumbers;
    }

    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IList<int> LuckyNumbers { get; set; }

    public int GetRandomLuckyNumber()
    {
        var index = _random.Next(0, LuckyNumbers.Count);
        return LuckyNumbers[index];
    }
}
