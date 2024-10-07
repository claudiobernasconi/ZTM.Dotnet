var numberPrinter = new NumberPrinter();
numberPrinter.PrintNumbers(new int[] { 1, 2, 3 });
numberPrinter.PrintNumbers(4, 5, 6, 7);

public class NumberPrinter
{
    public void PrintNumbers(params int[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.Write($"{number} ");
        }
    }
}