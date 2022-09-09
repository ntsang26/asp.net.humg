using bogshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace bogshop.Controllers
{
  public class EmployeeController : Controller
  {
    public IActionResult Index(Employee emp)
    {
      string message = $"{emp.EmployeeID} - {emp.EmployeeName} - {emp.Address}";
      if (Convert.ToBoolean(emp.EmployeeID))
      {
        ViewBag.Result = message;
      }
      return View();
    }
  }
}