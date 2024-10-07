using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorForms.Pages
{
    public class FormValidationModel : PageModel
    {
        public ValidatedEmployee Employee { get; set; }

        public void OnPost(Employee employee)
        {
            // save it to the database
            Console.WriteLine(employee.Name);
            ModelState.Clear();
        }
    }

    public class ValidatedEmployee
    {
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [MinLength(12)]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Send monthly newsletter")]
        public bool Newsletter { get; set; }
    }
}
