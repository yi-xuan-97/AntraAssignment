namespace ConsoleApp2;

public abstract class Employee
{
    public Employee()
    {
        
    }
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Addesss { get; set; }

    //can be overwritten by derive classes to override
    public abstract void PerformWork();
    //has to be overwriten in derived class
    
    
}

public class FullTimeEmployee : Employee
{
    //decimal: when working with money
    public decimal BiweeklyPay { get; set; }
    public string Benifit { get; set; }
    
    public override void PerformWork()
    {
        Console.WriteLine("Full time employees work 40 hours a week");
    }
}

public sealed class PartTimeEmployee : Employee
{
    public decimal HourlyPay { get; set; }

    public override void PerformWork()
    {
        Console.WriteLine("Full time employees work 20 hours a week");

    }
}

public class Manager : FullTimeEmployee
{
    public decimal ExtraBonus { get; set; }

    public void AttendMeeting()
    {
        Console.WriteLine("Managers have to attend meetings");
    }
}



















