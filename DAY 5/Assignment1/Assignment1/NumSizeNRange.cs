namespace Assignment1;

public class NumSizeNRange
{
    public void OutputRange()
    {
        Console.WriteLine("Data Type\t\tBytes\t\tMin Value\t\tMax Value");

        Console.WriteLine($"sbyte\t\t\t{sizeof(sbyte)}\t\t{sbyte.MinValue}\t\t{sbyte.MaxValue}");
        Console.WriteLine($"byte\t\t\t{sizeof(byte)}\t\t{byte.MinValue}\t\t\t{byte.MaxValue}");
        Console.WriteLine($"short\t\t\t{sizeof(short)}\t\t{short.MinValue}\t\t{short.MaxValue}");
        Console.WriteLine($"ushort\t\t\t{sizeof(ushort)}\t\t{ushort.MinValue}\t\t\t{ushort.MaxValue}");
        Console.WriteLine($"int\t\t\t{sizeof(int)}\t\t{int.MinValue}\t\t{int.MaxValue}");
        Console.WriteLine($"uint\t\t\t{sizeof(uint)}\t\t{uint.MinValue}\t\t\t{uint.MaxValue}");
        Console.WriteLine($"long\t\t\t{sizeof(long)}\t\t{long.MinValue}\t\t{long.MaxValue}");
        Console.WriteLine($"ulong\t\t\t{sizeof(ulong)}\t\t{ulong.MinValue}\t\t\t{ulong.MaxValue}");
        Console.WriteLine($"float\t\t\t{sizeof(float)}\t\t{float.MinValue}\t\t{float.MaxValue}");
        Console.WriteLine($"double\t\t\t{sizeof(double)}\t\t{double.MinValue}\t\t{double.MaxValue}");
        Console.WriteLine($"decimal\t\t\t{sizeof(decimal)}\t\t{decimal.MinValue}\t\t{decimal.MaxValue}");
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