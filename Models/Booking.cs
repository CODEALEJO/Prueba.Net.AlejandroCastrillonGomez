using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models
{
    [Table("bookings")]
    public class Booking
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("room_id")]
        public int RoomId { get; set; }

        [ForeignKey("RoomId")]
        public Room Room { get; set; }

        [Column("guest_id")]
        public int GuestId { get; set; }

        [ForeignKey("GuestId")]
        public Guest Guest { get; set; }

        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double TotalCost { get; set; }

        public Booking() { }

        // Constructor
        public Booking(int employeeId, DateTime startDate, DateTime endDate, double totalCost)
        {
            EmployeeId = employeeId;
            StartDate = startDate;
            EndDate = endDate;
            TotalCost = totalCost;
        }
    }
}
