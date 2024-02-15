using System.ComponentModel.DataAnnotations;

namespace DataLayer.DomainEntities;

public class Customer
{
    public int Id { get; set; }
    [StringLength(25)]
    public string FirstName { get; set; } =   string.Empty;
    [StringLength(25)]
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    [StringLength(100)]
    public string Address { get; set; } = string.Empty;
    [StringLength(15)]
    public string City { get; set; } = string.Empty;
    public Country CustomerCountry { get; set; } = new Country();
}