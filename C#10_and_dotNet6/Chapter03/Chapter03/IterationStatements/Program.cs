using static System.Console;

//while loop
int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}

//do loop
// string? password;
// int attempts = 0;
// do
// {
//     Write("Enter your password: "); 
//     password = ReadLine();
//     attempts++;
//     if (attempts >= 10)
//     {
//         WriteLine("Error: Too many incorrect attempts.");
//         return;
//     }
// }
// while (password != "Pa$$w0rd");
// WriteLine("Correct!");

//for statement
for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

//foreach
string[] names = { "Adam", "Barry", "Charlie" };
foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}