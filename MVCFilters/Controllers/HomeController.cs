using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCFilters.Filters;
using MVCFilters.Models;

namespace MVCFilters.Controllers
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

        public IActionResult Todo()
        {
            return View();
        }

        [HttpPost]
        [ValidateModel]
        public IActionResult Create(TodoItem item)
        {
            return Ok($"Item '{item.Text}' created.");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
