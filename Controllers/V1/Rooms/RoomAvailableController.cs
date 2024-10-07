using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Controllers
{
    public partial class RoomsController : ControllerBase
    {
        [HttpGet("available-rooms")]
        [SwaggerOperation(
    Summary = "Returns available rooms",
    Description = "Returns a list of all available rooms from the database."
)]
        [SwaggerResponse(200, "Returns a list of available rooms")]
        [SwaggerResponse(404, "If no available rooms are found.")]
        public async Task<IActionResult> GetRoomsAvailable()
        {
            var availableRooms = await _RoomInterface.GetRoomsAvailable();

            if (availableRooms == null || !availableRooms.Any())
            {
                return NotFound("No available rooms found.");
            }

            return Ok(availableRooms);
        }
    }
}