// Implicit conversions: No special syntax, no data loss, no precision loss
// Explicit conversions: Castings, potential data loss, potential precision loss

int age = 31;
float weight = 78.7f;

Console.WriteLine($"age: {age}, weight: {weight}");

//implicit conversions
long myAge = age;

// explicit conversions
int lessWeight = (int)weight; // precission loss
int notMyAge = (int)myAge; // no pression loss

long bigNumber = 1111111111111111111;
int smallerType = (int)bigNumber;

Console.WriteLine(smallerType);