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
    [Migration("20241007133800_SecondMigration")]
    partial class SecondMigration
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
                            Password = "$2a$11$fpoZI1p7EI2sSX4MbAjPOuABvK5ta7c8.Rn4lYK1bz30KFYxbp5ue"
                        },
                        new
                        {
                            Id = 2,
                            Email = "jane.smith@example.com",
                            IdentificationNumber = "987654321",
                            LastName = "Smith",
                            Name = "Jane",
                            Password = "$2a$11$8XJ48fDPD9aDUVhLmrxl1uLMe/Pbly47jhIrJ9XtlkFi/x71YSpvq"
                        },
                        new
                        {
                            Id = 3,
                            Email = "alice.johnson@example.com",
                            IdentificationNumber = "123123123",
                            LastName = "Johnson",
                            Name = "Alice",
                            Password = "$2a$11$kdZ5No6xNjgrJwSpNdxCzemf6gk9Wuc1OMS/K/hAiSxg0hKzTSpcC"
                        },
                        new
                        {
                            Id = 4,
                            Email = "bob.brown@example.com",
                            IdentificationNumber = "321321321",
                            LastName = "Brown",
                            Name = "Bob",
                            Password = "$2a$11$CaoaTxbhioWzwwvxuq42CePfc7DRFLxA3xEsbn1h2r8a5n1YphRKq"
                        },
                        new
                        {
                            Id = 5,
                            Email = "charlie.davis@example.com",
                            IdentificationNumber = "555555555",
                            LastName = "Davis",
                            Name = "Charlie",
                            Password = "$2a$11$i16FAWBm/EIwuNerGqvWo.9GuVLa5bWmZorKF/219RZWofwC63RMu"
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
