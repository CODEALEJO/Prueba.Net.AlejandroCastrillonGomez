using System.ComponentModel.DataAnnotations;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.DTOs
{
    public class RoomTypeDTO
    {
        [Required]
        [StringLength(50, ErrorMessage = "The name must be at most {1} characters long.")]
        public string Name { get; set; }

        [StringLength(255, ErrorMessage = "The description must be at most {1} characters long.")]
        public string Description { get; set; }
    }
}
