using System.ComponentModel.DataAnnotations;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.DTOs
{
    public class EmployeeDTO
    {
        [Required]
        [StringLength(50, ErrorMessage = "The name must be at most {1} characters long.")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The last name must be at most {1} characters long.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "The email format is not valid.")]
        [StringLength(255, ErrorMessage = "The email must be at most {1} characters long.")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The identification number must be at most {1} characters long.")]
        public string IdentificationNumber { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 8, ErrorMessage = "The password must be between 8 and 255 characters long.")]
        public string Password { get; set; }
    }
}
