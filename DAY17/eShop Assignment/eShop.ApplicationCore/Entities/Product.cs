using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.ApplicationCore.Entities;

public class Product
{
    public int Id { get; set; }
    [Required (ErrorMessage = "Product Name is required")]
    public string ProductName { get; set; }
    public int CatalogId { get; set; }
    [Column(TypeName = "money")]
    [Required(ErrorMessage = "Price is required")]
    public decimal UnitPrice { get; set; }
    public int UnitInStock { get; set; }
}