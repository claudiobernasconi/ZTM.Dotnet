using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorForms.Pages
{
    public class ModelBindingModel : PageModel
    {
        public string Username { get; set; }

        public void OnPost(FormData data)
        {
            Username = data.Username;
        }
    }

    public record FormData(string Username, string Password);
}
