namespace Assignment3;

public abstract class Person
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public List<string> Addresses { get; set; }

    // Calculate age of the person
    public int CalculateAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - DateOfBirth.Year;
        if (DateOfBirth > today.AddYears(-age)) age--;
        return age;
    }

    // Encapsulation: Private field for salary
    private decimal salary;

    // Encapsulation: Property for salary with validation
    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Salary cannot be negative.");
            salary = value;
        }
    }

    // Encapsulation: Method to get addresses
    public List<string> GetAddresses()
    {
        return Addresses;
    }

    // Polymorphism: Virtual method for calculating salary
    public virtual decimal Calculate()
    {
        return Salary;
    }
}