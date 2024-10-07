// Console.WriteLine()

Account account1 = new Account("John");
Account account2 = new Account("Peter", 20);

Console.WriteLine(account1);
Console.WriteLine(account2);

public class Account
{
    public decimal Balance { get; set; }
    public string Owner { get; set; }

    public Account(string owner)
    {
        Owner = owner;
        Balance = 0;
    }

    public Account(string owner, decimal balance)
    {
        Owner = owner;
        Balance = balance;
    }
}