var messages = new Queue<string>();

messages.Enqueue(".NET is awesome!");
messages.Enqueue("C# is a great programming language!");
messages.Enqueue("You are a great student!");

while (messages.Count > 0)
{
    var message = messages.Dequeue();
    Console.WriteLine(message);
}