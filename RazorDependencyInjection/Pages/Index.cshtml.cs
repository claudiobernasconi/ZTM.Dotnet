using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorDependencyInjection.Services;

namespace RazorDependencyInjection.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ILuckyNumberService _luckyNumberService;

        public int LuckyNumber { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ILuckyNumberService luckyNumberService)
        {
            _logger = logger;
            _luckyNumberService = luckyNumberService;
        }

        public void OnGet()
        {
            LuckyNumber = _luckyNumberService.GetMyLuckyNumber();
        }
    }
}
