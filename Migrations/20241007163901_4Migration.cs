using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba.Net.AlejandroCastrillonGomez__use_controllers.Migrations
{
    /// <inheritdoc />
    public partial class _4Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "password",
                value: "$2a$11$MhOuDrr6H.beZkzPcXRvBuKGU04Vo/mK5pHGbLbN6a7QDux5GAFjq");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "password",
                value: "$2a$11$bVyhrWZDgkayMsYUfBFR/uj36nNp0Zi6q4ViXVpcyKGYSrirFWzD.");

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
        }
    }
}
