using ConsoleApp5.DataModel;

namespace ConsoleApp5.Repository;

public class EmployeeRepository
{
    public new List<Employee> GetEmployee()
    {
        return new List<Employee>
        {
            new Employee() { Id = 1, FullName = "Scott", City = "Sterling", Department = "IT", Salary = 5500 },
            new Employee() { Id = 2, FullName = "Peter", City = "Sterling", Department = "HR", Salary = 4500 },
            new Employee() { Id = 3, FullName = "Laura", City = "Leesburg", Department = "IT", Salary = 6500 },
            new Employee() { Id = 4, FullName = "David", City = "Chicago", Department = "IT", Salary = 5000 },
            new Employee() { Id = 5, FullName = "Tracy", City = "Chicago", Department = "HR", Salary = 5000 },
            new Employee() { Id = 6, FullName = "Fiona", City = "Sterling", Department = "Marketing", Salary = 7500 }
        };
    }
}