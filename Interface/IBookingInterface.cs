using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Interface;
public interface IBookingInterface
{
    Task<IEnumerable<Booking>> GetBookings();
    Task<Booking> GetBookingsById(int id);
    Task<Booking> AddBooking(Booking booking);
    Task<Booking> UpdateBooking(Booking booking);
    Task DeleteBooking(int id);
    Task<bool> CheckExistence(int id);
}