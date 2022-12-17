using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Title { get; }
    public string Description { get;  }
    public float Price { get; }
    public DateTime Date { get; }

    public Order(string title, string description, float price, DateTime date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
    }
    
  }
}