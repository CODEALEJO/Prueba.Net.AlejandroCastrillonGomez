﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prueba.Net.AlejandroCastrillonGomez__use_controllers.Data;

#nullable disable

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20241007165336_5Migration")]
    partial class _5Migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GuestId")
                        .HasColumnType("int")
                        .HasColumnName("guest_id");

                    b.Property<int>("RoomId")
                        .HasColumnType("int")
                        .HasColumnName("room_id");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("TotalCost")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("GuestId");

                    b.HasIndex("RoomId");

                    b.ToTable("bookings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 1,
                            EndDate = new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 1,
                            RoomId = 1,
                            StartDate = new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalCost = 250.0
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 1,
                            EndDate = new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 2,
                            RoomId = 2,
                            StartDate = new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalCost = 300.0
                        },
                        new
                        {
                            Id = 3,
                            EmployeeId = 2,
                            EndDate = new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 3,
                            RoomId = 3,
                            StartDate = new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalCost = 400.0
                        },
                        new
                        {
                            Id = 4,
                            EmployeeId = 3,
                            EndDate = new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 1,
                            RoomId = 4,
                            StartDate = new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalCost = 350.0
                        });
                });

            modelBuilder.Entity("Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("IdentificationNumber")
                        .HasColumnType("longtext")
                        .HasColumnName("identification_number");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext")
                        .HasColumnName("lastName");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "john.doe@example.com",
                            IdentificationNumber = "123456789",
                            LastName = "Doe",
                            Name = "John",
                            Password = "$2a$11$UmqXKIH.h0T94T8vbIhUQuQbkpSZoPL6AljPD4yAyYhQPmu84Eda."
                        },
                        new
                        {
                            Id = 2,
                            Email = "jane.smith@example.com",
                            IdentificationNumber = "987654321",
                            LastName = "Smith",
                            Name = "Jane",
                            Password = "$2a$11$Vw1kzZyjlCyzR5hsckvPZuKEz.EZFC0BIEOMeQWuf3j7so1I/GQVS"
                        },
                        new
                        {
                            Id = 3,
                            Email = "alice.johnson@example.com",
                            IdentificationNumber = "123123123",
                            LastName = "Johnson",
                            Name = "Alice",
                            Password = "$2a$11$L9/bcZDKci.8G6LMTV9F/uLCWYh0KPp0qsZwWpbjfscZ9sCnNtFnm"
                        },
                        new
                        {
                            Id = 4,
                            Email = "bob.brown@example.com",
                            IdentificationNumber = "321321321",
                            LastName = "Brown",
                            Name = "Bob",
                            Password = "$2a$11$nfzQBBf0.gwr0syosvqFEOWAUICeCtcI0fg/Opo.EcbHk2m7zACo6"
                        },
                        new
                        {
                            Id = 5,
                            Email = "charlie.davis@example.com",
                            IdentificationNumber = "555555555",
                            LastName = "Davis",
                            Name = "Charlie",
                            Password = "$2a$11$OJ2xTPJuB.Cl6XT8W84vBe0ZngDFPtoTac84N8saUtDmbZBhl4/0K"
                        });
                });

            modelBuilder.Entity("Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Birthdate")
                        .HasColumnType("date")
                        .HasColumnName("birthdate");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("IdentificationNumber")
                        .HasColumnType("longtext")
                        .HasColumnName("identification_number");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.ToTable("guests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthdate = new DateOnly(1990, 5, 10),
                            Email = "mary.white@example.com",
                            IdentificationNumber = "999999999",
                            LastName = "White",
                            Name = "Mary",
                            PhoneNumber = "555-1234"
                        },
                        new
                        {
                            Id = 2,
                            Birthdate = new DateOnly(1985, 7, 15),
                            Email = "steve.green@example.com",
                            IdentificationNumber = "888888888",
                            LastName = "Green",
                            Name = "Steve",
                            PhoneNumber = "555-5678"
                        },
                        new
                        {
                            Id = 3,
                            Birthdate = new DateOnly(2000, 2, 20),
                            Email = "emma.brown@example.com",
                            IdentificationNumber = "777777777",
                            LastName = "Brown",
                            Name = "Emma",
                            PhoneNumber = "555-9012"
                        },
                        new
                        {
                            Id = 4,
                            Birthdate = new DateOnly(1995, 11, 30),
                            Email = "oliver.black@example.com",
                            IdentificationNumber = "666666666",
                            LastName = "Black",
                            Name = "Oliver",
                            PhoneNumber = "555-3456"
                        },
                        new
                        {
                            Id = 5,
                            Birthdate = new DateOnly(1992, 9, 25),
                            Email = "sophia.red@example.com",
                            IdentificationNumber = "555555555",
                            LastName = "Red",
                            Name = "Sophia",
                            PhoneNumber = "555-7890"
                        });
                });

            modelBuilder.Entity("Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Availability")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("availability");

                    b.Property<int>("MaxPerson")
                        .HasColumnType("int")
                        .HasColumnName("max_persons");

                    b.Property<double>("PricePerNight")
                        .HasColumnType("double")
                        .HasColumnName("price_per_night");

                    b.Property<string>("RoomNumber")
                        .HasColumnType("longtext")
                        .HasColumnName("room_number");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int")
                        .HasColumnName("room_type_id");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Availability = true,
                            MaxPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "101",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Availability = false,
                            MaxPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "102",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            Availability = true,
                            MaxPerson = 2,
                            PricePerNight = 80.0,
                            RoomNumber = "201",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 4,
                            Availability = false,
                            MaxPerson = 2,
                            PricePerNight = 80.0,
                            RoomNumber = "202",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 5,
                            Availability = true,
                            MaxPerson = 2,
                            PricePerNight = 150.0,
                            RoomNumber = "301",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 6,
                            Availability = true,
                            MaxPerson = 2,
                            PricePerNight = 150.0,
                            RoomNumber = "302",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 7,
                            Availability = true,
                            MaxPerson = 4,
                            PricePerNight = 200.0,
                            RoomNumber = "401",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 8,
                            Availability = false,
                            MaxPerson = 4,
                            PricePerNight = 200.0,
                            RoomNumber = "402",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 9,
                            Availability = true,
                            MaxPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "103",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 10,
                            Availability = true,
                            MaxPerson = 1,
                            PricePerNight = 45.0,
                            RoomNumber = "104",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 11,
                            Availability = true,
                            MaxPerson = 1,
                            PricePerNight = 60.0,
                            RoomNumber = "105",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 12,
                            Availability = false,
                            MaxPerson = 1,
                            PricePerNight = 55.0,
                            RoomNumber = "106",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 13,
                            Availability = true,
                            MaxPerson = 1,
                            PricePerNight = 70.0,
                            RoomNumber = "107",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 14,
                            Availability = false,
                            MaxPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "108",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 15,
                            Availability = true,
                            MaxPerson = 1,
                            PricePerNight = 75.0,
                            RoomNumber = "109",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 16,
                            Availability = true,
                            MaxPerson = 1,
                            PricePerNight = 65.0,
                            RoomNumber = "110",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 17,
                            Availability = true,
                            MaxPerson = 2,
                            PricePerNight = 80.0,
                            RoomNumber = "203",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 18,
                            Availability = true,
                            MaxPerson = 2,
                            PricePerNight = 90.0,
                            RoomNumber = "204",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 19,
                            Availability = true,
                            MaxPerson = 2,
                            PricePerNight = 85.0,
                            RoomNumber = "205",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 20,
                            Availability = false,
                            MaxPerson = 2,
                            PricePerNight = 75.0,
                            RoomNumber = "206",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 21,
                            Availability = true,
                            MaxPerson = 2,
                            PricePerNight = 82.0,
                            RoomNumber = "207",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 22,
                            Availability = true,
                            MaxPerson = 2,
                            PricePerNight = 88.0,
                            RoomNumber = "208",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 23,
                            Availability = true,
                            MaxPerson = 2,
                            PricePerNight = 81.0,
                            RoomNumber = "209",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 24,
                            Availability = false,
                            MaxPerson = 2,
                            PricePerNight = 79.0,
                            RoomNumber = "210",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 25,
                            Availability = true,
                            MaxPerson = 2,
                            PricePerNight = 150.0,
                            RoomNumber = "303",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 26,
                            Availability = true,
                            MaxPerson = 2,
                            PricePerNight = 155.0,
                            RoomNumber = "304",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 27,
                            Availability = true,
                            MaxPerson = 2,
                            PricePerNight = 145.0,
                            RoomNumber = "305",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 28,
                            Availability = false,
                            MaxPerson = 2,
                            PricePerNight = 140.0,
                            RoomNumber = "306",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 29,
                            Availability = true,
                            MaxPerson = 2,
                            PricePerNight = 160.0,
                            RoomNumber = "307",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 30,
                            Availability = true,
                            MaxPerson = 2,
                            PricePerNight = 165.0,
                            RoomNumber = "308",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 31,
                            Availability = true,
                            MaxPerson = 2,
                            PricePerNight = 170.0,
                            RoomNumber = "309",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 32,
                            Availability = true,
                            MaxPerson = 2,
                            PricePerNight = 175.0,
                            RoomNumber = "310",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 33,
                            Availability = true,
                            MaxPerson = 4,
                            PricePerNight = 200.0,
                            RoomNumber = "403",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 34,
                            Availability = false,
                            MaxPerson = 4,
                            PricePerNight = 210.0,
                            RoomNumber = "404",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 35,
                            Availability = true,
                            MaxPerson = 4,
                            PricePerNight = 220.0,
                            RoomNumber = "405",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 36,
                            Availability = true,
                            MaxPerson = 4,
                            PricePerNight = 205.0,
                            RoomNumber = "406",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 37,
                            Availability = false,
                            MaxPerson = 4,
                            PricePerNight = 215.0,
                            RoomNumber = "407",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 38,
                            Availability = true,
                            MaxPerson = 4,
                            PricePerNight = 230.0,
                            RoomNumber = "408",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 39,
                            Availability = true,
                            MaxPerson = 4,
                            PricePerNight = 225.0,
                            RoomNumber = "409",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 40,
                            Availability = true,
                            MaxPerson = 4,
                            PricePerNight = 240.0,
                            RoomNumber = "410",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 41,
                            Availability = false,
                            MaxPerson = 4,
                            PricePerNight = 250.0,
                            RoomNumber = "411",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 42,
                            Availability = true,
                            MaxPerson = 4,
                            PricePerNight = 245.0,
                            RoomNumber = "412",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 43,
                            Availability = true,
                            MaxPerson = 4,
                            PricePerNight = 255.0,
                            RoomNumber = "413",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 44,
                            Availability = true,
                            MaxPerson = 4,
                            PricePerNight = 265.0,
                            RoomNumber = "414",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 45,
                            Availability = true,
                            MaxPerson = 4,
                            PricePerNight = 270.0,
                            RoomNumber = "415",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 46,
                            Availability = false,
                            MaxPerson = 4,
                            PricePerNight = 275.0,
                            RoomNumber = "416",
                            RoomTypeId = 4
                        });
                });

            modelBuilder.Entity("Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("room_types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Una acogedora habitación básica con una cama individual, ideal para viajeros solos.",
                            Name = "Habitación Simple"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos.",
                            Name = "Habitación Doble"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad.",
                            Name = "Suite"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Diseñada para familias, con espacio adicional y varias camas para una estancia cómoda.",
                            Name = "Habitación Familiar"
                        });
                });

            modelBuilder.Entity("Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.Booking", b =>
                {
                    b.HasOne("Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Guest");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.Room", b =>
                {
                    b.HasOne("Prueba.Net.AlejandroCastrillonGomez__use_controllers.Models.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomType");
                });
#pragma warning restore 612, 618
        }
    }
}
