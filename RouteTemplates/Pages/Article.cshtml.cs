using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RouteTemplates.Pages
{
    public class ArticleModel : PageModel
    {
        public string? Title { get; set; }
        public string? Text { get; set; }

        public void OnGet(int articleId)
        {
            switch (articleId)
            {
                case 1:
                    Title = "New Website!";
                    Text = "Welcome.";
                    break;
                case 2:
                    Title = "New Customer";
                    Text = "We have a new customer.";
                    break;
                case 3:
                    Title = "Best Article";
                    Text = "This is the best article!";
                    break;
            }
        }
    }
}
