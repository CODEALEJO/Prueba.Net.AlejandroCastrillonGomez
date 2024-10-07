using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Seeders
{
    public class GuestSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guest>().HasData(
                new Guest
                {
                    Id = 1,
                    Name = "Mary",
                    LastName = "White",
                    Email = "mary.white@example.com",
                    IdentificationNumber = "999999999",
                    PhoneNumber = "555-1234",
                    Birthdate = new DateOnly(1990, 5, 10)
                },
                new Guest
                {
                    Id = 2,
                    Name = "Steve",
                    LastName = "Green",
                    Email = "steve.green@example.com",
                    IdentificationNumber = "888888888",
                    PhoneNumber = "555-5678",
                    Birthdate = new DateOnly(1985, 7, 15)
                },
                new Guest
                {
                    Id = 3,
                    Name = "Emma",
                    LastName = "Brown",
                    Email = "emma.brown@example.com",
                    IdentificationNumber = "777777777",
                    PhoneNumber = "555-9012",
                    Birthdate = new DateOnly(2000, 2, 20)
                },
                new Guest
                {
                    Id = 4,
                    Name = "Oliver",
                    LastName = "Black",
                    Email = "oliver.black@example.com",
                    IdentificationNumber = "666666666",
                    PhoneNumber = "555-3456",
                    Birthdate = new DateOnly(1995, 11, 30)
                },
                new Guest
                {
                    Id = 5,
                    Name = "Sophia",
                    LastName = "Red",
                    Email = "sophia.red@example.com",
                    IdentificationNumber = "555555555",
                    PhoneNumber = "555-7890",
                    Birthdate = new DateOnly(1992, 9, 25)
                }
            );
        }
    }
}
