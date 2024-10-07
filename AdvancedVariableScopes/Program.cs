Book book1 = new Book("Harry Potter and the Sorcerer’s Stone", "J.K. Rowling");
book1.PrintSummary();
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void PrintSummary()
    {
        string summary = $"{Title} - {Author}";
        Console.WriteLine(summary);
    }

    public int GetTitleLengthWithoutWhitespaces()
    {
        string titleWithoutWhitespaces = Title.Replace(" ", "");
        return titleWithoutWhitespaces.Length;
    }
}