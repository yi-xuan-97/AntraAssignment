namespace Assignment1;

public class NumSizeNRange
{
    public void OutputRange()
    {
        Console.WriteLine("{0,-10} {1,-15} {2,-25} {3,-25}", "Type", "Bytes", "Min Value", "Max Value");
        Console.WriteLine(new string('-', 75));

        PrintTypeInfo("sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        PrintTypeInfo("byte", sizeof(byte), byte.MinValue, byte.MaxValue);
        PrintTypeInfo("short", sizeof(short), short.MinValue, short.MaxValue);
        PrintTypeInfo("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        PrintTypeInfo("int", sizeof(int), int.MinValue, int.MaxValue);
        PrintTypeInfo("uint", sizeof(uint), uint.MinValue, uint.MaxValue);
        PrintTypeInfo("long", sizeof(long), long.MinValue, long.MaxValue);
        PrintTypeInfo("ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        PrintTypeInfo("float", sizeof(float), float.MinValue, float.MaxValue);
        PrintTypeInfo("double", sizeof(double), double.MinValue, double.MaxValue);
        PrintTypeInfo("decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
    }

    static void PrintTypeInfo(string typeName, int bytes, dynamic minValue, dynamic maxValue)
    {
        Console.WriteLine("{0,-10} {1,-15} {2,-25} {3,-25}", typeName, bytes, minValue, maxValue);
    }

    public void TimeOutput()
    {
        // Prompt the user to enter the number of centuries
        Console.Write("Enter number of centuries: ");
        if (!int.TryParse(Console.ReadLine(), out int centuries))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        // Convert centuries to years, days, hours, minutes, seconds, milliseconds, microseconds, and nanoseconds
        long years = centuries * 100;
        long days = years * 365;
        long hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        long milliseconds = seconds * 1000;
        long microseconds = milliseconds * 1000;
        long nanoseconds = microseconds * 1000;

        // Display the converted values
        Console.WriteLine($"Years: {years}");
        Console.WriteLine($"Days: {days}");
        Console.WriteLine($"Hours: {hours}");
        Console.WriteLine($"Minutes: {minutes}");
        Console.WriteLine($"Seconds: {seconds}");
        Console.WriteLine($"Milliseconds: {milliseconds}");
        Console.WriteLine($"Microseconds: {microseconds}");
        Console.WriteLine($"Nanoseconds: {nanoseconds}");
    }
}