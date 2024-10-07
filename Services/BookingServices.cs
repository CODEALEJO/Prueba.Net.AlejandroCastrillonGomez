using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Data;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Interface;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Services
{
    public class BookingServices : IBookingInterface
    {
        private readonly ApplicationDbcontext _context;

        public BookingServices(ApplicationDbcontext context)
        {
            _context = context;
        }

        public async Task<Booking> GetBookingsById(int id)
        {
            return await _context.Bookings.FindAsync(id);
        }

        public async Task<IEnumerable<Booking>> GetBookings()
        {
            return await _context.Bookings.ToListAsync();
        }

        public async Task<bool> CheckExistence(int id)
        {
            try
            {
                
                return await _context.Bookings.AnyAsync(b => b.Id == id);
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error occurred while checking the booking in the database.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred while checking the booking.", ex);
            }
        }

        public async Task<Booking> AddBooking(Booking booking)
        {
            if (booking == null)
            {
                throw new ArgumentNullException(nameof(booking), "The booking cannot be null.");
            }

            try
            { 
                _context.Bookings.Add(booking);
                await _context.SaveChangesAsync();
                return booking;
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error occurred while adding the booking to the database.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred while adding the booking.", ex);
            }
        }

        public async Task DeleteBooking(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Booking> UpdateBooking(Booking booking)
        {
            if (booking == null)
            {
                throw new ArgumentNullException(nameof(booking));
            }
            try
            {
                _context.Entry(booking).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return booking;
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error occurred while updating the booking in the database.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred while updating the booking.", ex);
            }
        }
    }
}


