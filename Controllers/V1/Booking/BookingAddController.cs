using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.DTOs;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Interface;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Controllers
{
    public partial class BookingController : ControllerBase
    {

        [HttpPost]
        [SwaggerOperation(
            Summary = "Creates a new booking",
            Description = "Creates a new booking in the database. Returns 201 if the booking is created successfully."
        )]
        [SwaggerResponse(201, "The booking was created successfully.")]
        [SwaggerResponse(400, "If the request is malformed or contains invalid data.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<ActionResult<Booking>> CreateBooking(BookingDTO inputBooking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newBooking = new Booking(inputBooking.EmployeeId, inputBooking.StartDate, inputBooking.EndDate, inputBooking.RoomId);
            await _BookingInterface.AddBooking(newBooking);
            return Ok(newBooking);
        }
    }
}

