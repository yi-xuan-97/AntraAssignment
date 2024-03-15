namespace eShop.ApplicationCore.Models;

public class OrderDetail
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int quantity { get; set; }
    public decimal price { get; set; }
    
    public Product Product { get; set; }
}