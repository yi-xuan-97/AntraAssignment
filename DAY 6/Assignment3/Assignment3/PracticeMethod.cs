namespace Assignment3;

public class PracticeMethod
{
    public int[] GenerateNumbers(int length)
    {
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = i + 1; // Populate the array with consecutive numbers starting from 1
        }

        return numbers;
    }

    // Method to reverse the contents of the array
    public void Reverse(int[] numbers)
    {
        int length = numbers.Length;
        for (int i = 0; i < length / 2; i++)
        {
            (numbers[i], numbers[length - i - 1]) = (numbers[length - i - 1], numbers[i]);
        }
    }

    // Method to print the contents of the array
    public void PrintNumbers(int[] numbers)
    {
        Console.WriteLine("Reversed Array:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }

    public int Fibonacci(int n)
    {
        // Base cases: if n is 1 or 2, return 1
        if (n == 1 || n == 2)
        {
            return 1;
        }
        // Recursive case: Fibonacci(n) = Fibonacci(n - 1) + Fibonacci(n - 2)
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}