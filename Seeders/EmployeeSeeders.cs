using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Seeders
{
    public class EmployeeSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    IdentificationNumber = "123456789",
                    Password = BCrypt.Net.BCrypt.HashPassword("password123")
                },
                new Employee
                {
                    Id = 2,
                    Name = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    IdentificationNumber = "987654321",
                    Password = BCrypt.Net.BCrypt.HashPassword("password123")
                },
                new Employee
                {
                    Id = 3,
                    Name = "Alice",
                    LastName = "Johnson",
                    Email = "alice.johnson@example.com",
                    IdentificationNumber = "123123123",
                    Password = BCrypt.Net.BCrypt.HashPassword("password123")
                },
                new Employee
                {
                    Id = 4,
                    Name = "Bob",
                    LastName = "Brown",
                    Email = "bob.brown@example.com",
                    IdentificationNumber = "321321321",
                    Password = BCrypt.Net.BCrypt.HashPassword("password123")
                },
                new Employee
                {
                    Id = 5,
                    Name = "Charlie",
                    LastName = "Davis",
                    Email = "charlie.davis@example.com",
                    IdentificationNumber = "555555555",
                    Password = BCrypt.Net.BCrypt.HashPassword("password123")
                }
            );
        }
    }
}
