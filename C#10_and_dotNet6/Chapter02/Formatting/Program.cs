using static System.Console;

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

//number positional strings
WriteLine(
 format: "{0} apples costs {1:C}",
 arg0: numberOfApples,
 arg1: pricePerApple * numberOfApples);

WriteLine(
 format: "{0} apples costs {1:C}",
 arg0: numberOfApples,
 arg1: pricePerApple * numberOfApples);

//cleaner version of above
WriteLine("{0} apples costs {1:C}", numberOfApples, pricePerApple * numberOfApples);

string formatted = string.Format(
 format: "{0} apples costs {1:C}",
 arg0: numberOfApples,
 arg1: pricePerApple * numberOfApples);

//interporlated strings
WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

//interpolating constant strings
//**old way**
//private const string firstname = "Omar";
//private const string lastname = "Rudberg";
//private const string fullname = firstname + " " + lastname;

//**new way** only works when combining string contant values. doesnt work with other types, like numbers.
//private const string fullname = "{firstname} {lastname}";

//WriteToFile(formatted); // writes the string into a file

//format strings with alignment || { index [, alignment ] [ : formatString ] } || {1,6:N0}
string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine(
 format: "{0,-10} {1,6:N0}",
 arg0: "Name",
 arg1: "Count");

WriteLine(
 format: "{0,-10} {1,6:N0}",
 arg0: applesText,
 arg1: applesCount);

WriteLine(
 format: "{0,-10} {1,6:N0}",
 arg0: bananasText,
 arg1: bananasCount);

//getting text input

Write("Type your first name and press ENTER: ");
string? firstName = ReadLine();

Write("Type your age and press ENTER: ");
string? age = ReadLine();

WriteLine($"Hello {firstName}, you look good for {age}.");

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
 arg0: key.Key,
 arg1: key.KeyChar,
 arg2: key.Modifiers);
