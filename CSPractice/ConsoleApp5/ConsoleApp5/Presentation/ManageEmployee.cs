using ConsoleApp5.DataModel;
using ConsoleApp5.Repository;

namespace ConsoleApp5.Presentation;

public class ManageEmployee
{
    private EmployeeRepository _employeeRepository = new EmployeeRepository();

    private Employee Demo(Employee e)
    {
        return e;
    }
    private void SelectDemo()
    {
        //SELECT * FROM Employee
        //Query Syntax
        // var result = (from employee in _employeeRepository.GetEmployee()
        //     select employee);

        
        //Method Syntax
        //Lambda expression
        // var result = _employeeRepository.GetEmployee().Select(employee => employee);
        // var result = _employeeRepository.GetEmployee().Select(Demo);
       
        
        //Query Syntax
        // var result = from employee in _employeeRepository.GetEmployee()
        //     select employee.FullName;
        // var result = _employeeRepository.GetEmployee().Select(employee => employee.FullName);
        // foreach (var r in result)
        // {
        //     Console.WriteLine(r);
        // }
        
        //Query Syntax
        // var result = from employee in _employeeRepository.GetEmployee()
        //     select new
        //     {
        //         Id = employee.Id,
        //         FullName = employee.FullName,
        //         Department = employee.Department
        //     };
        
        //Method syntax
        // var result = _employeeRepository.GetEmployee().Select(employee => new
        // {
        //     Id = employee.Id,
        //     FullName = employee.FullName,
        //     Department = employee.Department
        // });
        //
        
        //Distinct
        //Query Syntax
        // var result = (from employees in _employeeRepository.GetEmployee()
        //     select employees.Department).Distinct();
        
        //Method Syntax
        // var result = _employeeRepository.GetEmployee().Select(employee => employee.Department).Distinct();
        //
        // foreach (var r in result)
        // {
        //     Console.WriteLine(r);
        // }
        
        
        //Method Syntax
        // var result = _employeeRepository.GetEmployee().Select(employee => new
        // {
        //     Id = employee.Id,
        //     FullName = employee.FullName,
        //     Department = employee.Department
        // }).FirstOrDefault(x=> x.Department=="fdsfds")??new
        // {
        //     Id = -1,
        //     FullName = "N/A",
        //     Department="N/A"
        // };

        var result = _employeeRepository.GetEmployee().Select(employee => new
        {
            Id = employee.Id,
            FullName = employee.FullName,
            Department = employee.Department
        }).SingleOrDefault(x => x.Department == "Marketing") ?? new
        {
            Id = -1,
            FullName = "N/A",
            Department = "N/A"
        };

        Console.WriteLine(result);

    }

    private void OrderByDemo()
    {
        //Query Syntax
        // var result = from employee in _employeeRepository.GetEmployee()
        //     orderby employee.Salary descending , employee.FullName descending 
        //     select new
        //     {
        //         Id = employee.Id,
        //         FullName = employee.FullName,
        //         Salary = employee.Salary
        //     };

        var result = _employeeRepository.GetEmployee().OrderByDescending(employee => employee.Salary).ThenByDescending(empployee => empployee.FullName).Select(employee => new
        {
            Id = employee.Id,
            FullName = employee.FullName,
            Salary = employee.Salary
        });
        foreach (var r in result)
        {
            Console.WriteLine(r);
        }
    }

    private void WhereDemo()
    {
        //Query Syntax
        // var result = from employee in _employeeRepository.GetEmployee()
        //     where employee.Salary > 7000
        //     select new
        //     {
        //         Id = employee.Id,
        //         FullName = employee.FullName,
        //         Salary = employee.Salary
        //     };
        
        //Method Syntax
        var result = _employeeRepository.GetEmployee().Where(employee => employee.Salary > 7000).Select(employee => new
        {
            Id = employee.Id,
            FullName = employee.FullName,
            Salary = employee.Salary
        });
        
        foreach (var r in result)
        {
            Console.WriteLine(r);
        }
        
        
    }

    private void QuantifierDemo()
    {
        //Method Syntax
        // var result = _employeeRepository.GetEmployee().All(employee => employee.Salary > 5000);
        var result = _employeeRepository.GetEmployee().Any(employee => employee.Salary > 5000);
        Console.WriteLine(result);
    }

    private void GroupByDemo()
    {
        //group employees bby their department name
        //Query Syntax
        // var result = from employee in _employeeRepository.GetEmployee()
        //     group employee by employee.Department;
        
        //Method Syntax
        var result = _employeeRepository.GetEmployee().GroupBy(employee => employee.Department);
        
        foreach (var r in result)
        {
            Console.WriteLine($"{r.Key} Department");
            foreach (var e in r)
            {
                Console.WriteLine($"Full Name: {r.Key}");
            }
        }

    }


    private void AggregationDemo()
    {
        //Method Syntax
        //Average salary of all employee
        // var result = _employeeRepository.GetEmployee().Average(x => x.Salary);
        // Console.WriteLine(result);
        
        //get average salary by eac department
        var result = _employeeRepository.GetEmployee().GroupBy(x => x.Department).Select(x => new
        {
            Department = x.Key,
            TotalSalary = x.Sum( employee => employee.Salary),
            AverageSalary = Math.Round(x.Average( employee => employee.Salary),2)
        });

        foreach (var r in result)
        {
            Console.WriteLine($"{r.Department} Department: {r.AverageSalary} ave and {r.TotalSalary} as total");
        }
    }
    
    /*
     * LINQ Pad
     * var result = Products.Where(p=>p.UnitPrice>10.Select(p=>new{
     * p.ProdcutName, p.UnitPrice
     * });
     * result.Dump();
     *
     * Inner join:
     * var result = from c in Customers join o in Orders on c.CustomerID equals o.CustomerID
     *      select new { c.CustomerID, c.ContactName, o.OrderDate);
     * result.Dump();
     *
     *
     * Left join: can not find any matching reocrd in Order table, then set it to null
       * var result = from c in Customers join o in Orders on c.CustomerID equals o.CustomerID intoCustomerOrders
     *              from co in customerOrders.DefaulIfEmply()
       *      select new { c.CustomerID, c.ContactName, o.OrderDate);
       * result.Dump();
     */


    private void PaginateDemo()
    {
        // Pagination parameters
        int pageSize = 2; // Number of items per page
        int pageNumber = 3; // Page number to retrieve (1-based index)

        // Perform pagination using Skip() and Take() methods
        var pageData = _employeeRepository.GetEmployee().Skip((pageNumber - 1) * pageSize).Take(pageSize).Select(employee => new
        {
            Id = employee.Id,
            FullName = employee.Id
        });

        // Display page data
        foreach (var item in pageData)
        {
            Console.WriteLine($"Name: {item.FullName}, ID: {item.Id} ");
        }
    }
    public void Run()
    {
        // SelectDemo();
        // OrderByDemo();
        // WhereDemo();
        QuantifierDemo();
        // GroupByDemo();
        // AggregationDemo();
        // PaginateDemo();
        
    }
    
}