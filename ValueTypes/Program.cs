//bool - boolean
bool enabled = false;
Console.WriteLine($"bool: {enabled}");

enabled = true;
Console.WriteLine($"bool: {enabled}");

char c1 = 'a';
Console.WriteLine($"char: {c1}");

//int
int a = 0;
int b = 5;
int c = -7;

Console.WriteLine($"a: {a}, b: {b}, c: {c}");

//arithmetic operations

int multiply = b * c;
int divide = c / b;
int add = a + b;
int subtract = a - b;
Console.WriteLine($"multiply: {multiply}, divide: {divide}, add: {add}, subtract: {subtract}");

//long
long i = 99;
Console.WriteLine($"long: {i}");

//floating point number types
float f = 3.5f; //float - single precision (32-bit) floating point number
double g = 7.8d; //double - double precision (64-bit) floating point number
decimal dec = 7.15m; //decimal - high precision (128-bit) smaller range floating point number

Console.WriteLine($"f: {f}, g: {g}, dec: {dec}");

Console.WriteLine($"float calculation: {1.1111111f / 0.8324234f}");
Console.WriteLine($"double calculation: {1.1111111d / 0.8324234d}");
Console.WriteLine($"decimal calculation: {1.1111111m / 0.8324234m}");

//copying values
int a1 = 7;
int a2 = a1;
a1 = 5;
Console.WriteLine($"a1: {a1}, a2: {a2}");

//Nullable value types
int? i1 = null;
bool? b1 = null;
Console.WriteLine($"int?: {i1}, bool?: {b1}");
