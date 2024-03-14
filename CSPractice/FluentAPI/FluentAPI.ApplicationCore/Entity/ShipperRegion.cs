namespace FluentAPI.ApplicationCore.Entity;

public class ShipperRegion
{
    public int Id { get; set; }
    public int RegionId { get; set; }
    public int ShipperId { get; set; }

    public Shipper Shipper { get; set; }
    public Region Region { get; set; }
}