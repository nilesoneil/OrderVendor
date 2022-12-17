namespace VendorOrder.Models;

public class Vendor
{
    public int id { get; }
    public List<Order> orders { get; set; }
    public string name { get; set; }
    public string description { get; set; }

    public Vendor()
    {
        this.id = (new Random()).Next(0, Int32.MaxValue);
        orders = new List<Order>();
    }
}