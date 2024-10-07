// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Swashbuckle.AspNetCore.Annotations;

// namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Controllers.V1.Rooms
// {
   
//     public partial class RoomController : ControllerBase
//     {
//         [HttpGet("roomtype/{id}")]
//         [SwaggerOperation(Summary = "Get room type by ID", Description = "Retrieves a specific room type by ID")]
        
//         public async Task<IActionResult> GetRoomTypeById(int id)
//         {
//             // var roomType = await _RoomInterface.GetRoomTypeById(id);

//             if (roomType == null)
//             {
//                 return NotFound(new { message = "Room type not found" });
//             }

//             return Ok(roomType);
//         }
//     }
// }