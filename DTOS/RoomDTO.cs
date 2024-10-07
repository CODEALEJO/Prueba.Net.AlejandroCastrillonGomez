using System.ComponentModel.DataAnnotations;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.DTOs
{
    public class RoomDTO
    {
        [Required]
        [StringLength(10, ErrorMessage = "The room number must be at most {1} characters long.")]
        public string RoomNumber { get; set; }

        [Required]
        public int RoomTypeId { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "The price per night must be a positive number.")]
        public double PricePerNight { get; set; }

        [Required]
        public bool Availability { get; set; }

        [Required]
        [Range(1, 4, ErrorMessage = "The maximum number of persons must be between 1 and 4.")]
        public byte MaxPerson { get; set; }
    }
}
