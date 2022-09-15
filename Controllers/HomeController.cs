using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bogshop.Models;

namespace bogshop.Controllers;

public class HomeController : Controller
{
  public IActionResult Index(float a = 2, float b=5)
  {
    if (Convert.ToBoolean(a))
    {
      if (a != 0)
      {
        ViewBag.Result = $"Phương trình có nghiệm: x = {-b / a}";
      }
      else
      {
        ViewBag.Result = "Phương trình vô nghiệm!";
      }
    }
    return View();
  }

  public IActionResult Privacy()
  {
    return View();
  }

  public IActionResult Create()
  {
    return View();
  }
  [HttpPost]
  public IActionResult Create(string fullname)
  {
    string Message = "Hello " + fullname;
    ViewBag.Thongbao = Message;
    return View();
  }

}
