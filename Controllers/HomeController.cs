using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bogshop.Models;

namespace bogshop.Controllers;

public class HomeController : Controller
{
  public IActionResult Index()
  {
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
