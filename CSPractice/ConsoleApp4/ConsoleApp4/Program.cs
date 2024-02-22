

using ConsoleApp4;

// MathDelegate mathDelegate = new MathDelegate(ArithmeticOperation.Subtract);
// Console.WriteLine(mathDelegate(40,10));


PredefinedDelegate predefinedDelegate = new PredefinedDelegate();
// predefinedDelegate.ActionExample();
// predefinedDelegate.PredicateDemo();
// predefinedDelegate.FuncDemo();


// var person = new
// {
//     Name = "Smith",
//     Age = 30
// };

ExceptionHadling exceptionHadling = new ExceptionHadling();
try
{
    Console.WriteLine("Enter first number");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter operation");
    string o = Console.ReadLine();

    Console.WriteLine(exceptionHadling.Calculate(num1, num2, o));
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}





