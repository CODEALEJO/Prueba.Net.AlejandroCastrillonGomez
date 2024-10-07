using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Seeders
{
    public class BookingSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().HasData(
                new Booking
                {
                    Id = 1,
                    RoomId = 1,
                    GuestId = 1,
                    EmployeeId = 1,
                    StartDate = new DateTime(2024, 10, 1),
                    EndDate = new DateTime(2024, 10, 5),
                    TotalCost = 250.00
                },
                new Booking
                {
                    Id = 2,
                    RoomId = 2,
                    GuestId = 2,
                    EmployeeId = 1,
                    StartDate = new DateTime(2024, 10, 3),
                    EndDate = new DateTime(2024, 10, 7),
                    TotalCost = 300.00
                },
                new Booking
                {
                    Id = 3,
                    RoomId = 3,
                    GuestId = 3,
                    EmployeeId = 2,
                    StartDate = new DateTime(2024, 10, 5),
                    EndDate = new DateTime(2024, 10, 10),
                    TotalCost = 400.00
                },
                new Booking
                {
                    Id = 4,
                    RoomId = 4,
                    GuestId = 1,
                    EmployeeId = 3,
                    StartDate = new DateTime(2024, 10, 2),
                    EndDate = new DateTime(2024, 10, 6),
                    TotalCost = 350.00
                }
            );
        }
    }
}