using System.ComponentModel.DataAnnotations;

namespace BlazorFormsValidation;

public class Employee
{
    [Required]
    [StringLength(20, MinimumLength = 4, ErrorMessage = "The first name must be between 4 and 20 characters.")]
    public string? FirstName { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "The last name must not be longer than 50 characters.")]
    public string? LastName { get; set; }

    [Required]
    public DateOnly DateOfBirth { get; set; }

    [Required]
    [Range(10_000, 100_000, ErrorMessage = "The salary must be in the range of 10,000 and 100,000.")]
    public decimal Salary { get; set; }
}
