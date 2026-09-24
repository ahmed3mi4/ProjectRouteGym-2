using Microsoft.AspNetCore.Mvc;
using ProjectRouteGym.Models;
using System.Diagnostics;

namespace ProjectRouteGym.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
