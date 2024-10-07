using System;
using System.ComponentModel.DataAnnotations;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.DTOs
{
    public class BookingDTO
    {
        [Required]
        public int RoomId { get; set; }

        [Required]
        public int GuestId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "The total cost must be a positive value.")]
        public double TotalCost { get; set; }
    }
}
