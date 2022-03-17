using Microsoft.EntityFrameworkCore.Migrations;

namespace CVMTest.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coffies",
                columns: table => new
                {
                    CofeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CofeeType = table.Column<int>(type: "int", nullable: false),
                    Characteristics = table.Column<int>(type: "int", nullable: false),
                    CoffeeDecoratrion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coffies", x => x.CofeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coffies");
        }
    }
}
