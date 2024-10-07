using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "id", "email", "identification_number", "lastName", "name", "password" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "123456789", "Doe", "John", "$2a$11$fpoZI1p7EI2sSX4MbAjPOuABvK5ta7c8.Rn4lYK1bz30KFYxbp5ue" },
                    { 2, "jane.smith@example.com", "987654321", "Smith", "Jane", "$2a$11$8XJ48fDPD9aDUVhLmrxl1uLMe/Pbly47jhIrJ9XtlkFi/x71YSpvq" },
                    { 3, "alice.johnson@example.com", "123123123", "Johnson", "Alice", "$2a$11$kdZ5No6xNjgrJwSpNdxCzemf6gk9Wuc1OMS/K/hAiSxg0hKzTSpcC" },
                    { 4, "bob.brown@example.com", "321321321", "Brown", "Bob", "$2a$11$CaoaTxbhioWzwwvxuq42CePfc7DRFLxA3xEsbn1h2r8a5n1YphRKq" },
                    { 5, "charlie.davis@example.com", "555555555", "Davis", "Charlie", "$2a$11$i16FAWBm/EIwuNerGqvWo.9GuVLa5bWmZorKF/219RZWofwC63RMu" }
                });

            migrationBuilder.InsertData(
                table: "guests",
                columns: new[] { "id", "birthdate", "email", "identification_number", "last_name", "name", "phone_number" },
                values: new object[,]
                {
                    { 1, new DateOnly(1990, 5, 10), "mary.white@example.com", "999999999", "White", "Mary", "555-1234" },
                    { 2, new DateOnly(1985, 7, 15), "steve.green@example.com", "888888888", "Green", "Steve", "555-5678" },
                    { 3, new DateOnly(2000, 2, 20), "emma.brown@example.com", "777777777", "Brown", "Emma", "555-9012" },
                    { 4, new DateOnly(1995, 11, 30), "oliver.black@example.com", "666666666", "Black", "Oliver", "555-3456" },
                    { 5, new DateOnly(1992, 9, 25), "sophia.red@example.com", "555555555", "Red", "Sophia", "555-7890" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "guests",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "guests",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "guests",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "guests",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "guests",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
