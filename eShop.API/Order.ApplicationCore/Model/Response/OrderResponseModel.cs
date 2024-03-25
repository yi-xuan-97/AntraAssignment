namespace Order.ApplicationCore.Model.Response;

public class OrderResponseModel
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public List<int> ProductIds { get; set; }
    public int ShipperId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalPrice { get; set; }
}