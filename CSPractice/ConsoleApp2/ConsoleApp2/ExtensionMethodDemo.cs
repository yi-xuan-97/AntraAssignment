namespace ConsoleApp2;
//1 static class itself
public static class ExtensionMethodDemo
{
    //2 static method
    //3 'this' before declare the type we want to extend
    public static string EvenOrOdd(this int num)
    {
        if (num % 2 == 0)
        {
            return "Even number";
        }

        return "Odd number";
    }
    
}