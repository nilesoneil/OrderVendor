using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Title { get; }
    public string Description { get;  }
    public float Price { get; }
    public string Date { get; }

    public Order(string title, string description, float price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
    }
    
  }
}