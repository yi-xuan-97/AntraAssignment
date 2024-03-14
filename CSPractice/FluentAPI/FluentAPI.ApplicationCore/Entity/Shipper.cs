namespace FluentAPI.ApplicationCore.Entity;

public class Shipper
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string EmailId { get; set; }
    public string Phone { get; set; }
    public string ContactPerson { get; set; }

    public ICollection<ShipperRegion> ShipperRegions { get; set; }
}