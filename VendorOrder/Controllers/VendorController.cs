using VendorOrder.Models;
using Microsoft.AspNetCore.Mvc;

namespace VendorOrder.Controllers;

public class VendorController : Controller
{
  private readonly VendorContext _db;
  public VendorController(VendorContext ctx)
  {
    _db = ctx;
  }

  [Route("vendor")]
  public IActionResult Index()
  {
    return View(_db.GetAllVendors());
  }
  [Route("Vendor/{vendorId}")]
  public IActionResult Details(int vendorId)
  {
    Vendor vendor = _db.GetVendorById(vendorId);
    if (vendor != null)
    {
      return View(vendor);
    }
    return NotFound();
  }

  [Route("vendor/{vendorId}/order")]
  public IActionResult GetOrders(int vendorId)
  {
    Vendor vendor = _db.GetVendorById(vendorId);
    if (vendor != null)
    {
      return View(vendor);
    }
    return NotFound();
  }

  [HttpPost]
  public IActionResult Create(Vendor vendor)
  {
    _db.AddToVendors(vendor);
    return RedirectToAction("Index");
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  [Route("vendor/{vendorId}/order")]
  public IActionResult CreateOrder(int vendorId, Order order)
  {
    Vendor vendor = _db.GetVendorById(vendorId);
    if (vendor == null)
    {
      return NotFound();
    }
    vendor.orders.Add(order);
    return Ok();
  }
}