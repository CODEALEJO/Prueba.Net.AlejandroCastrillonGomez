using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Interface;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Controllers
{
    public partial class BookingController : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(
            Summary = "Returns all bookings",
            Description = "Returns a list of all bookings from the database."
        )]
        [SwaggerResponse(200, "Returns a list of bookings")]
        [SwaggerResponse(404, "If no bookings are found in the database.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<IActionResult> GetAllBookings()
        {
            var bookings = await _BookingInterface.GetBookings();

            if (bookings == null || !bookings.Any())
            {
                return NotFound("No bookings found.");
            }

            return Ok(bookings);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Returns a booking by ID",
            Description = "Returns a specific booking from the database by its ID."
        )]
        [SwaggerResponse(200, "Returns a booking")]
        [SwaggerResponse(404, "If no booking is found for the given ID.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<IActionResult> GetBookingById(int id)
        {
            var booking = await _BookingInterface.GetBookingsById(id);
            if (booking == null)
            {
                return NotFound("Booking not found");
            }
            return Ok(booking);
        }
    }
}


