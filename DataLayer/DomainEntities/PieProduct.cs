namespace DataLayer.DomainEntities;

public class PieProduct
{
    public int Id { get; set; }
    public string ProductName { get; set; } = string.Empty;

    public string ProductDescription { get; set; } = string.Empty;
    public int ProductType { get; set; }
    double? ProductPrice { get; set; }
}