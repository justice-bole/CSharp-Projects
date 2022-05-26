using static System.Console;
using System.Runtime.InteropServices;

DivideByZero(10.17);

void DivideByZero(double numberToDivide)
{
    double sum = numberToDivide / 0;
    WriteLine(sum);
}

unchecked
{
    WriteLine(int.MaxValue + 1);
}

int y = 0;
int y2 = 0;
int x = y++;
int x2 = ++y2;
WriteLine($"y++: {x}, ++y:{x2}");


int max = 500;
try
{
    checked
    {
        for (byte i = 0; i < max; i++)
        {
            WriteLine(i);
        }
    }
}
catch (OverflowException)
{
    WriteLine("An overflow exception occured");
}
catch(Exception ex)
{
    WriteLine($"{ex.GetType()} occured: {ex.Message}");
}

int w = 3;
int z = 2 + ++w;
WriteLine($"{z}");

