namespace Assignment3;

public class Instructor : Person
{
    public string Department { get; set; }
    public int YearsOfExperience { get; set; }
    public decimal BonusSalary { get; set; }

    // Polymorphism: Override method for calculating salary
    public override decimal Calculate()
    {
        // Bonus salary based on experience
        decimal bonus = YearsOfExperience * 1000;
        return base.Calculate() + bonus;
    }
}