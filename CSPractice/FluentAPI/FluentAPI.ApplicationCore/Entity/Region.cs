namespace FluentAPI.ApplicationCore.Entity;

public class Region
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<ShipperRegion> ShipperRegions { get; set; }
}