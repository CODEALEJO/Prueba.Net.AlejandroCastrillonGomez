using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Seeders
{
    public class RoomSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id = 1,
                    RoomNumber = "101",
                    RoomTypeId = 1, // Habitación Simple
                    PricePerNight = 50.00,
                    Availability = true,
                    MaxPerson = 1
                },
                new Room
                {
                    Id = 2,
                    RoomNumber = "102",
                    RoomTypeId = 1, // Habitación Simple
                    PricePerNight = 50.00,
                    Availability = false,
                    MaxPerson = 1
                },
                new Room
                {
                    Id = 3,
                    RoomNumber = "201",
                    RoomTypeId = 2, // Habitación Doble
                    PricePerNight = 80.00,
                    Availability = true,
                    MaxPerson = 2
                },
                new Room
                {
                    Id = 4,
                    RoomNumber = "202",
                    RoomTypeId = 2, // Habitación Doble
                    PricePerNight = 80.00,
                    Availability = false,
                    MaxPerson = 2
                },
                new Room
                {
                    Id = 5,
                    RoomNumber = "301",
                    RoomTypeId = 3, // Suite
                    PricePerNight = 150.00,
                    Availability = true,
                    MaxPerson = 2
                },
                new Room
                {
                    Id = 6,
                    RoomNumber = "302",
                    RoomTypeId = 3, // Suite
                    PricePerNight = 150.00,
                    Availability = true,
                    MaxPerson = 2
                },
                new Room
                {
                    Id = 7,
                    RoomNumber = "401",
                    RoomTypeId = 4, // Habitación Familiar
                    PricePerNight = 200.00,
                    Availability = true,
                    MaxPerson = 4
                },
                new Room
                {
                    Id = 8,
                    RoomNumber = "402",
                    RoomTypeId = 4, // Habitación Familiar
                    PricePerNight = 200.00,
                    Availability = false,
                    MaxPerson = 4
                },
                new Room { Id = 9, RoomNumber = "103", RoomTypeId = 1, PricePerNight = 50.00, Availability = true, MaxPerson = 1 },
                new Room { Id = 10, RoomNumber = "104", RoomTypeId = 1, PricePerNight = 45.00, Availability = true, MaxPerson = 1 },
                new Room { Id = 11, RoomNumber = "105", RoomTypeId = 1, PricePerNight = 60.00, Availability = true, MaxPerson = 1 },
                new Room { Id = 12, RoomNumber = "106", RoomTypeId = 1, PricePerNight = 55.00, Availability = false, MaxPerson = 1 },
                new Room { Id = 13, RoomNumber = "107", RoomTypeId = 1, PricePerNight = 70.00, Availability = true, MaxPerson = 1 },
                new Room { Id = 14, RoomNumber = "108", RoomTypeId = 1, PricePerNight = 50.00, Availability = false, MaxPerson = 1 },
                new Room { Id = 15, RoomNumber = "109", RoomTypeId = 1, PricePerNight = 75.00, Availability = true, MaxPerson = 1 },
                new Room { Id = 16, RoomNumber = "110", RoomTypeId = 1, PricePerNight = 65.00, Availability = true, MaxPerson = 1 },
                new Room { Id = 17, RoomNumber = "203", RoomTypeId = 2, PricePerNight = 80.00, Availability = true, MaxPerson = 2 },
                new Room { Id = 18, RoomNumber = "204", RoomTypeId = 2, PricePerNight = 90.00, Availability = true, MaxPerson = 2 },
                new Room { Id = 19, RoomNumber = "205", RoomTypeId = 2, PricePerNight = 85.00, Availability = true, MaxPerson = 2 },
                new Room { Id = 20, RoomNumber = "206", RoomTypeId = 2, PricePerNight = 75.00, Availability = false, MaxPerson = 2 },
                new Room { Id = 21, RoomNumber = "207", RoomTypeId = 2, PricePerNight = 82.00, Availability = true, MaxPerson = 2 },
                new Room { Id = 22, RoomNumber = "208", RoomTypeId = 2, PricePerNight = 88.00, Availability = true, MaxPerson = 2 },
                new Room { Id = 23, RoomNumber = "209", RoomTypeId = 2, PricePerNight = 81.00, Availability = true, MaxPerson = 2 },
                new Room { Id = 24, RoomNumber = "210", RoomTypeId = 2, PricePerNight = 79.00, Availability = false, MaxPerson = 2 },
                new Room { Id = 25, RoomNumber = "303", RoomTypeId = 3, PricePerNight = 150.00, Availability = true, MaxPerson = 2 },
                new Room { Id = 26, RoomNumber = "304", RoomTypeId = 3, PricePerNight = 155.00, Availability = true, MaxPerson = 2 },
                new Room { Id = 27, RoomNumber = "305", RoomTypeId = 3, PricePerNight = 145.00, Availability = true, MaxPerson = 2 },
                new Room { Id = 28, RoomNumber = "306", RoomTypeId = 3, PricePerNight = 140.00, Availability = false, MaxPerson = 2 },
                new Room { Id = 29, RoomNumber = "307", RoomTypeId = 3, PricePerNight = 160.00, Availability = true, MaxPerson = 2 },
                new Room { Id = 30, RoomNumber = "308", RoomTypeId = 3, PricePerNight = 165.00, Availability = true, MaxPerson = 2 },
                new Room { Id = 31, RoomNumber = "309", RoomTypeId = 3, PricePerNight = 170.00, Availability = true, MaxPerson = 2 },
                new Room { Id = 32, RoomNumber = "310", RoomTypeId = 3, PricePerNight = 175.00, Availability = true, MaxPerson = 2 },
                new Room { Id = 33, RoomNumber = "403", RoomTypeId = 4, PricePerNight = 200.00, Availability = true, MaxPerson = 4 },
                new Room { Id = 34, RoomNumber = "404", RoomTypeId = 4, PricePerNight = 210.00, Availability = false, MaxPerson = 4 },
                new Room { Id = 35, RoomNumber = "405", RoomTypeId = 4, PricePerNight = 220.00, Availability = true, MaxPerson = 4 },
                new Room { Id = 36, RoomNumber = "406", RoomTypeId = 4, PricePerNight = 205.00, Availability = true, MaxPerson = 4 },
                new Room { Id = 37, RoomNumber = "407", RoomTypeId = 4, PricePerNight = 215.00, Availability = false, MaxPerson = 4 },
                new Room { Id = 38, RoomNumber = "408", RoomTypeId = 4, PricePerNight = 230.00, Availability = true, MaxPerson = 4 },
                new Room { Id = 39, RoomNumber = "409", RoomTypeId = 4, PricePerNight = 225.00, Availability = true, MaxPerson = 4 },
                new Room { Id = 40, RoomNumber = "410", RoomTypeId = 4, PricePerNight = 240.00, Availability = true, MaxPerson = 4 },
                new Room { Id = 41, RoomNumber = "411", RoomTypeId = 4, PricePerNight = 250.00, Availability = false, MaxPerson = 4 },
                new Room { Id = 42, RoomNumber = "412", RoomTypeId = 4, PricePerNight = 245.00, Availability = true, MaxPerson = 4 },
                new Room { Id = 43, RoomNumber = "413", RoomTypeId = 4, PricePerNight = 255.00, Availability = true, MaxPerson = 4 },
                new Room { Id = 44, RoomNumber = "414", RoomTypeId = 4, PricePerNight = 265.00, Availability = true, MaxPerson = 4 },
                new Room { Id = 45, RoomNumber = "415", RoomTypeId = 4, PricePerNight = 270.00, Availability = true, MaxPerson = 4 },
                new Room { Id = 46, RoomNumber = "416", RoomTypeId = 4, PricePerNight = 275.00, Availability = false, MaxPerson = 4 }
            );
        }
    }
}
