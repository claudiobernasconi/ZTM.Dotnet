using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorActionResults.Pages
{
    public class ManualModel : PageModel
    {
        public FileResult OnGet()
        {
            var data = System.IO.File.ReadAllBytes("Manual.pdf");
            return File(data, "application/pdf"); // MIME Types 
        }
    }
}
