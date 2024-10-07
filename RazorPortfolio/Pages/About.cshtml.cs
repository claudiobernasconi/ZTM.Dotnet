using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPortfolio.Pages
{
    public class AboutModel : PageModel
    {
        public IList<string> ProgrammingLanguages { get; set; } = new List<string>();

        public void OnGet()
        {
            ProgrammingLanguages.Add("C#");
            ProgrammingLanguages.Add("PHP");
            ProgrammingLanguages.Add("Java");
            ProgrammingLanguages.Add("JavaScript");
            ProgrammingLanguages.Add("TypeScript");
            ProgrammingLanguages.Add("C");
        }
    }
}
