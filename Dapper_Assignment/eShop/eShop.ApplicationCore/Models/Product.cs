namespace eShop.ApplicationCore.Models;

public class Product
{
    public int Id { get; set; }
    public string name { get; set; }
    public int category_id { get; set; }
    public decimal price { get; set; }
    public string description { get; set; }
}