using bogshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace bogshop.Controllers
{
  public class StudentController : Controller
  {
    public IActionResult Index()
    {
      TempData["Thongbao"] = "Gui du lieu qua temp data";
      return View();
    }

    public IActionResult Create(Student std)
    {
      // string message = std.StudentID + "-";
      // message += std.StudentName + "-";
      // message += std.Age;
      // ViewBag.Result = message;

      string message = TempData["Thongbao"].ToString();
      ViewBag.Result = message;
      return View();
    }
  }
}