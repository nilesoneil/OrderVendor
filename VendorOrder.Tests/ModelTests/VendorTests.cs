using VendorOrder.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendorOrder.Tests.ModelTests;

[TestClass]
public class VendorContextTest
{
    [TestMethod]
    public void VendorContext_CreatesInstanceOfVendor_AddsVendor()
    {
        VendorContext vc = new VendorContext();
        Vendor v = new Vendor();
        vc.AddToVendors(v);

        List<Vendor> otherV = vc.GetAllVendors();
        Assert.AreEqual(1, otherV.Count);
    }

    [TestMethod]
    public void VendorContext_FindsVendorById_GetVendorById()
    {
        VendorContext vc = new VendorContext();
        Vendor v = new Vendor();
        vc.AddToVendors(v);

        Vendor otherV = vc.GetVendorById(v.id);
        Assert.AreSame(v, otherV);
    }
    [TestMethod]
    public void VendorModel_CanAddOrder()
    {
        Vendor v = new Vendor
        {
            description = "GOOD BAKERY"
        };

        Order o = new Order()
        {
            Title = "Some Order"
        };
        
        v.orders.Add(o);
        
        Assert.AreEqual(1, v.orders.Count);
    }
    [TestMethod]
    public void VendorModel_CanAddOrderAndReturnSameOrder()
    {
        Vendor v = new Vendor
        {
            description = "GOOD BAKERY"
        };

        Order o = new Order()
        {
            Title = "Some Order"
        };
        
        v.orders.Add(o);
        
        Assert.AreSame(v.orders[0], o);
    }
}