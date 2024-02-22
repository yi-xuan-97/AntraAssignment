using ConsoleApp3.DataModel;
using ConsoleApp3.Repositories;

namespace ConsoleApp3.Presentation;

public class ManageCustomer
{
    //underscore make the variable internal/private
    private CustomerRepository _customerRepository = new CustomerRepository();

    public void AddCustomer()
    {
        Customer c = new Customer();
        Console.WriteLine("Enter your id: ");
        c.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your Name: ");
        c.Name = Console.ReadLine();
        Console.WriteLine("Enter your Email: ");
        c.Email = Console.ReadLine();
        if (_customerRepository.Insert(c) == 1)
        {
            Console.WriteLine("Add Succeed");
        }
        else
        {
            Console.WriteLine("Error occur");
        }
    }

    private void PrintAllCustomer()
    {
        List<Customer> customers = _customerRepository.GetAll();
        foreach (var customer in customers)
        {
            Console.WriteLine(customer.Id + "\t" + customer.Name + "\t" + customer.Email);
        }
    }

    private void DeleteCustomer()
    {
        Console.WriteLine("Enter id to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());
        if (_customerRepository.Delete(id) == 1)
        {
            Console.WriteLine("Cutomer deleted");
        }
        else
        {
            Console.WriteLine("Error occur");
        }
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Press 1  to add");
        Console.WriteLine("Press 2  to read all info");
        Console.WriteLine("Press 3  to delete");
        Console.WriteLine("Press 9  to exit");
        Console.WriteLine("Enter choise ===>  ");
        int choice = Convert.ToInt32(Console.ReadLine());
        while (choice != 9)
        {
            switch (choice)
            {
                case 1:
                    AddCustomer();
                    break;
                case 2:
                    PrintAllCustomer();
                    break;
                case 3:
                    DeleteCustomer();
                    break;
                default:
                    Console.WriteLine("Invalid options");
                    break;
            }

            Console.WriteLine("Enter choise ===>  ");
            choice = Convert.ToInt32(Console.ReadLine());
        }
    }
}