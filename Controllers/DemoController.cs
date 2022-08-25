using Microsoft.AspNetCore.Mvc;

namespace bogshop.Controllers
{
  public class DemoController : Controller
  {
    public IActionResult Index(int a, int b)
    {
      if (a != 0)
      {
        ViewBag.Result = $"{a}x + {b} = 0 => x = {-b / a}";
      }
      return View();
    }
  }
}