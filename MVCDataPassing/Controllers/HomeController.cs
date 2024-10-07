using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCDataPassing.Models;

namespace MVCDataPassing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // View Model
        public IActionResult Person()
        {
            var person = new PersonViewModel(1, "Claudio", "Bernasconi", [7, 16, 21]);
            return View(person);
        }

        // ViewData
        public IActionResult Article()
        {
            ViewData["productName"] = "Bicycle";
            ViewData["price"] = 2699m;

            return View();
        }

        // ViewBag
        public IActionResult Quote()
        {
            ViewBag.ProgrammersQuote = "Code is like humor. When you have to explain it, it’s bad. – Cory House";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
