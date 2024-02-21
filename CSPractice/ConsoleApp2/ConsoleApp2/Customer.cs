namespace ConsoleApp2;

public class Customer
{

    public Customer(int id, string customerName, string email)
    {
        Id = id;
        CustomerName = customerName;
        Email = email;
    }

    public Customer(int id, string customerName, string email, string phone)
    {
        Id = id;
        CustomerName = customerName;
        Email = email;
        Phone = phone;
    }
    
    //full version property
    private int id;
    public int Id
    {
        private set
        {
            id = value;
        }
        get
        {
            return id;
        }
    }

    //auto-generated field - short form of the above
    public string CustomerName { get; set; }
    
    public string Email { get; set; }
    public string Phone { get; set; }
}