var grades = new Dictionary<int, string>
{
    { 6, "Perfect" }
};

grades.Add(5, "Good");
grades[4] = "Okay";
grades[3] = "Almost";
grades[2] = "Bad";
grades[1] = "Worse";

Console.WriteLine(grades[4]);

foreach (var grade in grades)
{
    Console.WriteLine($"{grade.Key}: {grade.Value}");
}

Console.WriteLine(grades.ContainsKey(7));

// grades.Remove(2);

grades.TryGetValue(6, out var value);
Console.WriteLine(value);