using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Interface;
using Swashbuckle.AspNetCore.Annotations;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Controllers
{
    public partial class BookingController : ControllerBase
    {
        [HttpDelete("{id}")]
        
        [SwaggerOperation(
            Summary = "Deletes a booking by ID",
            Description = "Deletes a specific booking from the database by its ID. Returns 404 if the booking does not exist."
        )]
        [SwaggerResponse(204, "The booking was successfully deleted.")]
        [SwaggerResponse(404, "If the booking with the specified ID is not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<IActionResult> Delete(int id)
        {
            var exists = await _BookingInterface.CheckExistence(id);
            if (!exists)
            {
                return NotFound("Booking not found");
            }

            await _BookingInterface.DeleteBooking(id);
            return NoContent(); // 204
        }
    }
}

