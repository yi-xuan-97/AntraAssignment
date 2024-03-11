using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.ApplicationCore.Entities;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public int CatalogId { get; set; }
    [Column(TypeName = "money")]
    public decimal UnitPrice { get; set; }
    public int UnitInStock { get; set; }
}