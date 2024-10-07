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
        [HttpGet("room-types")]
        [SwaggerOperation(Summary = "Get room types", Description = "Returns a list of available room types")]
        [ProducesResponseType(typeof(List<string>), 200)]
        [ProducesResponseType(typeof(void), 404)]
        [ProducesResponseType(typeof(void), 500)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        public async Task<IActionResult> GetRoomTypes()
        {
            var roomTypes = await _RoomInterface.GetRoomTypes();
            return Ok(roomTypes);
        }


    }
}