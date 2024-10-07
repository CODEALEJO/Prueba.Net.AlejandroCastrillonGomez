using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.DTOs;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Interface;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Controllers
{
    public partial class BookingController : ControllerBase
    {
        [HttpPut("{id}")]
        [SwaggerOperation(
            Summary = "Update a booking by ID",
            Description = "Updates a booking."
        )]
        [SwaggerResponse(204, "The booking was updated successfully.")]
        [SwaggerResponse(400, "If the request is malformed or contains invalid data.")]
        [SwaggerResponse(404, "If the booking with the specified ID is not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        
        public async Task<IActionResult> Update(int id, BookingDTO updateBooking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var checkBooking = await _BookingInterface.CheckExistence(id);
            if (!checkBooking)
            {
                return NotFound();
            }
            
            var booking = await _BookingInterface.GetBookingsById(id);
            if (booking == null)
            {
                return NotFound();
            }

            
            booking.RoomId = updateBooking.RoomId;
            booking.GuestId = updateBooking.GuestId;
            booking.EmployeeId = updateBooking.EmployeeId;
            booking.StartDate = updateBooking.StartDate;
            booking.EndDate = updateBooking.EndDate;
            booking.TotalCost = updateBooking.TotalCost;

            await _BookingInterface.UpdateBooking(booking);
            return NoContent();
        }
    }
}


