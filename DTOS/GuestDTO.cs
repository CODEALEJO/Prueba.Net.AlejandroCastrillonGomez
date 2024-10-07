using System.ComponentModel.DataAnnotations;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.DTOs
{
    public class GuestDTO
    {
        [Required]
        [StringLength(255, ErrorMessage = "The name must be at most {1} characters long.")]
        public string Name { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The last name must be at most {1} characters long.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "The email format is not valid.")]
        [StringLength(255, ErrorMessage = "The email must be at most {1} characters long.")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The identification number must be at most {1} characters long.")]
        public string IdentificationNumber { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The phone number must be at most {1} characters long.")]
        [Phone(ErrorMessage = "The phone number format is not valid.")]
        public string PhoneNumber { get; set; }

        
        [DataType(DataType.Date)]
        public DateOnly Birthdate { get; set; }
    }
}
