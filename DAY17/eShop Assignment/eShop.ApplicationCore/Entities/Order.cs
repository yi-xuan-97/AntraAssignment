using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.ApplicationCore.Entities;

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int ShipperId { get; set; }
    [Column(TypeName = "money")]
    public decimal TotalAmount { get; set; }
    public DateTime OrderDate { get; set; }
    
    public Shipper Shipper { get; set; }
    public Customer Customer { get; set; }
}