using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Migrations
{
    /// <inheritdoc />
    public partial class _5Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$UmqXKIH.h0T94T8vbIhUQuQbkpSZoPL6AljPD4yAyYhQPmu84Eda.");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "name", "password" },
                values: new object[] { "Jane", "$2a$11$Vw1kzZyjlCyzR5hsckvPZuKEz.EZFC0BIEOMeQWuf3j7so1I/GQVS" });

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$L9/bcZDKci.8G6LMTV9F/uLCWYh0KPp0qsZwWpbjfscZ9sCnNtFnm");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$nfzQBBf0.gwr0syosvqFEOWAUICeCtcI0fg/Opo.EcbHk2m7zACo6");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$OJ2xTPJuB.Cl6XT8W84vBe0ZngDFPtoTac84N8saUtDmbZBhl4/0K");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$y/a43yQo7Mp8Z8FfAE24SuDzYObbXLPVDrkQqoPa7H/FBtObF8lKW");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "name", "password" },
                values: new object[] { "Jan{e", "$2a$11$MhOuDrr6H.beZkzPcXRvBuKGU04Vo/mK5pHGbLbN6a7QDux5GAFjq" });

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$bom.m2zFysVOTAmekuXGEOMQNYzTXjBnylYpu.eugNwmf1khj9dYW");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$sUmH/Z03SrScIIBwa6VP7eOwGDliOfIkvyGWSzYF0hOv1AqSoUEam");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$aDoAf40q5m44CpkZ.f1mDeJZ8SHJ6MLmfkeJIpeQA.JkRDK/QoUsO");
        }
    }
}
