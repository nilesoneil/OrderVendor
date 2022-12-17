using Microsoft.AspNetCore.Mvc;

namespace VendorOrder.Controllers;

public class HomeController : Controller
{
  
  public HomeController()
  {
    
  }

  public IActionResult Index()
  {
    return View();
  }
}