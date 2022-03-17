using Microsoft.EntityFrameworkCore.Migrations;

namespace CVMTest.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coffies",
                columns: new[] { "CofeeId", "Characteristics", "CofeeType", "CoffeeDecoratrion" },
                values: new object[] { 1, 3, 0, 1 });

            migrationBuilder.InsertData(
                table: "Coffies",
                columns: new[] { "CofeeId", "Characteristics", "CofeeType", "CoffeeDecoratrion" },
                values: new object[] { 2, 2, 2, 1 });

            migrationBuilder.InsertData(
                table: "Coffies",
                columns: new[] { "CofeeId", "Characteristics", "CofeeType", "CoffeeDecoratrion" },
                values: new object[] { 3, 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coffies",
                keyColumn: "CofeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coffies",
                keyColumn: "CofeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coffies",
                keyColumn: "CofeeId",
                keyValue: 3);
        }
    }
}
