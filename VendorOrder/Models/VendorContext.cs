namespace VendorOrder.Models;

public class VendorContext
{
  public VendorContext() {
  }

  public static List<Vendor> Vendors = new List<Vendor>();

  public List<Vendor> GetAllVendors()
  {
    return Vendors.ToList();
  }

  public void AddToVendors(Vendor vendor)
  {
    Vendors.Add(vendor);
  } 

  public Vendor? GetVendorById(int id)
  {
    var theVendor= Vendors.Find(vendor=> vendor.id == id);
    return theVendor;
  }
}