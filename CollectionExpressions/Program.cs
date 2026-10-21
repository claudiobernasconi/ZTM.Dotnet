// Traditional Syntax (Before C# 12)
List<int> numbers = new List<int>();
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);

// Collection Initializers
List<int> numbers2 = new List<int>
{
    10, 20, 30
};

// Collection Expression Syntax (C# 12)
List<int> numbers3 = [10, 20, 30];


// Array Syntax (Before C# 12)
int[] numberArray = new int[] { 1, 2, 3 };

// Array Syntax (C# 12)
int[] numberArray2 = [1, 2, 3];


// Empty Collections (Before C# 12)
List<string> names = new List<string>();

// Empty Collections (C# 12)
List<string> names2 = [];


int[] first = [1, 2, 3];
int[] second = [4, 5, 6];

// Combining elements with LINQ (Before C# 12)
int[] combined = first
    .Concat(second)
    .Concat(new[] { 7 })
    .ToArray();

// Combining elements with the Spread operator (C# 12)
int[] combined2 = [.. first, .. second, 7];

// Result: 1, 2, 3, 4, 5, 6, 7


// Common Pitfalls

// 1.Collection expressions have no natural type

// Works: the declared type provides the target type.
int[] numbers4 = [1, 2, 3];

// Works: the method parameter provides the target type.
PrintNumbers([1, 2, 3]);

static void PrintNumbers(List<int> numbers)
{
    Console.WriteLine(numbers.Count);
}

// var numbers4 = [1, 2, 3]; // Compile-time error: There is no target type for the collection expression