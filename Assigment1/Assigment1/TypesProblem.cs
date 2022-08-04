namespace Assigment1;
// outputs the number of bytes in memory that each of the following number types uses, and the
//     minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
// ulong, float, double, and decimal.
public class TypesProblem
{
    public void Type()
    {
        Console.WriteLine("{0,-10}{1,-10}{2,-35}{3,-35}\n", "Type", "Bytes", "Min Value", "Max Value");
        Console.WriteLine("{0,-10}{1,-10}{2,-35}{3,-35}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("{0,-10}{1,-10}{2,-35}{3,-35}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0,-10}{1,-10}{2,-35}{3,-35}", "short", sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("{0,-10}{1,-10}{2,-35}{3,-35}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("{0,-10}{1,-10}{2,-35}{3,-35}", "int", sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("{0,-10}{1,-10}{2,-35}{3,-35}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("{0,-10}{1,-10}{2,-35}{3,-35}", "long", sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine("{0,-10}{1,-10}{2,-35}{3,-35}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("{0,-10}{1,-10}{2,-35}{3,-35}", "float", sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine("{0,-10}{1,-10}{2,-35}{3,-35}", "double", sizeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine("{0,-10}{1,-10}{2,-35}{3,-35}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
    }
    
}