using VendorOrder.Models;
using Microsoft.AspNetCore.Mvc;

namespace VendorOrder.Controllers;

public class VendorController : Controller
{
    private readonly ILogger<VendorController> _logger;
    private readonly VendorContext _db;
    public VendorController(ILogger<VendorController> logger, VendorContext ctx)
    {
        _logger = logger;
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
        var vendor = _db.GetVendorById(vendorId);
        if (vendor != null)
        {
            return View(vendor);
        }
        return NotFound();
    }

    [HttpPost]
    [Route("vendor/create")]
    public IActionResult Create(Vendor vendor)
    {
        _db.AddToVendors(vendor);
        return RedirectToAction("Index");    
    }

    [Route("vendor/create")]
    public ActionResult Create()
    {
        return View();
    }
    
    [Route("vendor/{vendorId}/order")]
    public ActionResult CreateOrder(int vendorId)
    {
        ViewBag.vendorId = vendorId;
        return View();
    }

    [HttpPost]
    [Route("vendor/{vendorId}/order")]
    public IActionResult CreateOrder(int vendorId, Order order)
    {
        var vendor = _db.GetVendorById(vendorId);
        if (vendor == null)
        {
            return NotFound();
        }
        vendor.orders.Add(order);
        return RedirectToAction("Details", new {vendorId = vendorId});  
    }
}