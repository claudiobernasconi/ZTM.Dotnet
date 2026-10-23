var todo = new PriorityQueue<string, int>();

todo.Enqueue("Take out trash", 3);
todo.Enqueue("Cook dinner", 1);
todo.Enqueue("Clean the kitchen", 2);

Console.WriteLine(todo.Dequeue()); // Cook dinner
Console.WriteLine(todo.Dequeue()); // Clean the kitchen
Console.WriteLine(todo.Dequeue()); // Take out trash
Console.WriteLine();


var schoolProject = new PriorityQueue<string, DateTime>();

schoolProject.Enqueue("Submit assignment", new DateTime(2026, 10, 25));
schoolProject.Enqueue("Research topics", new DateTime(2026, 10, 16));
schoolProject.Enqueue("Prepare presentation", new DateTime(2026, 10, 23));
schoolProject.Enqueue("Review notes", new DateTime(2026, 10, 24));

while (schoolProject.Count > 0)
{
    Console.WriteLine(schoolProject.Dequeue());
    // Research topics
    // Prepare presentation
    // Review notes
    // Submit assignment
}
Console.WriteLine();


var highestComparer = Comparer<int>.Create((a, b) => b.CompareTo(a));
var queue = new PriorityQueue<string, int>(highestComparer);

queue.Enqueue("Low", 1);
queue.Enqueue("Medium", 5);
queue.Enqueue("High", 10);

while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}

// High
// Medium
// Low
