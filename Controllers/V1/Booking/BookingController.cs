using Microsoft.AspNetCore.Mvc;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Interface;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Controllers
{
    [ApiController]
    [Route("api/V1/bookings")]
    public partial class BookingController : ControllerBase
    {
        protected readonly IBookingInterface _BookingInterface;

        public BookingController(IBookingInterface bookingInterface)
        {
            _BookingInterface = bookingInterface;
        }
    }
}

