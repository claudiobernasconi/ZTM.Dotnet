using System.ComponentModel.DataAnnotations;

namespace MVCForms.Models;

public class AddMovieViewModel
{
    [Required]
    [StringLength(50)]
    public string Title { get; set; }

    [Required]
    public int Year { get; set; }

    [Required]
    public decimal Rating { get; set; }
}
