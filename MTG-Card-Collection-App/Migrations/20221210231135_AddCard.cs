using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTG_Card_Collection_App.Migrations
{
    public partial class AddCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "CMC",
                table: "Cards",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "507585",
                column: "CMC",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "507586",
                column: "CMC",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "507587",
                column: "CMC",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "507588",
                column: "CMC",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "507589",
                column: "CMC",
                value: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "CMC",
                table: "Cards",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "507585",
                column: "CMC",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "507586",
                column: "CMC",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "507587",
                column: "CMC",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "507588",
                column: "CMC",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: "507589",
                column: "CMC",
                value: 0.0);
        }
    }
}
