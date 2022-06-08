using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CurrencyModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForexBuying = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForexSelling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BanknoteBuying = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BanknoteSelling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrossRateUSD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrossRateOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyModels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrencyModels");
        }
    }
}
