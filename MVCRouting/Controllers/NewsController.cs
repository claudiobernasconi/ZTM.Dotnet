using Microsoft.AspNetCore.Mvc;

namespace MVCRouting.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Article(string article)
        {
            return View();
        }
    }
}
