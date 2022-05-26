using static System.Console;

for (int i = 0; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        WriteLine("Buzz");
    }
    else
    {
        WriteLine(i);
    }
}
int a = 1;
int b = 2;
WriteLine($"A:{a}, B:{b}");
WriteLine();
int c = a;
a = b;
b = c;
WriteLine($"A:{a}, B:{b}");


