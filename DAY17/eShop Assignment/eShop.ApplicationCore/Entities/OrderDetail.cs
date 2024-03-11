using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.ApplicationCore.Entities;

public class OrderDetail
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    [Column(TypeName = "money")]
    public decimal UnitPrice { get; set; }
 
    public Product Product { get; set; }
    public Order Order { get; set; }
}