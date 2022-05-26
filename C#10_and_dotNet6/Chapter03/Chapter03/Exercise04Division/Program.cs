using static System.Console;

int min = 0;
int max = 255;
WriteLine($"Enter a number between {min} and {max}: ");
string? number01 = ReadLine();
WriteLine($"Enter another number between {min} and {max}: ");
string? number02 = ReadLine();
try
{
    if (number01 != null && number02 != null)
    {
        int answer = int.Parse(number01) / int.Parse(number02);
        WriteLine($"{number01} divided by {number02} is {answer}");
    }
    else
    {
        WriteLine("At least one input is null.");
    }
}
catch (OverflowException)
{
    WriteLine("Your age is a valid number format but it is either too big or small.");
}
catch (FormatException)
{
    WriteLine("FormatException: Input string was not in the correct format.");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}



