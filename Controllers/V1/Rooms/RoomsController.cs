using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Interface;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Controllers
{
    [ApiController]
    [Route("api/v2/rooms")]
    public partial class RoomsController : ControllerBase
    {
        protected readonly IRoomInterface _RoomInterface;

        public RoomsController(IRoomInterface roomInterface)
        {
            _RoomInterface = roomInterface;
        }

    }
}