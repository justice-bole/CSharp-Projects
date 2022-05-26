using static System.Console;

int margin1 = -10;
int margin2 = 5;
int margin3 = 20;
int margin4 = 35;


WriteLine("------------------------------------------------------------------------------------------------------------");
WriteLine("{0, -10} {1, 21} {2, 19} {3, 35}", "Type", "Byte(s) of memory", "Min", "Max");
WriteLine("------------------------------------------------------------------------------------------------------------");
WriteLine("{0, -10} {1, 5} {2, 35} {3, 35}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
WriteLine("{0, -10} {1, 5} {2, 35} {3, 35}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
WriteLine("{0, -10} {1, 5} {2, 35} {3, 35}", "short", sizeof(short), short.MinValue, short.MaxValue);
WriteLine("{0, -10} {1, 5} {2, 35} {3, 35}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
WriteLine("{0, -10} {1, 5} {2, 35} {3, 35}", "int", sizeof(int), int.MinValue, int.MaxValue);
WriteLine("{0, -10} {1, 5} {2, 35} {3, 35}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
WriteLine("{0, -10} {1, 5} {2, 35} {3, 35}", "long", sizeof(long), long.MinValue, long.MaxValue);
WriteLine("{0, -10} {1, 5} {2, 35} {3, 35}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
WriteLine("{0, -10} {1, 5} {2, 35} {3, 35}", "float", sizeof(float), float.MinValue, float.MaxValue);
WriteLine("{0, -10} {1, 5} {2, 35} {3, 35}", "double", sizeof(double), double.MinValue, double.MaxValue);
WriteLine("{0, -10} {1, 6} {2, 34} {3, 35}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
WriteLine("------------------------------------------------------------------------------------------------------------");