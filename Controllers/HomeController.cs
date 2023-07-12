using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers;

public class HomeController : Controller
{
   public IActionResult returnName()
    {
        string name = "Utshav Khatiwada";
        return Json(new { name });
    }
}
