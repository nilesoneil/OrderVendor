namespace VendorOrder.Models;

public class VendorOrder
{
  public int id {get; }
  public List<Order> orders;
  public string name;
  public string description;

  public Vendor(string name, string description)
  {
    this.id (new Random()).Next(0, int32.MaxValue);
    this.name = name;
    this.description = description;
    this.orders = new List<Order>();
  }
}