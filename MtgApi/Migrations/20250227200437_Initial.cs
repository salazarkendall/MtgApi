using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MtgApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardExample",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ColorIdentity = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardExample", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardExample");
        }
    }
}
