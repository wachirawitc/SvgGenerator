using Microsoft.AspNetCore.Mvc;
using SvgGenerator.Models;
using System.Diagnostics;

namespace SvgGenerator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}