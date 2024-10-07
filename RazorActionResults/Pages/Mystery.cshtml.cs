using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorActionResults.Pages
{
    public class MysteryModel : PageModel
    {
        public IActionResult OnGet(string name)
        {
            if (name == "Claudio")
            {
                return new OkResult();
            }

            if (name == "Manual")
            {
                return Redirect("Manual");
            }

            return NotFound();
        }
    }
}
