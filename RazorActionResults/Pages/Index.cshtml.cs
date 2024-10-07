using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorActionResults.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public PageResult OnGet()
        {
            return Page();
        }
    }
}
