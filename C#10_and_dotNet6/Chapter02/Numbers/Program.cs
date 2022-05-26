// unsigned int means positive whole num or 0
uint naturalNumber = 23;

//int means negative or positive whole num or 0
int integerNumber = -23;

//flaot means single-precision floating point
//f suffix makes it a float literal
float realNumber = 2.3f;

//double means double-precision floating point
double anotherRealNumber = 2.3; //double literal

//three variables that store the num 2 million
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

//check the three variables have the same value
// boths statements output true
Console.WriteLine($"{ decimalNotation == binaryNotation }");
Console.WriteLine($"{ decimalNotation == hexadecimalNotation }");

Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
Console.WriteLine($"doubles uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;

if(a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
}

Console.WriteLine("Using decimals:");
decimal c = 0.1m;
decimal d = 0.2m;

if (c + d == 0.3m)
{
    Console.WriteLine($"{c} + {d} equals {0.3m}");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal {0.3m}");
}
