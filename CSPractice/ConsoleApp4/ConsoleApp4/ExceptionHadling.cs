namespace ConsoleApp4;

public class ExceptionHadling
{
    public int Divide(int number, int diviser)
    {
        return number / diviser;
    }

    public int Calculate(int num1, int num2, string operation)
    {
        if (operation == "/")
        {
            return Divide(num1, num2);
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }
}