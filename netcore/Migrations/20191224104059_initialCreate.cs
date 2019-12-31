using Microsoft.EntityFrameworkCore.Migrations;

namespace netcore.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    SId = table.Column<string>(type: "char(20)", nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Cdt = table.Column<string>(type: "char(14)", nullable: false),
                    Mdt = table.Column<string>(type: "char(14)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.SId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
