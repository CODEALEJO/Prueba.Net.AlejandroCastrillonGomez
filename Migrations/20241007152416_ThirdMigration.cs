using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$Bw9cod.Lde8SjxszXmtEEOu1pmr6QNdKEo.5sXRP37ujNNsUvfgNy");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "name", "password" },
                values: new object[] { "Jan{e", "$2a$11$bVyhrWZDgkayMsYUfBFR/uj36nNp0Zi6q4ViXVpcyKGYSrirFWzD." });

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$IxRS.McgXeE/0atDYmJpXelhL3inVvPd.FGUpG3LK/kdPl2CUqQmu");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$P/.rIgk7zuFTfDdM8pwqWe8ctRnJ0YLHDqXAKfX/lkDoRe3RLW7Ca");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$7pWLzZzuWKVqRgiZUGM3Be2CedsyO0ytK1VMu0dijCIcbOy0qwvg.");

            migrationBuilder.InsertData(
                table: "room_types",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "Una acogedora habitación básica con una cama individual, ideal para viajeros solos.", "Habitación Simple" },
                    { 2, "Ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos.", "Habitación Doble" },
                    { 3, "Espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad.", "Suite" },
                    { 4, "Diseñada para familias, con espacio adicional y varias camas para una estancia cómoda.", "Habitación Familiar" }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "id", "availability", "max_persons", "price_per_night", "room_number", "room_type_id" },
                values: new object[,]
                {
                    { 1, true, 1, 50.0, "101", 1 },
                    { 2, false, 1, 50.0, "102", 1 },
                    { 3, true, 2, 80.0, "201", 2 },
                    { 4, false, 2, 80.0, "202", 2 },
                    { 5, true, 2, 150.0, "301", 3 },
                    { 6, true, 2, 150.0, "302", 3 },
                    { 7, true, 4, 200.0, "401", 4 },
                    { 8, false, 4, 200.0, "402", 4 },
                    { 9, true, 1, 50.0, "103", 1 },
                    { 10, true, 1, 45.0, "104", 1 },
                    { 11, true, 1, 60.0, "105", 1 },
                    { 12, false, 1, 55.0, "106", 1 },
                    { 13, true, 1, 70.0, "107", 1 },
                    { 14, false, 1, 50.0, "108", 1 },
                    { 15, true, 1, 75.0, "109", 1 },
                    { 16, true, 1, 65.0, "110", 1 },
                    { 17, true, 2, 80.0, "203", 2 },
                    { 18, true, 2, 90.0, "204", 2 },
                    { 19, true, 2, 85.0, "205", 2 },
                    { 20, false, 2, 75.0, "206", 2 },
                    { 21, true, 2, 82.0, "207", 2 },
                    { 22, true, 2, 88.0, "208", 2 },
                    { 23, true, 2, 81.0, "209", 2 },
                    { 24, false, 2, 79.0, "210", 2 },
                    { 25, true, 2, 150.0, "303", 3 },
                    { 26, true, 2, 155.0, "304", 3 },
                    { 27, true, 2, 145.0, "305", 3 },
                    { 28, false, 2, 140.0, "306", 3 },
                    { 29, true, 2, 160.0, "307", 3 },
                    { 30, true, 2, 165.0, "308", 3 },
                    { 31, true, 2, 170.0, "309", 3 },
                    { 32, true, 2, 175.0, "310", 3 },
                    { 33, true, 4, 200.0, "403", 4 },
                    { 34, false, 4, 210.0, "404", 4 },
                    { 35, true, 4, 220.0, "405", 4 },
                    { 36, true, 4, 205.0, "406", 4 },
                    { 37, false, 4, 215.0, "407", 4 },
                    { 38, true, 4, 230.0, "408", 4 },
                    { 39, true, 4, 225.0, "409", 4 },
                    { 40, true, 4, 240.0, "410", 4 },
                    { 41, false, 4, 250.0, "411", 4 },
                    { 42, true, 4, 245.0, "412", 4 },
                    { 43, true, 4, 255.0, "413", 4 },
                    { 44, true, 4, 265.0, "414", 4 },
                    { 45, true, 4, 270.0, "415", 4 },
                    { 46, false, 4, 275.0, "416", 4 }
                });

            migrationBuilder.InsertData(
                table: "bookings",
                columns: new[] { "id", "employee_id", "EndDate", "guest_id", "room_id", "StartDate", "TotalCost" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250.0 },
                    { 2, 1, new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0 },
                    { 3, 2, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 400.0 },
                    { 4, 3, new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 350.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$fpoZI1p7EI2sSX4MbAjPOuABvK5ta7c8.Rn4lYK1bz30KFYxbp5ue");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "name", "password" },
                values: new object[] { "Jane", "$2a$11$8XJ48fDPD9aDUVhLmrxl1uLMe/Pbly47jhIrJ9XtlkFi/x71YSpvq" });

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$kdZ5No6xNjgrJwSpNdxCzemf6gk9Wuc1OMS/K/hAiSxg0hKzTSpcC");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$CaoaTxbhioWzwwvxuq42CePfc7DRFLxA3xEsbn1h2r8a5n1YphRKq");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$i16FAWBm/EIwuNerGqvWo.9GuVLa5bWmZorKF/219RZWofwC63RMu");
        }
    }
}
