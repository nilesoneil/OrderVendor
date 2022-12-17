using VendorOrder.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendorOrder.Tests.ModelTests;

[TestClass]
public class VendorContextTest
{
    [TestMethod]
    public void VendorContext_AddsVendor()
    {
        VendorContext vc = new VendorContext();
        Vendor v = new Vendor();
        vc.AddToVendors(v);

        Vendor otherV = vc.GetVendorById(v.id);
        Assert.AreSame(v, otherV);
    }
}