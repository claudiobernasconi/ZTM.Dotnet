using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorForms.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Username { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnPost()
        {
            Username = Request.Form["username"];
        }

        public void OnGet()
        {

        }
    }
}
