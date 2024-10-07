using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorForms.Pages
{
    public class TagHelpersModel : PageModel
    {
        public Employee Employee { get; set; }

        public void OnPost(Employee employee)
        {
            // save it to the database
            Console.WriteLine(employee.Name);
        }
    }

    public class Employee
    {
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Send monthly newsletter")]
        public bool Newsletter { get; set; }
    }
}
