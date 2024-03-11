using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.ApplicationCore.Entities;

public class Promotion
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    [Column(TypeName = "money")]
    public decimal Discount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}