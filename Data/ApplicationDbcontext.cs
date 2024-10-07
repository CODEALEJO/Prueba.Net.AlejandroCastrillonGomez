using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Seeders;

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Data;
public class ApplicationDbcontext : DbContext
{
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<RoomType> RoomTypes { get; set; }


    public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        EmployeeSeeder.Seed(modelBuilder);
        GuestSeeder.Seed(modelBuilder);
        RoomSeeder.Seed(modelBuilder);
        RoomTypeSeeder.Seed(modelBuilder);
        BookingSeeder.Seed(modelBuilder);
        modelBuilder.Entity<RoomType>()
        .HasMany(rt => rt.Rooms)
        .WithOne(r => r.RoomType)
        .HasForeignKey(r => r.RoomTypeId);
    }
}