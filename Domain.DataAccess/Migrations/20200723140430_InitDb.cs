using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.DataAccess.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IIN = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    Profile1 = table.Column<int>(nullable: false),
                    Profile2 = table.Column<int>(nullable: false),
                    University = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");
        }
    }
}
