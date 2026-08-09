using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using twicher.Models;

namespace twicher.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
