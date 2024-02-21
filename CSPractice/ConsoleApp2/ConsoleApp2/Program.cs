// See https://aka.ms/new-console-template for more information

using ConsoleApp2;

Console.WriteLine("Hello, World!");


Customer c1 = new Customer(1,"Smith","123@gmail.com");
Console.WriteLine($"The id number is {c1.Id}");

Customer c2 = new Customer(2, "Luara", "456@gmil.com", "1234567");
Console.WriteLine($"The phone number is {c2.Phone}");

FullTimeEmployee f1 = new FullTimeEmployee();
f1.PerformWork();

PartTimeEmployee p1 = new PartTimeEmployee();
p1.PerformWork();

Console.WriteLine(Addition.AddNumbers(1,2));
Console.WriteLine(Addition.AddNumbers(1.23d,2));
Console.WriteLine(Addition.AddNumbers(1,2,3));

int a = 3;
Console.WriteLine(a.EvenOrOdd());




