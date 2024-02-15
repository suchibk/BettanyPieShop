namespace DataLayer.DomainEntities;

public class Order
{
    public int Id { get; set; }
    public IEnumerable<OrderDetail> OrderDetails { get; set; } = Enumerable.Empty<OrderDetail>();
    public Customer Customer { get; set; } = new Customer();
}